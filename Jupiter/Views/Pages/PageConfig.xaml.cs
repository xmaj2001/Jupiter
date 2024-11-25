using Jupiter.Func;
using Jupiter.Gestor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Jupiter.Views.Pages
{
    /// <summary>
    /// Interação lógica para PageConfig.xam
    /// </summary>
    public partial class PageConfig : Page
    {
        private string LocalFoto = Jupiter.Properties.Settings.Default.Logo;
        private string AppLocation = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        private Galunos gir = new Galunos();
        private string Senha = Jupiter.Properties.Settings.Default.Senha;
        private bool MudarSenha = false;
        public PageConfig()
        {
            InitializeComponent();
            if (File.Exists(LocalFoto))
            {
                Logo.Source = new BitmapImage(new Uri(LocalFoto));
            }
            _totalalunos.Text = gir.TotalAlunos().ToString();
            if(Jupiter.Properties.Settings.Default.Escola == "ESCOLA PE.DANIEL BROTHIER N° 1126")
            {
                Escola.IsChecked = true;
            }
            else
            {
                Escola.IsChecked = false;
            }
        }
        void ValidarFoto(string url)
        {
            var file = new FileInfo(url);
            if (Validar.IsImagem(file.Extension))
            {
                var logo = new FileInfo(file.FullName);
                var lf = LocalFoto;
                Logo.Source = null;
                LocalFoto = AppLocation + @"xmaj\Logo\logo-" + Guid.NewGuid() + DateTime.Now.ToString().Replace("/", " ").Replace(":", " ") + ".jpg";
                logo.CopyTo(LocalFoto);
                Logo.Source = new BitmapImage(new Uri(LocalFoto));
                Jupiter.Properties.Settings.Default.Logo = LocalFoto;
                Jupiter.Properties.Settings.Default.Save();
                File.Delete(lf);
            }
            else
            {
                //var msbox = new MSBox();
                //msbox.ShowMS(MSBoxStato.AV, "ARQUIVO INCORRETO", "O sistema não aceita arquivo com este formato " + file.Extension.ToUpper() + " adicione arquivos com estes formatos png, jpg, jpeg, bmp");
            }
        }
        private void Button_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var result = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (result.Length > 0)
                {
                    ValidarFoto(result[0]);
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dia = new System.Windows.Forms.OpenFileDialog();
            dia.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            var result = dia.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ValidarFoto(dia.FileName);
            }
        }
        private async void cobrarDia_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validar.IsNumero(e.Text);
            await Task.Delay(TimeSpan.FromMilliseconds(15));
        }
        private void cobrarDia_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(cobrarDia.Text)) cobrarDia.Text = "1";
        }

        private void btn_alterar_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(sh.Password))
            {
                Snackbar.IsActive = true;
                snackMS.Content = "O campo senha não pode ser vazio";
                snackMS.Foreground = Brushes.White;
                sh.Focus();
            }
            else
            {
                if (MudarSenha)
                {
                    NovaSenha();
                }
                else
                {
                    VerificarSenha();
                }
            }

        }
        void VerificarSenha()
        {
            if (sh.Password == Senha)
            {
                hittextSenha.Text = "Digita nova senha";
                MudarSenha = true;
                sh.Password = "";
                Snackbar.IsActive = true;
                snackMS.Content = "Podes alterar a senha";
                snackMS.Foreground = Brushes.LimeGreen;
                sh.Focus();
            }
            else
            {
                Snackbar.IsActive = true;
                snackMS.Content = "A senha está errada";
                snackMS.Foreground = Brushes.YellowGreen;
                sh.Focus();
            }
        }
        void NovaSenha()
        {
            Jupiter.Properties.Settings.Default.Senha = sh.Password;
            Jupiter.Properties.Settings.Default.Save();
            MudarSenha = false;
            hittextSenha.Text = "Digita senha atual";
            sh.Password = "";
            Snackbar.IsActive = true;
            snackMS.Content = "Nova senha definida";
            snackMS.Foreground = Brushes.LimeGreen;
            sh.Focus();

        }
        private void snackMS_ActionClick(object sender, RoutedEventArgs e)
        {
            Snackbar.IsActive = false;
        }

        private void sh_PreviewKeyDown(object sender, KeyEventArgs e)
        {
           if(e.Key == Key.Enter)
            {
                if (string.IsNullOrWhiteSpace(sh.Password))
                {
                    Snackbar.IsActive = true;
                    snackMS.Content = "O campo senha não pode ser vazio";
                    snackMS.Foreground = Brushes.White;
                    sh.Focus();
                }
                else
                {
                    if (MudarSenha)
                    {
                        NovaSenha();
                    }
                    else
                    {
                        VerificarSenha();
                    }
                }
            }
        }


        private void Escola_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void Escola_Click(object sender, RoutedEventArgs e)
        {
            if (Escola.IsChecked.Value)
            {
                Jupiter.Properties.Settings.Default.Escola = "ESCOLA PE.DANIEL BROTHIER N° 1126";
                Jupiter.Properties.Settings.Default.Save();
            }
            else
            {
                Jupiter.Properties.Settings.Default.Escola = "ESCOLA PE LIBERMANN N° 1111-MAIANGA";
                Jupiter.Properties.Settings.Default.Save();
            }
        }
    }
}

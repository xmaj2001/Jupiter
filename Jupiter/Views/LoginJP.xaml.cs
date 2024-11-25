using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Jupiter.Views
{
    /// <summary>
    /// Lógica interna para LoginJP.xaml
    /// </summary>
    public partial class LoginJP : Window
    {
        private int resitSenha = 0;
        private bool RisetS = false;
        public LoginJP()
        {
            InitializeComponent();
            Retorno_BeginStoryboard.Storyboard.Completed += (o, e) =>
            {
                this.Close();
            };
        }
        private void Logar_Click(object sender, RoutedEventArgs e)
        {
            LogandoSystem();
        }

        private void BT_Exit_Click(object sender, RoutedEventArgs e)
        {
            Retorno_BeginStoryboard.Storyboard.Begin();
        }
       async void LogandoSystem()
        {
            if (_pwd.Password == Jupiter.Properties.Settings.Default.Senha && RisetS == false)
            {
                Retorno_BeginStoryboard.Storyboard.Begin();
                await Task.Delay(TimeSpan.FromSeconds(1));
                var main = new AppMain();
                main.Show();
            }
            else
            {
                resitSenha++;
                if (_pwd.Password.ToUpper() == "XMAJ-JP" && resitSenha == 5)
                {
                    RisetS = true;
                }

                if (RisetS == false)
                {
                    var msb = new Modal.MSBox();
                    msb.ShowMS(Modal.MSBoxStato.SN, "A SENHA ESTÁ ERRADA", "");
                }
                else
                {
                    Jupiter.Properties.Settings.Default.Senha = "jp2023";
                    Jupiter.Properties.Settings.Default.Save();
                    var msb = new Modal.MSBox();
                    await Task.Delay(TimeSpan.FromSeconds(4));
                    msb.ShowMS(Modal.MSBoxStato.SU, "A SENHA ESTÁ REDEFINIDA", "Agora tenta novamente com a senha inicial do sistema");
                    _pwd.Password = "";
                    RisetS = false;
                    resitSenha = 0;
                }
            }
        }
        private void _pwd_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LogandoSystem();
            }
        }

        private void textBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

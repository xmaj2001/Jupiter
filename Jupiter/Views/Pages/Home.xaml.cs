using AForge.Video.DirectShow;
using Jupiter.Func;
using Jupiter.Gestor;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interação lógica para Home.xam
    /// </summary>
    public partial class Home : Page
    {
        private Galunos Gal = new Galunos();
        private Gpagamentos Gp = new Gpagamentos();
        private GhistoricoDia Gh = new GhistoricoDia();
        private CultureInfo cu = new CultureInfo("pt-AO");
        private FilterInfoCollection Cameras;
        public Home()
        {
            InitializeComponent();
            Cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in Cameras)
            {
                ListaCam.Items.Add(item.Name);
            }
            if (ListaCam.Items.Count > 0)
            {
                ListaCam.SelectedIndex = 0;
            }
            else
            {
                btn_scannerVP.IsEnabled = true;
                btn_scannerCode.IsEnabled = true;
            }
            mes2.Text = DateTime.Now.ToString("MMMM").ToUpper();
            Dia.Text = DateTime.Now.ToString("D").ToUpper();
        }

        async void Load_UI()
        {
            Gh.Load();
            _totalAlunos.Text = await Task.FromResult(Gal.TotalAlunos(DateTime.Now.Year).ToString());

            var data = DateTime.Parse("1/" + DateTime.Now.Date.Month + "/" + DateTime.Now.Date.Year);

            _totaldevidores.Text = await Task.FromResult(Gp.GetDevidores(data).ToString());

            _feichodia.Text = await Task.FromResult(Gh.TotalDia(DateTime.Now).ToString("C", cu));
            hide.Visibility = Visibility.Collapsed;
            _Pesquizar.Text = "";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Load_UI();
        }

        private async void _Pesquizar_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validar.IsNumero(e.Text);
            await Task.Delay(TimeSpan.FromMilliseconds(15));
        }
        private void _Pesquizar_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) e.Handled = true;
            if (e.Key == Key.Enter)
            {
                _Pesquizar.Text = _Pesquizar.Text.Trim();
                if (!string.IsNullOrWhiteSpace(_Pesquizar.Text) && Validar.IsNumero(_Pesquizar.Text))
                {
                    var aluno = Gal.GetAluno(int.Parse(_Pesquizar.Text));
                    if (aluno != null)
                    {
                        this.NavigationService.Navigate(new PageAluno(aluno));
                    }
                    else
                    {
                        var msb = new Modal.MSBox();
                        msb.ShowMS(Modal.MSBoxStato.ID, $"ALUNO COM ID {_Pesquizar.Text} NÃO ENCONTRADO", "O ID DO ALUNO QUE VOCÊ DIGITOU NÃO FOI LOCALIZADO");
                    }
                }
            }
        }
        private void btn_Vp_by_numero_Click(object sender, RoutedEventArgs e)
        {
            hide.Visibility = Visibility.Visible;
            var Modal = new Modal.ModalVpagamento();
            Modal.ShowDialog();
            if (Modal.Detalhes != null)
            {
                this.NavigationService.Navigate(new PageAluno(Modal.Detalhes));
            }
            hide.Visibility = Visibility.Collapsed;
        }

        private void btn_scannerCode_Click(object sender, RoutedEventArgs e)
        {
            if (ListaCam.Items.Count > 0 && ListaCam.SelectedIndex >= 0)
            {
                var modelCode = new ScannerCode(ListaCam.SelectedIndex);
                modelCode.ShowDialog();
                var resultCode = modelCode.Code;
                if (!string.IsNullOrWhiteSpace(resultCode))
                {
                    var result = DecoderCodeBar.Decoder(resultCode);
                    if (result != null)
                    {
                        var aluno = Gal.GetAluno(result.ID);
                        if (aluno != null)
                        {
                            this.NavigationService.Navigate(new PageAluno(aluno));
                        }
                        else
                        {
                            var msb = new Modal.MSBox();
                            msb.ShowMS(Modal.MSBoxStato.code, "CÓDIGO DE BARRAS INVÁLIDO", "ESTE CÓDIGO NÃO PERTENCE A UM ALUNO REGISTRADO NO SISTEMA");
                        }
                    }
                    else
                    {
                        var msb = new Modal.MSBox();
                        msb.ShowMS(Modal.MSBoxStato.code, "CÓDIGO DE BARRAS INVÁLIDO", "");
                    }
                }
            }
            else
            {
                btn_scannerVP.IsEnabled = true;
                btn_scannerCode.IsEnabled = true;
            }
        }

        private void btn_scannerVP_Click(object sender, RoutedEventArgs e)
        {
            if (ListaCam.Items.Count > 0 && ListaCam.SelectedIndex >= 0)
            {
                ListaCam.SelectedIndex = 0;
                hide.Visibility = Visibility.Visible;
                var Modal = new Modal.ModalVpagamento(ListaCam.SelectedIndex);
                Modal.ShowDialog();
                if (Modal.Detalhes != null)
                {
                    this.NavigationService.Navigate(new PageAluno(Modal.Detalhes));
                }
                hide.Visibility = Visibility.Collapsed;
            }
            else
            {
                btn_scannerVP.IsEnabled = true;
                btn_scannerCode.IsEnabled = true;
            }

        }
    }
}

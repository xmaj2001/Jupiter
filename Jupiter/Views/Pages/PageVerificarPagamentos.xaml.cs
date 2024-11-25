using Jupiter.Func;
using Jupiter.Gestor;
using Jupiter.Model;
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
    /// Interação lógica para PageVerificarPagamentos.xam
    /// </summary>
    public partial class PageVerificarPagamentos : Page
    {
        private Galunos gir_aluno = new Galunos();
        private Gpagamentos gir = new Gpagamentos();
        public PageVerificarPagamentos()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            for (int i = 1; i <= 12; i++)
            {
                listaMeses.Items.Add(DateTimeFormatInfo.CurrentInfo.GetMonthName(i).ToUpper());
            }

            if (listaClasses.Items.Count <= 0)
            {
                listaClasses.Items.Add("TODAS");
                for (int i = 1; i <= 13; i++)
                {
                    listaClasses.Items.Add(i + "ª Classe");
                }
                listaClasses.SelectedIndex = 0;
            }

            if (listaSalas.Items.Count <= 0)
            {
                listaSalas.Items.Add("TODAS");
                for (int i = 1; i <= 99; i++)
                {
                    listaSalas.Items.Add("Sala Nª "+i);
                }

                listaSalas.SelectedIndex = 0;
            }

           
            listaMeses.SelectedIndex = DateTime.Now.Month - 1;
            _anoLetivo.Text = DateTime.Now.Year.ToString();
            VerificarData(true);
        }
        void VerificarData(bool now = false)
        {
            var cl = 0;
            var sl = 0;
            if (listaClasses.SelectedIndex != 0)
            {
                cl = listaClasses.SelectedIndex;
            }
            if (listaSalas.SelectedIndex != 0)
            {
                sl = listaSalas.SelectedIndex;
            }

            var d = "01/" + (listaMeses.SelectedIndex + 1) + "/" + _anoLetivo.Text;
            var date = DateTime.Parse(d);
            if (now) date = DateTime.Now.Date;
            var pagaram = new List<Aluno>();
            if (tipo.SelectedIndex == 1)
            {
                pagaram = gir.GetAlunoNaoPagaram(date,cl,sl,listaTurmas.Text);
            }
            else
            {
                pagaram = gir.GetAlunoPagaram(date, cl, sl, listaTurmas.Text);
            }
            if (pagaram.Count > 0)
            {
                _total.Text = pagaram.Count.ToString();
                _total.FontSize = 30;
                _statos.Text = ""; 
                var texta = "ALUNO ";
                var textb = "FEZ ";
                if (pagaram.Count > 1)
                {
                    texta = "ALUNOS ";
                    textb = "FIZERAM ";
                }
                if (tipo.SelectedIndex == 1)
                {
                    _statos.Text = texta+"NÃO "+ textb + "PAGAMENTO";
                    _statos.Foreground = Brushes.White;
                }
                else
                {
                    _statos.Text = texta+ textb+"PAGAMENTO";
                    _statos.Foreground = Brushes.White;
                }
            }
            else
            {
                _total.FontSize = 16;
                _total.Text = "";
                _statos.Foreground = Brushes.Cyan;
                _statos.Text = "SEM REGISTROS";
            }
            _date.Text = date.ToString("MMMM yyyy").ToUpper();

            listaDia.ItemsSource = pagaram;
           
            listaDia.Items.Refresh();
            detalhes.Visibility = Visibility.Visible;
            modal.IsOpen = false;
        }
        private void listaDia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listaDia.SelectedItem != null)
            {
                var aluno = (Aluno)listaDia.SelectedItem;
                if (aluno != null)
                {
                    listaDia.SelectedIndex = -1;
                    this.NavigationService.Navigate(new PageAluno(aluno));
                }
            }
        }
        private void btn_confirmar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(listaMeses.Text) && !string.IsNullOrWhiteSpace(_anoLetivo.Text))
            {
                VerificarData();
            }
        }

        private void _btn_open_modal_Click(object sender, RoutedEventArgs e)
        {
            modal.IsOpen = true;
        }

        private async void _dia_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validar.IsNumero(e.Text);
            await Task.Delay(TimeSpan.FromMilliseconds(15));
        }

        private void _anoLetivo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void _anoLetivo_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void listaTurmas_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) e.Handled = true;
        }
    }
}

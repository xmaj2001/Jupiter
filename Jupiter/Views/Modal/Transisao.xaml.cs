using Jupiter.Func;
using Jupiter.Model;
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

namespace Jupiter.Views.Modal
{
    /// <summary>
    /// Lógica interna para Transisao.xaml
    /// </summary>
    public partial class Transisao : Window
    {
        private Pagamento _paga = null;
        private List<Pagamento> _pagas = null;
        private Aluno _aluno = null;
        private bool GerarPagaemntos = false;
        public Transisao(Aluno aluno, Pagamento paga)
        {
            InitializeComponent();
            if (Jupiter.Properties.Settings.Default.ListaRicibo == null)
            {
                Jupiter.Properties.Settings.Default.ListaRicibo = new System.Collections.Specialized.StringCollection();
            }
            GerarPagaemntos = false;
            _aluno = aluno;
            _paga = paga;
        }

        public Transisao(Aluno aluno, List<Pagamento> pagas)
        {
            InitializeComponent();
            if (Jupiter.Properties.Settings.Default.ListaRicibo == null)
            {
                Jupiter.Properties.Settings.Default.ListaRicibo = new System.Collections.Specialized.StringCollection();
            }
            GerarPagaemntos = true;
            _aluno = aluno;
            _pagas = pagas;
        }
        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) e.Handled = true;
        }

        private async void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validar.IsNumero(e.Text);
            await Task.Delay(TimeSpan.FromMilliseconds(15));
        }
        void GerarPDF()
        {
            if (GerarPagaemntos)
            {
                Gerar.ReciboPagamento(_aluno, _pagas,campoTransicao.Text);
            }
            else
            {
                Gerar.ReciboPagamento(_aluno, _paga, campoTransicao.Text);
            }
            this.Close();
        }
        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(campoTransicao.Text) && Validar.IsNumero(campoTransicao.Text) && int.Parse(campoTransicao.Text) > 0)
            {
                if (!Jupiter.Properties.Settings.Default.ListaRicibo.Contains(campoTransicao.Text))
                {
                    Jupiter.Properties.Settings.Default.ListaRicibo.Add(campoTransicao.Text);
                    Jupiter.Properties.Settings.Default.Save();
                    GerarPDF();
                }
                else
                {
                    var msb = new Modal.MSBox();
                    msb.ShowMS(MSBoxStato.rb, "ESTA TRANSAÇÃO JA FOI FEITA", "DESEJA GERAR O PDF MESMO ASSIM");
                    if (msb.Result)
                    {
                        GerarPDF();
                    }
                }
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) this.DragMove();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GerarTrans()
        {
            var lista = new List<int>();
            foreach (var item in Jupiter.Properties.Settings.Default.ListaRicibo)
            {
                lista.Add(int.Parse(item));
            }
            if (lista.Count > 0)
            {
                var itens = from item in lista orderby item descending select item;
                campoTransicao.Text = itens.ToList()[0].ToString();

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GerarTrans();
        }
    }
}

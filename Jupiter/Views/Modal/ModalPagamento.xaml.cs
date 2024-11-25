using Jupiter.Gestor;
using Jupiter.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica interna para ModalPagamento.xaml
    /// </summary>
    public partial class ModalPagamento : Window
    {
        private Gpagamentos gir = new Gpagamentos();
        private GhistoricoDia girDia = new GhistoricoDia();
        private CultureInfo cu = new CultureInfo("pt-AO");
        private Pagamento _pagar = null;
        private bool editar = false;
        private int anol = 0;
        private Aluno aluno = null;
        public ModalPagamento(Aluno al)
        {
            InitializeComponent();
            gir.Load(al.ID);
            aluno = al;
            _pagar = new Pagamento();
            _pagar.IDAluno = al.ID;
            anol = al.Ano;
            LoadMeses();
        }

        public ModalPagamento(Pagamento paga)
        {
            InitializeComponent();
            _pagar = paga;
            gir.Load(paga.IDAluno);
            LoadMeses(paga.Data.Month);
            _titulom.Text = "Mês Pagado";
            btn_Action.Content = "Atualizar";
            propina.Text = paga.Propina.ToString();
            Multa.Text = paga.Multa.ToString();
            dvm.IsChecked = _pagar.DVM;
            editar = true;
            if (_pagar.TPA)
            {
                _TipoPagaemnto.SelectedIndex = 1;
            }
            Titulo.Text = "Atualizar Pagamento";
        }

        void LoadMeses()
        {
            List<MesItem> meses = new List<MesItem>();
            var pago = gir.Meses();
            for (int i = 1; i <= 12; i++)
            {
                if (!pago.Contains(i))
                    meses.Add(new MesItem(i));
            }
            _meses.ItemsSource = meses;
        }
        void LoadMeses(int mes)
        {
            List<MesItem> meses = new List<MesItem>();
            var pago = gir.Meses(mes);
            for (int i = 1; i <= 12; i++)
            {
                if (!pago.Contains(i))
                    meses.Add(new MesItem(i));
            }
            _meses.ItemsSource = meses;

        }
        private void View_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) this.DragMove();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_Action_Click(object sender, RoutedEventArgs e)
        {
            decimal multa = 0;
            var mes = (MesItem)_meses.SelectedItem;
            if(!string.IsNullOrWhiteSpace(propina.Text) && !string.IsNullOrWhiteSpace(Multa.Text))
            {
                _pagar.Propina = Decimal.Parse(propina.Text);
                _pagar.Multa = multa;
                _pagar.Multa = Decimal.Parse(Multa.Text);
                if(_TipoPagaemnto.SelectedIndex == 0)
                {
                    _pagar.TPA = false;
                }
                else
                {
                    _pagar.TPA = true;
                }
                if (!editar)
                {
                    try
                    {
                        _pagar.Data = new DateTime(anol, mes.Valor,1);
                        gir.Add(_pagar);
                        var total = _pagar.Propina + _pagar.Multa;
                        girDia.addDia(DateTime.Now.Date);
                        _pagar.Total = total;
                        this.Close();
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }
                }
                else
                {
                    _pagar.Data = new DateTime(_pagar.Data.Year, mes.Valor, _pagar.Data.Day);
                    gir.Atualizar(_pagar);
                    this.Close();
                }
            }
        }

        private void propina_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(propina.Text))
            {
                _p.Text = double.Parse(propina.Text).ToString("C", cu);
            }
            else
            {
                _p.Text = double.Parse("0").ToString("C", cu);
            }
        }

        private void Multa_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Multa.Text))
            {
                _m.Text = double.Parse(Multa.Text).ToString("C", cu);
            }
            else
            {
                _m.Text = double.Parse("0").ToString("C", cu);
            }
        }

        private async void propina_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
            await Task.Delay(TimeSpan.FromMilliseconds(15));
        }

        private void propina_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) e.Handled = true;
        }

        private void _meses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_meses.SelectedItem != null)
            {
                var ms = (MesItem)_meses.SelectedItem;
                displayMes.Text = ms.Nome;
            }
        }

        private void propina_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {

        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            _pagar.DVM = dvm.IsChecked.Value;
        }

        private void dvm_Click(object sender, RoutedEventArgs e)
        {
            _pagar.DVM = dvm.IsChecked.Value;
        }
    }
}

using Jupiter.Func;
using Jupiter.Gestor;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Jupiter.Views.Pages
{
    /// <summary>
    /// Interação lógica para PageAluno.xam
    /// </summary>
    public partial class PageAluno : Page
    {
        private Aluno _aluno = null;
        private Gpagamentos gir = new Gpagamentos();
        private Galunos ga = new Galunos();
        public PageAluno(Aluno aluno)
        {
            InitializeComponent();
            _aluno = aluno;
            if (_aluno != null)
            {
                this.DataContext = _aluno;
                Load();
            }
          
        }
       
        void Load()
        {
            gir.Load(_aluno);
            var ms = gir.GetPagamentos();
            if (ms.Count >= 12) btn_add_Pagamento.Visibility = Visibility.Collapsed;
            _ListaPagamentos.ItemsSource = ms;
            _ListaPagamentos.Items.Refresh();
        }
        private void _btn_Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void _Editar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var modal = new Modal.ModalAluno(ga.GetAluno(_aluno.ID));
                HideView.Visibility = Visibility.Visible;
                modal.ShowDialog();
                if (modal.aluno_ != null)
                {
                    _aluno = modal.aluno_;
                    this.DataContext = null;
                    this.DataContext = _aluno;
                }
                HideView.Visibility = Visibility.Collapsed;
            }
            catch (Exception er)
            {
                var ms = new Modal.MSBox();
                ms.ShowMS(Modal.MSBoxStato.ER, "Ocorreu um problema", er.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(_ListaPagamentos.SelectedItem != null && _ListaPagamentos.SelectedItems.Count == 1)
            {
                var modal = new Modal.ModalPagamento((Pagamento)_ListaPagamentos.SelectedItem);
                HideView.Visibility = Visibility.Visible;
                modal.ShowDialog();
                HideView.Visibility = Visibility.Collapsed;
                editar.Visibility = Visibility.Collapsed;
                recibo.Visibility = Visibility.Collapsed;
                dell.Visibility = Visibility.Collapsed;
                Load();
            }
        }
        private void _ListaPagamentos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_ListaPagamentos.SelectedItem != null) {
               
                if(_ListaPagamentos.SelectedItems.Count > 1)
                {
                    EdiarP.Visibility = Visibility.Visible;
                    editar.Visibility = Visibility.Collapsed;
                    dell.Visibility = Visibility.Collapsed;
                    recibo.Visibility = Visibility.Visible;
                }
                else
                {
                    recibo.Visibility = Visibility.Visible;
                    editar.Visibility = Visibility.Visible;
                    dell.Visibility = Visibility.Visible;
                }
            }
        }
        private void btn_add_Pagamento_Click(object sender, RoutedEventArgs e)
        {
            var modal = new Modal.ModalPagamento(_aluno);
            HideView.Visibility = Visibility.Visible;
            modal.ShowDialog();
            HideView.Visibility = Visibility.Collapsed;
            Load();
        }
        private void gerar_Pagamento_Click(object sender, RoutedEventArgs e)
        {
            Gerar.RelatorioPagamento(_aluno, gir.GetPagamentos());
        }
        private void recibo_Click(object sender, RoutedEventArgs e)
        {
            if (_ListaPagamentos.SelectedItem != null && _ListaPagamentos.SelectedItems.Count == 1)
            {
                var gmodal = new Modal.Transisao(_aluno, (Pagamento)_ListaPagamentos.SelectedItem);
                gmodal.ShowDialog();
            }
            else if (_ListaPagamentos.SelectedItem != null && _ListaPagamentos.SelectedItems.Count > 1)
            {
                var pagamentos = new List<Pagamento>();
                foreach (var item in _ListaPagamentos.SelectedItems)
                {
                    pagamentos.Add((Pagamento)item);
                }
                var gmodal = new Modal.Transisao(_aluno, pagamentos);
                gmodal.ShowDialog();
            }
        }

        private void gerarCard_Click(object sender, RoutedEventArgs e)
        {
            Gerar.CartaoAluno(_aluno);
        }
        private void PrintCode_Click(object sender, RoutedEventArgs e)
        {
            Gerar.CodeBarraAluno(_aluno);
        }
        private void AnoNovo_Click(object sender, RoutedEventArgs e)
        {
            var modal = new Modal.ModalAluno(ga.GetAluno(_aluno.ID), true);
            modal.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var msb = new Modal.MSBox();
            msb.ShowMS(Modal.MSBoxStato.DEL, "VOCÊ PRETENDE DELETAR OS DADOS DESSE ALUNO?", "ESTÁ AÇÃO VAI APAGAR TAMBÉM OS REGISTRO DE PAGAMENTO DO ALUNO. TENS A CERTEZA QUE QUERES APAGAR OS DADOS DO ALUNO?");
            if (msb.Result)
            {
                ga.Apagar(_aluno);
                this.NavigationService.GoBack();
            }
        }

        private void dell_Click(object sender, RoutedEventArgs e)
        {
            var msb = new Modal.MSBox();
            msb.ShowMS(Modal.MSBoxStato.DEL, "VOCÊ PRETENDE DELETAR ESSE PAGAMENTO?", "ESTÁ AÇÃO VAI ALTERAR O HISTÓRICO DO DIA DE PAGAMENTO");
            if (msb.Result)
            {
                gir.Apagar((Pagamento)_ListaPagamentos.SelectedItem);
                Load();
                _ListaPagamentos.SelectedIndex = -1;
                editar.Visibility = Visibility.Collapsed;
                recibo.Visibility = Visibility.Collapsed;
                dell.Visibility = Visibility.Collapsed;
            }
        }
    }
}

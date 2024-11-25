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
    /// Interação lógica para PageDiaTotal.xam
    /// </summary>
    public partial class PageDiaTotal : Page
    {
        private Gpagamentos gir = new Gpagamentos();
        private Galunos gir_aluno = new Galunos();
        private HistoricoDia histo = null;
        public PageDiaTotal(HistoricoDia dia)
        {
            InitializeComponent();
            histo = dia;
        }
        async void Load(HistoricoDia dia)
        {
            totaldia.Text = "Carregando..";
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            var lista = await Task.FromResult(gir.GetPagamentosDia(dia.Dia));
            totaldia.Text = dia.Total.ToString("C", new CultureInfo("pt-AO"));
            _alunos.Text = lista.Count.ToString();
            _date.Text = dia.Dia.ToString("D");
            listaDia.ItemsSource = lista;
            listaDia.SelectedIndex = - 1;
        }
        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Load(histo);
        }

        private void listaDia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listaDia.SelectedItem != null)
            {
                var pd = (TotalDia)listaDia.SelectedItem;
                var aluno = gir_aluno.GetAluno(pd.IDaluno);
                this.NavigationService.Navigate(new PageAluno(aluno));
            }
        }

        private void gerarPDF_Click(object sender, RoutedEventArgs e)
        {
            Gerar.RelatorioFeichoDia(histo);
        }
    }
}

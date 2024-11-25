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
    /// Interação lógica para PageHistoricoDia.xam
    /// </summary>
    public partial class PageHistoricoDia : Page
    {
        private GhistoricoDia gir = new GhistoricoDia();
        private HistoricoDia primeiroH = null;
        public PageHistoricoDia()
        {
            InitializeComponent();
            gerarPDF.Visibility = Visibility.Collapsed;
            Load();
        }

        void Load()
        {
            var hist = gir.GetDias();
            if(hist.Count > 0)
            {
                primeiroH = hist[0];
                totaldia.Text = hist[0].Total.ToString("C", new CultureInfo("pt-AO"));
                _date.Text = hist[0].Dia.ToString("D");
                gerarPDF.Visibility = Visibility.Visible;
            }
            listaDia.ItemsSource = hist;
            listaDia.Items.Refresh();
            listaDia.SelectedIndex = -1;
        }

        private void listaDia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listaDia.SelectedItem != null)
            {

                this.NavigationService.Navigate(new PageDiaTotal((HistoricoDia)listaDia.SelectedItem));
                listaDia.SelectedIndex = -1;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(primeiroH != null)
            {
                Gerar.RelatorioFeichoDia(primeiroH);
            }
        }

        private void pesquisarData_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(pesquisarData.Text) && pesquisarData.SelectedDate != null)
            {
                var dia = DateTime.Parse(pesquisarData.Text);
                var hist = gir.Find(dia.ToString("d"));
                if (hist.Count > 0)
                {
                    primeiroH = hist[0];
                    totaldia.Text = hist[0].Total.ToString("C", new CultureInfo("pt-AO"));
                    _date.Text = hist[0].Dia.ToString("D");
                    gerarPDF.Visibility = Visibility.Visible;
                }
                listaDia.ItemsSource = hist;
                listaDia.Items.Refresh();
                listaDia.SelectedIndex = -1;
            }
            else
            {
                Load();
            }
        }
    }
}

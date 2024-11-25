using AForge.Video.DirectShow;
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
    /// Interação lógica para PageAlunos.xam
    /// </summary>
    public partial class PageAlunos : Page
    {
        private Galunos gir = null;
        private int ano = DateTime.Now.Year;
        private FilterInfoCollection Cameras;
        public PageAlunos()
        {
            InitializeComponent();
            gir = new Galunos();
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
                btn_code.IsEnabled = true;
            }
            
        }
        void LoadFull()
        {
            if (_Classes.SelectedIndex <= 0)
            {
                gir.LoadLista(ano);
                _totalAlunos.ToolTip = gir.TotalAlunos(ano) + " Alunos";
            }
            else
            {
                gir.LoadLista(_Classes.SelectedIndex, ano);
                _totalAlunos.ToolTip = gir.TotalAlunos(_Classes.SelectedIndex, ano) + " Alunos";
            }
            _ListaAlunos.ItemsSource = gir.All();
            _ListaAlunos.Items.Refresh();
        }
        void Load()
        {
            _ListaAlunos.ItemsSource = gir.All();
            _ListaAlunos.Items.Refresh();
        }
        void LoadClasses()
        {
            if(_Classes.Items.Count <= 0)
            {
                _Classes.Items.Add("TODAS");
                for (int i = 1; i <= 13; i++)
                {
                    _Classes.Items.Add(i + "ª Classe");
                }
            }
            
        }
        void Pesquisar(string Valor)
        {
            if (!Validar.IsNumero(Valor))
            {
                if (_Classes.SelectedIndex <= 0)
                {
                    _ListaAlunos.ItemsSource = gir.Find(Valor, ano);
                    _ListaAlunos.Items.Refresh();
                }
                else
                {
                    _ListaAlunos.ItemsSource = gir.Find(Valor, _Classes.SelectedIndex, ano);
                    _ListaAlunos.Items.Refresh();
                }
            }
            else
            {
                var numero = int.Parse(Valor);
                if (_Classes.SelectedIndex <= 0)
                {
                    _ListaAlunos.ItemsSource = gir.FindByNum(numero, ano);
                    _ListaAlunos.Items.Refresh();
                }
                else
                {
                    _ListaAlunos.ItemsSource = gir.FindByNum(numero, _Classes.SelectedIndex, ano);
                    _ListaAlunos.Items.Refresh();
                }
            }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadFull();
            _ListaAlunos.SelectedIndex = -1;
            LoadClasses();
            _Pesquizar.Text = "";
        }
        private void _Pesquizar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_Pesquizar.Text))
            {
                Pesquisar(_Pesquizar.Text);
            }
            else
            {
                Load();
            }
        }
        private void _ListaAlunos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_ListaAlunos.SelectedItem != null)
            {
                var aluno = (Aluno)_ListaAlunos.SelectedItem;
                this.NavigationService.Navigate(new PageAluno(aluno));
            }
        }

        private void _btn_add_Click(object sender, RoutedEventArgs e)
        {
            var modal = new Modal.ModalAluno();
            modal.ShowDialog();
            LoadFull();
        }

        private async void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validar.IsNumero(e.Text);
            await Task.Delay(TimeSpan.FromMilliseconds(15));
        }

        private void textAno_TextChanged(object sender, TextChangedEventArgs e)
        {
            textAno.Text = textAno.Text.Trim();
            if (!string.IsNullOrWhiteSpace(textAno.Text) && Validar.IsNumero(textAno.Text) && gir != null)
            {
                ano = int.Parse(textAno.Text);
                LoadFull();
            }
            else
            {
                textAno.Text = ano.ToString();
            }
        }

        private void _Classes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_Classes.SelectedIndex != 0 && gir != null)
            {
                LoadFull();
            }
            else if (_Classes.SelectedIndex <= 0 && gir != null)
            {
                LoadFull();
            }
        }

        private void btn_code_Click(object sender, RoutedEventArgs e)
        {
            if(ListaCam.SelectedIndex >= 0)
            {
                var modelCode = new ScannerCode(ListaCam.SelectedIndex);
                modelCode.ShowDialog();
                var resultCode = modelCode.Code;
                if (!string.IsNullOrWhiteSpace(resultCode))
                {
                    var result = DecoderCodeBar.Decoder(resultCode);
                    if (result != null)
                    {
                        var aluno = gir.GetAluno(result.ID);
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
        }
    }
}

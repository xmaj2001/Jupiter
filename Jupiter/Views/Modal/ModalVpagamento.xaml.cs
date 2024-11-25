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
using System.Windows.Shapes;

namespace Jupiter.Views.Modal
{
    /// <summary>
    /// Lógica interna para ModalVpagamento.xaml
    /// </summary>
    public partial class ModalVpagamento : Window
    {
        private Gpagamentos Gp = new Gpagamentos();
        private Galunos Ga = new Galunos();
        public Aluno Detalhes = null;
        private bool VCode = false;
        private int cam = 0;
        public ModalVpagamento()
        {
            InitializeComponent();
            LoadMeses();
        }


        public ModalVpagamento(int _cam)
        {
            InitializeComponent();
            LoadMeses();
            Numero.Visibility = Visibility.Collapsed;
            VCode = true;
            btn_Action.Margin = new Thickness(0, 100, 0, 0);
            btn_Action.Content = "Código de barras";
            cam = _cam;
        }
        void LoadMeses()
        {
            for (int i = 1; i <= 12; i++)
            {
                _meses.Items.Add(DateTimeFormatInfo.CurrentInfo.GetMonthName(i).ToUpper());
            }
            _meses.SelectedIndex = DateTime.Now.Month - 1;
        }
        private void View_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) this.DragMove();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        void NoCode()
        {
            Numero.Text = Numero.Text.Trim();
            if (string.IsNullOrWhiteSpace(Numero.Text))
            {
                Numero.Focus();
            }
            else
            {
                var aluno = Ga.GetAluno(int.Parse(Numero.Text));
                if (aluno != null)
                {
                    var data = new DateTime(aluno.Ano, _meses.SelectedIndex + 1, 1);
                    var paga = Gp.GetByDate(data, aluno.ID);
                    if (paga != null)
                    {
                        var modal = new Modal.ModalViewAluno(aluno, data, true);
                        modal.ShowDialog();

                        if (modal.Detalhes != null)
                        {
                            this.Detalhes = modal.Detalhes;
                            this.Close();
                        }
                    }
                    else
                    {
                        var modal = new Modal.ModalViewAluno(aluno, data, false);
                        modal.ShowDialog();
                        if (modal.Detalhes != null)
                        {
                            this.Detalhes = modal.Detalhes;
                            this.Close();
                        }
                    }
                }
                else
                {
                    var msb = new Modal.MSBox();
                    msb.ShowMS(Modal.MSBoxStato.ID, $"ALUNO COM ID {Numero.Text} NÃO ENCONTRADO", "O ID DO ALUNO QUE VOCÊ DIGITOU NÃO FOI LOCALIZADO");
                }
            }
        }
        private void btn_Action_Click(object sender, RoutedEventArgs e)
        {
            if (!VCode)
            {
                NoCode();
            }
            else
            {
                var modelCode = new ScannerCode(cam);
                modelCode.ShowDialog();
                var resultCode = modelCode.Code;
                if (!string.IsNullOrWhiteSpace(resultCode))
                {
                    var result = DecoderCodeBar.Decoder(resultCode);
                    if (result != null)
                    {
                        var aluno = Ga.GetAluno(result.ID); 
                        if (aluno != null)
                        {
                            var data = new DateTime(aluno.Ano, _meses.SelectedIndex + 1, 1);
                            var paga = Gp.GetByDate(data, aluno.ID);
                            if (paga != null)
                            {
                                var modal = new Modal.ModalViewAluno(aluno, data, true);
                                modal.ShowDialog();

                                if (modal.Detalhes != null)
                                {
                                    this.Detalhes = modal.Detalhes;
                                    this.Close();
                                }
                            }
                            else
                            {
                                var modal = new Modal.ModalViewAluno(aluno, data, false);
                                modal.ShowDialog();
                                if (modal.Detalhes != null)
                                {
                                    this.Detalhes = modal.Detalhes;
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            var msb = new Modal.MSBox();
                            msb.ShowMS(Modal.MSBoxStato.ID, $"ALUNO COM ID {result.ID.ToString()} NÃO ENCONTRADO", "O ID DO ALUNO QUE VOCÊ DIGITOU NÃO FOI LOCALIZADO");
                        }
                    }
                }
            }
        }

        private async void Numero_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validar.IsNumero(e.Text);
            await Task.Delay(TimeSpan.FromMilliseconds(15));
        }

        private void Numero_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) e.Handled = true;
        }

        private async void Ano_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validar.IsNumero(e.Text);
            await Task.Delay(TimeSpan.FromMilliseconds(15));
        }

        private void Ano_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) e.Handled = true;
        }
    }
}

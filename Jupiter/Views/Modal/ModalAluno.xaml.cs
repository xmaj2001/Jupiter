using Jupiter.Func;
using Jupiter.Gestor;
using Jupiter.Model;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica interna para ModalAluno.xaml
    /// </summary>
    /// 
    public enum Modo
    {
        Add,
        Edit,
        AnoNovo
    }
    public partial class ModalAluno : Window
    {
        private string AppLocation = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        private Galunos gir = new Galunos();
        private string LocalFoto = "";
        private string NovaFoto = "";
        private Aluno _aluno = null;
        public Aluno aluno_ = null;
        private Modo modo = Modo.Add;
        public ModalAluno()
        {
            InitializeComponent();
            _aluno = new Aluno();
            _aluno.Ano = DateTime.Now.Year;
            _ano.Text = DateTime.Now.Year.ToString();
            this.DataContext = _aluno;
        }

        public ModalAluno(Aluno aluno)
        {
            InitializeComponent();
            if (aluno != null)
            {
                _aluno = aluno;
                this.DataContext = _aluno;
                LoadDados();
                _titulo.Text = "Dados do Aluno";
                btn_action.Content = "Salvar";
                modo = Modo.Edit;
            }
        }

        public ModalAluno(Aluno aluno, bool Anovo)
        {
            InitializeComponent();
            if (aluno != null)
            {
                _aluno = aluno;
                this.DataContext = _aluno;
                LoadDados();
                _titulo.Text = "Novo Ano";
                btn_action.Content = "Atualizar";
                modo = Modo.AnoNovo;
            }
        }
        void LoadSC()
        {
            for (int i = 1; i <= 13; i++)
            {
                _Classes.Items.Add(i + "ª Classe");
            }

            for (int i = 1; i < 100; i++)
            {
                _Sala.Items.Add("Sala " + i);
            }
        }
        void LoadDados()
        {
            _nome.Text = _aluno.Nome;
            _numero.Text = _aluno.Numero.ToString();
            _Classes.SelectedIndex = (_aluno.Classe - 1);
            _Sala.SelectedIndex = (_aluno.Sala - 1);
            _Turma.Text = _aluno.Turma;
            _ano.Text = _aluno.Ano.ToString();
        }

        private void _Modal_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) this.DragMove();
        }

        private void btn_foto_Click(object sender, RoutedEventArgs e)
        {
            var dia = new System.Windows.Forms.OpenFileDialog();
            dia.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            var result = dia.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ValidarFoto(dia.FileName);
            }
        }
        void ValidarFoto(string url)
        {
            var file = new FileInfo(url);
            if (Validar.IsImagem(file.Extension))
            {
                var img = new FileInfo(file.FullName);
                NovaFoto = img.FullName;
                LocalFoto = AppLocation + @"Imagens\" + Guid.NewGuid() + DateTime.Now.ToString().Replace("/", " ").Replace(":", " ") + ".jpg";
                btn_foto.Background = new ImageBrush(new BitmapImage(new Uri(NovaFoto)));
            }
            else
            {
                var msbox = new MSBox();
                msbox.ShowMS(MSBoxStato.AV, "ARQUIVO INCORRETO", "O sistema não aceita arquivo com este formato " + file.Extension.ToUpper() + " adicione arquivos com estes formatos png, jpg, jpeg, bmp");
            }
        }
        private void btn_foto_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var result = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (result.Length > 0)
                {
                    ValidarFoto(result[0]);
                }
            }
        }

        private void _nome_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_nome.Text)) _aluno.Nome = _nome.Text;
        }

        private void btn_action_Click(object sender, RoutedEventArgs e)
        {
            _nome.Text = _nome.Text.TrimEnd();
            if (_numero.Text == "0") _numero.Text = "1";
            if (!Validar.IsNome(_nome.Text))
            {
                _nome.Focus();
                _nome.BorderBrush = Brushes.Red;
            }
            else if (!Validar.IsNumero(_numero.Text))
            {
                _numero.Focus();
                _nome.BorderBrush = Brushes.Black;
            }
            else if (!Validar.IsTurma(_Turma.Text))
            {
                _Turma.Focus();
                _nome.BorderBrush = Brushes.Black;
                _numero.BorderBrush = Brushes.Black;
            }
            else if (string.IsNullOrWhiteSpace(_ano.Text))
            {
                _ano.Focus();
            }
            else
            {
                _aluno.Numero = int.Parse(_numero.Text);
                _aluno.Classe = _Classes.SelectedIndex + 1;
                _aluno.Sala = _Sala.SelectedIndex + 1;
                _aluno.Turma = _Turma.Text;
                _aluno.Ano = int.Parse(_ano.Text);
                if (LocalFoto != "")
                {
                    if (File.Exists(NovaFoto))
                    {
                        var file = new FileInfo(NovaFoto);
                        file.CopyTo(LocalFoto);
                        _aluno.Foto = LocalFoto;
                    }
                }
                var aluno = gir.GetAlunoByNCA(_aluno.Numero, _aluno.Sala, _aluno.Turma, _aluno.Classe, _aluno.Ano);
                _aluno.Turma = _aluno.Turma.ToUpper();
                switch (modo)
                {
                    case Modo.Add:
                        if (aluno == null)
                        {
                            gir.Add(_aluno);
                            var msb = new Modal.MSBox();
                            msb.ShowMS(MSBoxStato.SU, _aluno.Nome, "FOI REGISTRADO COM SUCESSO");
                            sair_BeginStoryboard.Storyboard.Begin();
                        }
                        else
                        {
                            var msb = new Modal.MSBox();
                            msb.ShowMS(MSBoxStato.Nu, $"ESTE NÚMERO {aluno.Numero} JÁ FOI ATRIBUÍDO A UM ALUNO ", $"O número {aluno.Numero} pertence a {aluno.Nome} na sala {aluno.Sala} na turma {aluno.Turma} e na {aluno.Classe}ª classe no ano letivo de {aluno.Ano}");
                        }
                        break;
                    case Modo.Edit:
                        if (aluno == null || aluno.ID == _aluno.ID)
                        {
                            var msb = new Modal.MSBox();
                            gir.Atualizar(_aluno);
                            msb.ShowMS(MSBoxStato.SU, _aluno.Nome, "FOI ATUALIZADO COM SUCESSO");
                            sair_BeginStoryboard.Storyboard.Begin();
                            aluno_ = _aluno;
                        }
                        else
                        {
                            var msb = new Modal.MSBox();
                            msb.ShowMS(MSBoxStato.Nu, $"ESTE NÚMERO {aluno.Numero} JÁ FOI ATRIBUÍDO A UM ALUNO ", $"O número {aluno.Numero} pertence a {aluno.Nome} na sala {aluno.Sala} na turma {aluno.Turma} e na {aluno.Classe}ª classe no ano letivo de {aluno.Ano}");
                        }
                        break;
                    case Modo.AnoNovo:
                        if (aluno == null)
                        {
                            var msb = new Modal.MSBox();
                            gir.Add(_aluno);
                            msb.ShowMS(MSBoxStato.SU, _aluno.Nome, "FOI REGISTRADO COM SUCESSO PARA O NOVO ANO LETIVO");
                            sair_BeginStoryboard.Storyboard.Begin();
                            aluno_ = _aluno;
                        }
                        else
                        {
                            var msb = new Modal.MSBox();
                            msb.ShowMS(MSBoxStato.Nu, $"ESTE NÚMERO {aluno.Numero} JÁ FOI ATRIBUÍDO A UM ALUNO ", $"O número {aluno.Numero} pertence a {aluno.Nome} na sala {aluno.Sala} na turma {aluno.Turma} e na {aluno.Classe}ª classe no ano letivo de {aluno.Ano}");
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void _gerarNumero_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void _numero_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validar.IsNumero(e.Text);
            await Task.Delay(TimeSpan.FromMilliseconds(15));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            sair_BeginStoryboard.Storyboard.Completed += Storyboard_Completed;
            LoadSC();
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }
        private async void _ano_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validar.IsNumero(e.Text);
            await Task.Delay(TimeSpan.FromMilliseconds(15));
        }
    }
}

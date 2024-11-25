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
    /// Lógica interna para ModalViewAluno.xaml
    /// </summary>
    public partial class ModalViewAluno : Window
    {
        private Aluno Aluno = null;
        public Aluno Detalhes = null;
        public ModalViewAluno(Aluno al,DateTime data,bool pagou)
        {
            InitializeComponent();
            Aluno = al;
            this.DataContext = Aluno;
            if (pagou)
            {
                statos.Text = "PAGOU";
                statos.Foreground = Brushes.Green;
            }
            else
            {
                statos.Text = "NÃO PAGOU";
                statos.Foreground = Brushes.Red;
            }
            textMes.Text = "O MÊS DE " + data.ToString("MMMM").ToString().ToUpper()+" EM "+ data.Year;
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) this.DragMove();
        }

        private void btn_detlhes_Click(object sender, RoutedEventArgs e)
        {
            if (Aluno != null)
            {
                Detalhes = Aluno;
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

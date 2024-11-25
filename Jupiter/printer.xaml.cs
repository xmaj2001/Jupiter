using Jupiter.Func;
using Jupiter.Gestor;
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

namespace Jupiter
{
    /// <summary>
    /// Lógica interna para printer.xaml
    /// </summary>
    public partial class printer : Window
    {
        Galunos ga = new Galunos();
        Gpagamentos gp = new Gpagamentos();
        public printer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var aluno = ga.GetAluno(22);
           gp.Load(aluno);
            var pm = gp.GetPagamentos();
            //Gerar.ReciboPagamento(aluno, pm);
        }
    }
}

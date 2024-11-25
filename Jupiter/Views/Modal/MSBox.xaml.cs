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
    /// Lógica interna para MSBox.xaml
    /// </summary>
    public enum MSBoxStato
    {
        MS,
        AV,
        SN,
        ER,
        Nu,
        ID,
        SU,
        code,
        rb,
        DEL
    }
    public partial class MSBox : Window
    {
        private MSBoxStato _Statos = MSBoxStato.SU;
        public bool Result = false;
        public MSBox()
        {
            InitializeComponent();
            sair_BeginStoryboard.Storyboard.Completed += Storyboard_Completed;
        }
        private void Storyboard_Completed(object sender, EventArgs e)
        {
            this.Close();
        }
        void ViewStatos()
        {
            switch (_Statos)
            {
                case MSBoxStato.MS:
                    _TituloStatos.Text = "MENSAGEM";
                    _Titulo.Text = "Informação";
                    _Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Message;
                    _OK.Visibility = Visibility.Visible;
                    break;
                case MSBoxStato.AV:
                    _TituloStatos.Text = "AVISO";
                    _Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.WarningCircle;
                    _OK.Visibility = Visibility.Visible;
                    CorMS(Brushes.Yellow);
                    _Titulo.Foreground = Brushes.YellowGreen;
                    break;
                case MSBoxStato.ER:
                    _TituloStatos.Text = "ERRO";
                    _Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Error;
                    _OK.Visibility = Visibility.Visible;
                    CorMS(Brushes.Red);
                    break;

                case MSBoxStato.SN:
                    _TituloStatos.Text = "SENHA ERRADA";
                    _Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.LockAlert;
                    _OK.Visibility = Visibility.Visible;
                    CorMS(Brushes.Red);
                    break;

                case MSBoxStato.DEL:
                    _TituloStatos.Text = "APAGAR REGISTRO";
                    _Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DeleteCircleOutline;
                    _SIMNOT.Visibility = Visibility.Visible;
                    CorMS(Brushes.Red);
                    break;
                case MSBoxStato.rb:
                    _TituloStatos.Text = "JA EMITIDO";
                    _Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Payment;
                    _SIMNOT.Visibility = Visibility.Visible;
                    CorMS(Brushes.Red);
                    break;
                case MSBoxStato.SU:
                    _TituloStatos.Text = "SUCESSO";
                    _Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Check;
                    _OK.Visibility = Visibility.Visible;
                    CorMS(Brushes.Green);
                    _TituloStatos.Foreground = Brushes.Lime;
                    break;
                case MSBoxStato.Nu:
                    _TituloStatos.Text = "NÚMERO";
                    _Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Numeric;
                    _OK.Visibility = Visibility.Visible;
                    CorMS(Brushes.Red);
                    _TituloStatos.Foreground = Brushes.Red;
                    break;
                case MSBoxStato.ID:
                    _TituloStatos.Text = "ID";
                    _Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.IdentificationCard;
                    _OK.Visibility = Visibility.Visible;
                    CorMS(Brushes.Red);
                    _TituloStatos.Foreground = Brushes.Red;
                    break;
                case MSBoxStato.code:
                    _TituloStatos.Text = "CÓDIGO DE BARRAS";
                    _Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Barcode;
                    _OK.Visibility = Visibility.Visible;
                    CorMS(Brushes.Red);
                    _TituloStatos.Foreground = Brushes.Red;
                    break;
                default:
                    break;
            }
        }
        public bool ShowMS(MSBoxStato statos, string tiulo, string info)
        {
            _Statos = statos;
            _Titulo.Text = tiulo;
            _MS.Text = info;
            ViewStatos();
            this.ShowDialog();
            return Result;
        }
        void CorMS(Brush cor)
        {
            _TituloStatos.Foreground = cor;
            _Titulo.Foreground = cor;
            _Icon.Foreground = cor;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Result = true;
            sair_BeginStoryboard.Storyboard.Begin();
        }
        private void btn_Not_Click(object sender, RoutedEventArgs e)
        {
            Result = false;
            sair_BeginStoryboard.Storyboard.Begin();
        }
        private void btn_close_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Card_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) this.DragMove();
        }
    }
}

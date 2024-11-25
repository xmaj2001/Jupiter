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
using Jupiter.Views;
using Jupiter.Views.Pages;

namespace Jupiter.Views
{
    /// <summary>
    /// Lógica interna para AppMain.xaml
    /// </summary>
    public partial class AppMain : Window
    {
        public AppMain()
        {
            InitializeComponent();
            Sair_BeginStoryboard.Storyboard.Completed += Storyboard_Completed;
            
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            this.Close();
        }

        async void Paginas()
        {
            Views.Navigate(await Task.FromResult(new Start()));
            _btn_Alunos.Click += async (o, e) =>
            {
                hide.Visibility = Visibility.Visible;
                Views.NavigationService.Navigate(await Task.FromResult(new Pages.PageAlunos()));
                hide.Visibility = Visibility.Collapsed;
            };

            _btn_historico.Click += async (o, e) =>
            {
                hide.Visibility = Visibility.Visible;
                Views.NavigationService.Navigate(await Task.FromResult(new Pages.PageHistoricoDia()));
                hide.Visibility = Visibility.Collapsed;
            };
            hide.Visibility = Visibility.Collapsed;
        }

        private void Card_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) this.DragMove();
        }

        private async void btn_Vpagamentos_Click(object sender, RoutedEventArgs e)
        {
            hide.Visibility = Visibility.Visible;
            Views.NavigationService.Navigate(await Task.FromResult(new PageVerificarPagamentos()));
            hide.Visibility = Visibility.Collapsed;
        }

        private async void btn_prin_Click(object sender, RoutedEventArgs e)
        {
            hide.Visibility = Visibility.Visible;
            Views.NavigationService.Navigate(await Task.FromResult(new Home()));
            hide.Visibility = Visibility.Collapsed;
        }

        private async void btn_settings_Click(object sender, RoutedEventArgs e)
        {
            hide.Visibility = Visibility.Visible;
            Views.NavigationService.Navigate(await Task.FromResult(new PageConfig()));
            hide.Visibility = Visibility.Collapsed;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Paginas();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Sair_BeginStoryboard.Storyboard.Begin();
        }

        private void btn_max_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void btn_mi_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ColorZone_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private async void btn_START_Click(object sender, RoutedEventArgs e)
        {
            hide.Visibility = Visibility.Visible;
            Views.NavigationService.Navigate(await Task.FromResult(new Start()));
            hide.Visibility = Visibility.Collapsed;
        }
    }
}

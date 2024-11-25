using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Jupiter
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {
        private string LocalFoto = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"xmaj\Logo\Logo.jpg";
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            if(Jupiter.Properties.Settings.Default.Logo == "")
            {
                Jupiter.Properties.Settings.Default.Logo = LocalFoto;
                Jupiter.Properties.Settings.Default.Save();
            }
        }
    }
}

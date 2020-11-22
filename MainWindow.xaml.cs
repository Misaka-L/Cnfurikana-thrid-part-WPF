using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Xml;
using Cnfurikana_thrid_part_WPF.Modules;
using Cnfurikana_thrid_part_WPF.UI;
using MaterialDesignThemes.Wpf;
using Microsoft.International.Converters.PinYinConverter;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cnfurikana_thrid_part_WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame ContentFrame = null;

        public MainWindow()
        {
            InitializeComponent();
            ContentFrame = MainFrame;
            try
            {
                Settings.LoadSettings();
                i18n.ReloadResource(Settings.AppSettings.Lang);
            }
            catch
            {
                Settings.SaveSettings();
                i18n.ReloadResource(Settings.AppSettings.Lang);
            }
            MainFrame.Navigate(new MainPage());
        }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {
            Settings.SaveSettings();
        }
    }
}

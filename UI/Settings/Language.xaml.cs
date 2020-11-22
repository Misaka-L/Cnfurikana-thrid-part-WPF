using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Cnfurikana_thrid_part_WPF.Modules;

namespace Cnfurikana_thrid_part_WPF.UI.Settings
{
    /// <summary>
    /// Language.xaml 的交互逻辑
    /// </summary>
    public partial class Language : Page
    {
        public Language()
        {
            InitializeComponent();
        }

        private void GoBackButton_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.ContentFrame.GoBack();
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((ListBox)sender).SelectedIndex)
            {
                case 0:
                    i18n.ReloadResource("zh_cn");
                    Modules.Settings.AppSettings.Lang = "zh_cn";
                    break;
                case 1:
                    i18n.ReloadResource("en_us");
                    Modules.Settings.AppSettings.Lang = "en_us";
                    break;
            }
            MainWindow.ContentFrame.GoBack();
        }
    }
}

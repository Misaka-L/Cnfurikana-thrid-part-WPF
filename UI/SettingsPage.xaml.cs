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

namespace Cnfurikana_thrid_part_WPF.UI
{
    /// <summary>
    /// SettingsPage.xaml 的交互逻辑
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void GoBackButton_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.ContentFrame.GoBack();
        }

        private void Selector_OnSelected(object sender, RoutedEventArgs e)
        {
            switch (((ListView)sender).SelectedIndex)
            {
                case 0:
                    MainWindow.ContentFrame.Navigate(new Settings.Language());
                    break;
            }
            ((ListView) sender).SelectedIndex = -1;
        }
    }
}

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

namespace Cnfurikana_thrid_part_WPF.UI
{
    /// <summary>
    /// Crush_age.xaml 的交互逻辑
    /// </summary>
    public partial class Crush_Page : Page
    {
        public Crush_Page(Exception exception)
        {
            InitializeComponent();
            ErrorMessage.Text = exception.Message;
            ErrorStackTrace.Text = exception.StackTrace;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.ContentFrame.Navigate(new MainPage());
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText("Message:\r\n" + ErrorMessage.Text + "\r\nStackTrace:\r\n" + ErrorStackTrace.Text);
        }
    }
}

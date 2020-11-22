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
using Cnfurikana_thrid_part_WPF.Modules;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

namespace Cnfurikana_thrid_part_WPF.UI
{
    /// <summary>
    /// MainPage.xaml 的交互逻辑
    /// </summary>
    public partial class MainPage : Page
    {
        private JObject initialTable;

        public MainPage()
        {
            InitializeComponent();
            Stopwatch sw =new Stopwatch();
            sw.Start();
            var uri = new Uri("pack://application:,,,/Cnfurikana-thrid-part-WPF;component/Assets/Initial.json");
            // 尝试读取声母片假名对照表文件
            StreamResourceInfo streamResourceInfo = Application.GetResourceStream(uri);
            byte[] initialByte = new byte[streamResourceInfo.Stream.Length];
            streamResourceInfo.Stream.Read(initialByte, 0, initialByte.Length);
            // 解析文件
            initialTable = JObject.Parse(Encoding.UTF8.GetString(initialByte));
            sw.Stop();
            Debug.WriteLine(sw.Elapsed.TotalMilliseconds.ToString());
        }

        private void PhoneticNotation_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Word[] words = new Word[InputText.Text.Length];
                for (int i = 0; i != InputText.Text.Length; i++)
                {
                    string kana = "";
                    string tone = "";
                    if (initialTable[PinYin.GetPinYin(InputText.Text[i])] != null)
                    {
                        foreach (string temp in initialTable[PinYin.GetPinYin(InputText.Text[i])].ToObject<string[]>())
                        {
                            kana = kana + temp + " ";
                            tone = PinYin.GetTone(InputText.Text[i]);
                        }
                    }

                    words[i] = new Word
                    {
                        Tone = tone,
                        Kana = kana,
                        SourceText = InputText.Text[i].ToString()
                    };
                }

                WordItemsControl.ItemsSource = words;
            }
            catch (Exception ex)
            {
                MainWindow.ContentFrame.Navigate(new Crush_Page(ex));
            }
        }

        private void SettingsButton_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.ContentFrame.Navigate(new SettingsPage());
        }

        private void ImportFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = i18n.SelectFileForImport;
            dialog.Multiselect = false;
            dialog.Filter = "TXT file|*.txt";
            dialog.DefaultExt = "txt";
            dialog.ShowDialog();
            var bytes = File.ReadAllBytes(dialog.FileName);
            InputText.Text = Encoding.UTF8.GetString(bytes);
        }
    }
}

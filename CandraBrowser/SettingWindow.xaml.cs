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

namespace CandraBrowser
{
    /// <summary>
    /// Interaction logic for SettingWindows.xaml
    /// </summary>
    public partial class SettingWindows : Window
    {
        public SettingWindows()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.homepageUrl = textSetting.Text;
            Properties.Settings.Default.Save();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textSetting.Text = Properties.Settings.Default.homepageUrl;
        }
    }
}

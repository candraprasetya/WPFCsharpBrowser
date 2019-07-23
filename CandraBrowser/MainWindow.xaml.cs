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

namespace CandraBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                myWeb.GoBack();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                myWeb.GoForward();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                myWeb.Source = new Uri("http://" + seacrhText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string homepageUrl = Properties.Settings.Default.homepageUrl;

            if (homepageUrl == null){
                textKosong.Visibility = Visibility.Visible;
            }else
                try
                {
                    myWeb.Source = new Uri(homepageUrl);
                    textKosong.Visibility = Visibility.Hidden;

                }
                catch
                {

                }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SettingWindows setWindow = new SettingWindows();
            setWindow.ShowDialog();
        }
    }
}

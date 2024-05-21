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

namespace WpfApp2
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

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            text.Text += "8";
        }

        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            text.Text = "" + text.Text.Substring(0, text.Text.Length - 1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            text.Text += "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text.Text += "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            text.Text += "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            text.Text += "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            text.Text += "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            text.Text += "7";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            text.Text += "0";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            text.Text += "9";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            text.Text = "";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {

        }
    }
}

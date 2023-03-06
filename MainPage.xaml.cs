using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace kalkulator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textbox1.Text);
            int b = Int32.Parse(textbox2.Text);
            int c = a + b;
            textblockans.Text=c.ToString();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textbox1.Text);
            int b = Int32.Parse(textbox2.Text);
            int c = a - b;
            textblockans.Text = c.ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textbox1.Text);
            int b = Int32.Parse(textbox2.Text);
            int c = a * b;
            textblockans.Text = c.ToString();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textbox1.Text);
            int b = Int32.Parse(textbox2.Text);
            int c = a / b;
            textblockans.Text = c.ToString();
        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textblockans_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            int decimalNumber = int.Parse(textblockans.Text);
            string bin = Convert.ToString(decimalNumber, 10);
            textblockans.Text = bin;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            int decimalNumber = int.Parse(textblockans.Text);
            string bin = Convert.ToString(decimalNumber, 2);
            textblockans.Text = bin;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            int decimalNumber = int.Parse(textblockans.Text);
            string oct = Convert.ToString(decimalNumber, 8);
            textblockans.Text = oct;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            int decimalNumber = int.Parse(textblockans.Text);
            string hex = Convert.ToString(decimalNumber, 16);
            textblockans.Text = hex;
        }
    }
}

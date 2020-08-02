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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DoStatement
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

        private void showStepsClick(object sender, RoutedEventArgs e)
        {
            int amount = int.Parse(number.Text);
            steps.Text = "";
            string current = "";

            calcOctal(amount);

            //do
            //{
            //    int nextDigit = amount % 8;
            //    amount = amount / 8;
            //    //int digitCode = 48 + nextDigit;
            //    int digitCode = '0' + nextDigit;
            //    //char type 0 (0 is the decimal number 48) (when the computer evaluates a char literal in a numeric context it replaces the char by its numeric literal) adding it to nextdigit and assigns it to the variable of digitcode.
            //    char digit = Convert.ToChar(digitCode);
            //    //calling method called ToChar in the Convert class
            //    current = digit + current;
            //    //adding the value of digit and current and assign the new value to current could also do
            //    steps.Text += current + "\n";
            //    //it updates the Text property of the steps class by the value of the text property with a new line.
            //}
            //while (amount != 0);
        }

        private void calcOctal(int amount)
        {
            int remainder = 0;
            int place = 1;
            int result = 0;
            while(amount > 0)
            {
                remainder = amount % 8;
                remainder *= place;
                place *= 10;
                result += remainder;
                steps.Text += result.ToString() + "\n";
                amount /= 8;
            }
        }
    }
}

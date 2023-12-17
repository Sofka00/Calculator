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

namespace Calculator
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
        private double _previosNumber;
        private string _operation = "";
        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            _previosNumber = Convert.ToDouble(TextBoxMain.Text);
            TextBoxMain.Text = "";
            _operation = "+";
        }
        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            if (_operation == "+")
            {
                result = Convert.ToDouble(TextBoxMain.Text) + _previosNumber;
            }
            else if (_operation == "-")
            {
                result = _previosNumber - Convert.ToDouble(TextBoxMain.Text);
            }
            else if (_operation == "*")
            {
                result = Convert.ToDouble(TextBoxMain.Text) * _previosNumber;
            }
            else if (_operation == "/")
            {
                if (TextBoxMain.Text != "0")
                {
                    result = _previosNumber / Convert.ToDouble(TextBoxMain.Text);

                }
                else
                {
                    TextBoxMain.Text = "ошибка!";
                    return;
                }
            }

            TextBoxMain.Text = $"{result}";

        }
        private void ButtonNumber_Click(object sender, RoutedEventArgs e)
        {
            TextBoxMain.Text += ((Button)sender).Content;
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            _previosNumber = Convert.ToDouble(TextBoxMain.Text);
            TextBoxMain.Text = "";
            _operation = "-";

        }

        private void ButtonMultiplication_Click(object sender, RoutedEventArgs e)
        {
            _previosNumber = Convert.ToDouble(TextBoxMain.Text);
            TextBoxMain.Text = "";
            _operation = "*";

        }

        private void ButtonDivision_Click(object sender, RoutedEventArgs e)
        {
            _previosNumber = Convert.ToDouble(TextBoxMain.Text);
            TextBoxMain.Text = "";
            _operation = "/";
        }

        private void ButtonPersent_Click(object sender, RoutedEventArgs e)
        {
            _previosNumber = Convert.ToDouble(TextBoxMain.Text);
            _operation = "sqrt";
            TextBoxMain.Text = $"{Math.Sqrt(_previosNumber)}";
            return;
        }

        private void ButtonNegative_Click(object sender, RoutedEventArgs e)
        {
            _previosNumber= Convert.ToDouble(TextBoxMain.Text);
            TextBoxMain.Text = $"{_previosNumber * (-1)}";
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            TextBoxMain.Text = "";
        }

        private void ButtonVirgul_Click(object sender, RoutedEventArgs e)
        {
            TextBoxMain.Text += ",";
        }
    }
}

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

namespace WpfApp1
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

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Celcius.Text, out double celsius))
            {
                double FahrenheitT = CelsiusToFahrenheit(celsius);
                Fahrenheit.Text = FahrenheitT.ToString();

            }
            else if (double.TryParse(Fahrenheit.Text, out double fahr))
            {
                double CelsiusT = FahrenheitToCelsius(fahr);
                Celcius.Text = CelsiusT.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void Exterminate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Empty_Click(object sender, RoutedEventArgs e)
        {

        }

        private double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        private double FahrenheitToCelsius(double Fahrenheit)
        {
            return (Fahrenheit - 32) * 5 / 9;
        }
    }
}

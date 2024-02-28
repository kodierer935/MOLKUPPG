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

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            bool celsiusBool = double.TryParse(Celcius.Text, out double celsius);
            bool fahrenheitBool = double.TryParse(Fahrenheit.Text, out double fahrenheit);

            if (celsiusBool && !fahrenheitBool)
            {

                double FahrenheitT = CelsiusToFahrenheit(celsius);
                Fahrenheit.Text = FahrenheitT.ToString();
            }
            else if (!celsiusBool && fahrenheitBool)
            {
                double CelsiusT = FahrenheitToCelsius(fahrenheit);
                Celcius.Text = CelsiusT.ToString();
            }
            else
            {
                Celcius.Text = "0";
                Fahrenheit.Text = "32";
                if (!celsiusBool || !fahrenheitBool)
                {
                    MessageBox.Show("Ange ett giltigt nummer!");
                }
            }

        }

        private void Exterminate_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Empty_Click(object sender, RoutedEventArgs e)
        {
            Celcius.Text = "";
            Fahrenheit.Text = "";
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

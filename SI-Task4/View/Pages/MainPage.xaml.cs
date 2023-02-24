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

namespace SI_Task4.View.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BTN4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TBx.Text);
                double a = 0.2, b = 0.5, z = Math.Exp(a * x);
                double A = 0.15, B = 0.2, Z = Math.Exp(2 * A * x);
                double А = 0.15, В = 0.2, З = Math.Exp(2 * A * x);
                if (x < -Math.ILogB(a))
                {
                    MessageBox.Show($"1)y = {a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x)}\n" +
                        $"2)y = {A * Math.Pow(Math.Sin(x), 2) + B * Math.Cos(Z * x)}\n" +
                        $"3)y = {А * Math.Pow(Math.Sin(x), 2) + В * Math.Cos(З * x)}", " задание 4",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (-Math.ILogB(a) <= x && x <= b)
                {
                    MessageBox.Show($"1)y = {Math.Pow(a, b) - Math.Pow(Math.Cos(a + z * x), 3)}\n" +
                        $"2)y = {Math.Pow(A, B) - Math.Pow(Math.Cos(A + Z * x), 3)}\n" +
                        $"3)y = {Math.Pow(А, В) - Math.Pow(Math.Cos(В + З * x), 3)}", " задание 4",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (x > b)
                {
                    MessageBox.Show($"1)y = {Math.Sqrt(2.5 * Math.Pow(a, 3) + Math.Pow(b - z * Math.Pow(x, 2), 6))}\n" +
                        $"2)y = {Math.Sqrt(2.5 * Math.Pow(A, 3) + Math.Pow(B - Z * Math.Pow(x, 2), 6))}\n" +
                        $"3)y = {Math.Sqrt(2.5 * Math.Pow(А, 3) + Math.Pow(В - З * Math.Pow(x, 2), 6))}", " задание 4",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 4",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }

        private void BTN5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TBx.Text);
                double a = 4.2, b = 5.3, c = 1.5;
                double A = -0.35, B = 1.8, C = -1.8;
                double А = 2.8, В = 5, С = 2;
                if (Math.Exp(a + b) > Math.Exp(x))
                {
                    MessageBox.Show($"1)y = {Math.Sin(Math.Exp(a + b)) + Math.Pow(x, 2)}\n" +
                        $"2)y = {Math.Sin(Math.Exp(A + B)) + Math.Pow(x, 2)}\n" +
                        $"3)y = {Math.Sin(Math.Exp(А + В)) + Math.Pow(x, 2)}", " задание 5",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Exp(a + b) == Math.Exp(x))
                {
                    MessageBox.Show($"1)y = {Math.Atan(a * b * c) + Math.Pow(Math.Sqrt(x), 3)}\n" +
                        $"2)y = {Math.Atan(A * B * C) + Math.Pow(Math.Sqrt(x), 3)}\n" +
                        $"3)y = {Math.Atan(А * В * С) + Math.Pow(Math.Sqrt(x), 3)}", " задание 5",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Exp(a + b) < Math.Exp(x))
                {
                    MessageBox.Show($"1)y = {Math.Cos(Math.Sqrt(Math.Abs(x + a * b * c)))}\n" +
                        $"2)y = {Math.Cos(Math.Sqrt(Math.Abs(x + A * B * C)))}\n" +
                        $"3)y = {Math.Cos(Math.Sqrt(Math.Abs(x + А * В * С)))}", " задание 5",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 5",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }

        private void BTN6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TBx.Text);
                double a = -5, b = 5.3, z = Math.ILogB(b * Math.Pow(x, 3));
                double A = 3, B = 5, Z = Math.ILogB(b * x);
                double А = -10, В = 3, З = Math.ILogB(b * Math.Pow(x, 2));
                if (x < a)
                {
                    MessageBox.Show($"1)y = {2.8 * Math.Pow(Math.Sin(a * x), 2) - b * Math.Pow(x, 3) * z}\n" +
                        $"2)y = {2.8 * Math.Pow(Math.Sin(A * x), 2) - B * Math.Pow(x, 3) * Z}\n" +
                        $"3)y = {2.8 * Math.Pow(Math.Sin(А * x), 2) - В * Math.Pow(x, 3) * З}", " задание 6",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (a <= x && x <= Math.Pow(b, 2))
                {
                    MessageBox.Show($"1)y = {z * Math.Cos(Math.Pow(a * x + b, 2)) + Math.ILogB(z)}\n" +
                        $"2)y = {Z * Math.Cos(Math.Pow(A * x + B, 2)) + Math.ILogB(Z)}\n" +
                        $"3)y = {z * Math.Cos(Math.Pow(А * x + В, 2)) + Math.ILogB(З)}", " задание 6",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (x > Math.Pow(b, 2))
                {
                    MessageBox.Show($"1)y = {Math.Exp(2.5 * a * x) + z * a * b * x}\n" +
                        $"2)y = {Math.Exp(2.5 * A * x) + Z * A * B * x}\n" +
                        $"3)y = {Math.Exp(2.5 * А * x) + З * А * В * x}", " задание 6",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 6",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }

        private void BTN7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseBTN_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

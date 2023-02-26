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
            try
            {
                double x = Convert.ToDouble(TBx.Text);
                double a = 3.2, b = -0.7, c = 2.2;
                double A = 10.5, B = -2.5, C = 5.6;
                double А = 5.4, В = 3, С = 2.6;
                if (Math.Abs(1 - Math.Pow(x, 2)) == a + c)
                {
                    MessageBox.Show($"1)y = {x * Math.Exp(a) + Math.Exp(Math.Abs(b * c))}\n" +
                        $"2)y = {x * Math.Exp(A) + Math.Exp(Math.Abs(B * C))}\n" +
                        $"3)y = {x * Math.Exp(А) + Math.Exp(Math.Abs(В * С))}", " задание 7",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Abs(1 - Math.Pow(x, 2)) > a + c)
                {
                    MessageBox.Show($"1)y = {Math.Pow(Math.Sin(a * x), 2) + Math.Cos(b * c)}\n" +
                        $"2)y = {Math.Pow(Math.Sin(A * x), 2) + Math.Cos(B * C)}\n" +
                        $"3)y = {Math.Pow(Math.Sin(А * x), 2) + Math.Cos(В * С)}", " задание 7",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Abs(1 - Math.Pow(x, 2)) < a + c)
                {
                    MessageBox.Show($"1)y = {Math.Sqrt(a * Math.Pow(b, 4) + Math.Pow(Math.Sqrt(c * Math.Pow(x, 2)), 5))}\n" +
                        $"2)y = {Math.Cos(Math.Sqrt(Math.Abs(x + A * B * C)))}\n" +
                        $"3)y = {Math.Cos(Math.Sqrt(Math.Abs(x + А * В * С)))}", " задание 7",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 7",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }

        private void BTN8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TBx.Text);
                double k = 3.1, m = 5.15, n = -1.15;
                double K = 0.78, M = -2.4, N = 4.36;
                double К = 1.1, М = 0.8, Н = 0.41;
                if (Math.Pow(x, 2) > m + n)
                {
                    MessageBox.Show($"1)y = {Math.ILogB(Math.Abs(m * x + n))}\n" +
                        $"2)y = {Math.ILogB(Math.Abs(M * x + N))}\n" +
                        $"3)y = {Math.ILogB(Math.Abs(М * x + Н))}", " задание 8",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Pow(x, 2) == m + n)
                {
                    MessageBox.Show($"1)y = {Math.Exp(Math.Cos(Math.Abs(m * x - n)))}\n" +
                        $"2)y = {Math.Exp(Math.Cos(Math.Abs(M * x - N)))}\n" +
                        $"3)y = {Math.Exp(Math.Cos(Math.Abs(М * x - Н)))}", " задание 8",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Pow(x, 2) < m + n)
                {
                    MessageBox.Show($"1)y = {Math.Pow(Math.Sqrt(Math.Pow(k, 2) + Math.Pow(Math.Cos(x), 2)), 3)}\n" +
                        $"2)y = {Math.Pow(Math.Sqrt(Math.Pow(K, 2) + Math.Pow(Math.Cos(x), 2)), 3)}\n" +
                        $"3)y = {Math.Pow(Math.Sqrt(Math.Pow(k, 2) + Math.Pow(Math.Cos(x), 2)), 3)}", " задание 8",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 8",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }

        private void BTN9_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TBx.Text);
                double a = 1.2, b = 7.2, z = Math.Exp(x);
                double A = -1.5, B = 3.2, Z = Math.Exp(2 * x);
                double А = 1.7, В = 5.5, З = Math.Exp(3);
                if (x < Math.Pow(a, 3))
                {
                    MessageBox.Show($"1)y = {a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x + a)}\n" +
                        $"2)y = {A * Math.Pow(Math.Sin(x), 2) + B * Math.Cos(Z * x + A)}\n" +
                        $"3)y = {А * Math.Pow(Math.Sin(x), 2) + В * Math.Cos(З * x + А)}", " задание 9",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Pow(a, 3) <= x && x <= b)
                {
                    MessageBox.Show($"1)y = {Math.Pow(a + b * x, 2) - Math.Sin(a + z * x)}\n" +
                        $"2)y = {Math.Pow(A + B * x, 2) - Math.Sin(A + Z * x)}\n" +
                        $"3)y = {Math.Pow(А + В * x, 2) - Math.Sin(А + З * x)}", " задание 9",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (x > b)
                {
                    MessageBox.Show($"1)y = {Math.Exp(2.5 * a * x) + z * a * b * x}\n" +
                        $"2)y = {Math.Exp(2.5 * A * x) + Z * A * B * x}\n" +
                        $"3)y = {Math.Exp(2.5 * А * x) + З * А * В * x}", " задание 9",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 9",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }

        private void BTN10_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TBx.Text);
                double a = 0.1, b = 9.8, c = 11.12;
                double A = 10, B = 10.05, C = 6.2;
                double А = 100, В = 3.03, С = 7.12;
                if (Math.Log10(a) < x)
                {
                    MessageBox.Show($"1)y = {Math.Pow(Math.Sqrt(Math.Pow(b, 2) + Math.Sqrt(Math.Abs(x + c))), 3)}\n" +
                        $"2)y = {Math.Pow(Math.Sqrt(Math.Pow(B, 2) + Math.Sqrt(Math.Abs(x + C))), 3)}\n" +
                        $"3)y = {Math.Pow(Math.Sqrt(Math.Pow(В, 2) + Math.Sqrt(Math.Abs(x + С))), 3)}", " задание 10",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Log10(a) == x)
                {
                    MessageBox.Show($"1)y = {Math.Cos(x - b - c)}\n" +
                        $"2)y = {Math.Cos(x - B - C)}\n" +
                        $"3)y = {Math.Cos(x - В - С)}", " задание 10",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Log10(a) > x)
                {
                    MessageBox.Show($"1)y = {Math.Sin(x + a - b)}\n" +
                        $"2)y = {Math.Sin(x + A - B)}\n" +
                        $"3)y = {Math.Sin(x + А - В)}", " задание 10",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 10",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }

        private void CloseBTN_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

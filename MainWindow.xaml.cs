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



    public partial class MainWindow : Window
    {
        string num1 = string.Empty;
        string num2 = string.Empty;
        string final = string.Empty;
        string Operation = "";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Num1_Click(object sender, RoutedEventArgs e)
        {
            Total.Content = CalcUtils.ProcessNumPress(Operation, ref num1, ref num2, "1");
        }
        private void Num0_Click(object sender, RoutedEventArgs e)
        {
            Total.Content = CalcUtils.ProcessNumPress(Operation, ref num1, ref num2, "0");
        }

        private void Num2_Click(object sender, RoutedEventArgs e)
        {
            Total.Content = CalcUtils.ProcessNumPress(Operation, ref num1, ref num2, "2");
        }

        private void Num3_Click(object sender, RoutedEventArgs e)
        {
            Total.Content = CalcUtils.ProcessNumPress(Operation, ref num1, ref num2, "3");
        }

        private void Num4_Click(object sender, RoutedEventArgs e)
        {
            Total.Content = CalcUtils.ProcessNumPress(Operation, ref num1, ref num2, "4");
        }

        private void Num5_Click(object sender, RoutedEventArgs e)
        {
            Total.Content = CalcUtils.ProcessNumPress(Operation, ref num1, ref num2, "5");
        }

        private void Num6_Click(object sender, RoutedEventArgs e)
        {
            Total.Content = CalcUtils.ProcessNumPress(Operation, ref num1, ref num2, "6");
        }

        private void Num7_Click(object sender, RoutedEventArgs e)
        {
            Total.Content = CalcUtils.ProcessNumPress(Operation, ref num1, ref num2, "7");
        }

        private void Num8_Click(object sender, RoutedEventArgs e)
        {
            Total.Content = CalcUtils.ProcessNumPress(Operation, ref num1, ref num2, "8");
        }

        private void Num9_Click(object sender, RoutedEventArgs e)
        {
            Total.Content = CalcUtils.ProcessNumPress(Operation, ref num1, ref num2, "9");
        }

        private void Decimal_Click(object sender, RoutedEventArgs e)
        { 
            string Num0 = string.Empty;
            if (Operation == "")
            {
                num1 = num1 + "." + Num0;
            }
            else
            {
                num2 = num2 + "." + Num0;
            }
        }
        
        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            Operation = "-";
            Total.Content = string.Empty;
        }
        
        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            Operation = "+";
            Total.Content = string.Empty;
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            Operation = "*";
            Total.Content = string.Empty;
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            Operation = "/";
            Total.Content = string.Empty;
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "+")
            {
                final = (Convert.ToDecimal(num1) + Convert.ToDecimal(num2)).ToString();
                Total.Content = final;
                num1 = (Total.Content).ToString();
            }
            else if (Operation == "-")
            {
                final = (Convert.ToDecimal(num1) - Convert.ToDecimal(num2)).ToString();
                Total.Content = final;
                num1 = (Total.Content).ToString();
            }
            else if (Operation == "*")
            {
                final = (Convert.ToDecimal(num1) * Convert.ToDecimal(num2)).ToString();
                Total.Content = final;
                num1 = (Total.Content).ToString();
            }
            else if (Operation == "/")
            {
                final = (Convert.ToDecimal(num1) / Convert.ToDecimal(num2)).ToString();
                Total.Content = final;
                num1 = (Total.Content).ToString();
            }
           else if (Operation == "^")
            {
                final = Math.Pow(Convert.ToDouble(num1), Convert.ToDouble(num2)).ToString();
                Total.Content = final;
                num1 = (Total.Content).ToString();
            }
            else if (Operation == "mod")
            {
                Total.Content = (Convert.ToInt32(num1) % Convert.ToInt32(num2));
                num1 = (Total.Content).ToString();
            }
            Operation = string.Empty;
            num2 = string.Empty;


        }

        private void Posneg_Click(object sender, RoutedEventArgs e)
        {
            Operation = "+/-";
            if (Operation == "+/-")
            {
                num1 = ((Convert.ToDecimal(num1)) * -1).ToString();
                Total.Content = num1;
            }
            else
            {
                num2 = ((Convert.ToDecimal(num2)) * -1).ToString();
                Total.Content = num2.ToString();

            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            num1 = string.Empty;
            num2 = string.Empty;
            Operation = "";
            Total.Content = string.Empty;
        }

        private void Percentage_Click(object sender, RoutedEventArgs e)
        {
            Operation = "%";
            if (Operation == "%")
            {
                num1 = ((Convert.ToDecimal(num1)) / 100).ToString();
                Total.Content = num1;
            }
            else
            {
                num2 = ((Convert.ToDecimal(num2)) / 100).ToString();
                Total.Content = num2;
            }
        
           
        }

        private void Exponent_Click(object sender, RoutedEventArgs e)
        {
            Operation = "^";
            Total.Content = string.Empty;
        }

        private void Mod_Click(object sender, RoutedEventArgs e)
        {
            Operation = "mod";
            Total.Content = string.Empty;
        }

        private void Square_Click(object sender, RoutedEventArgs e)
        {
            Total.Content = Convert.ToDecimal(num1) * Convert.ToDecimal(num1);
            num1 = (Total.Content).ToString();
        }

        private void Sqrrt_Click(object sender, RoutedEventArgs e)
        {
            Total.Content = Math.Sqrt(Convert.ToDouble(num1));
            num1 = (Total.Content).ToString();
        }

        private void Pi_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                num1 = Convert.ToString(Math.PI);
                Total.Content = num1;
            }
            else
            {
                num2 = Convert.ToString(Math.PI);
                Total.Content = num2;
            }
        }
    }

}

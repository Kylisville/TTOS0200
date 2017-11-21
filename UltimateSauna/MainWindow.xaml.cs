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

namespace UltimateSauna
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
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            InfoBox.Text = "";
            string buttonString = (((Button)sender).Content).ToString();
            bool isitNumber = double.TryParse(buttonString, out double number);
            if (isitNumber || buttonString == ".")
            {
                Input.Text += buttonString;
            }
            else if (buttonString == "<-" && Input.Text.Length > 0)
            {
                Input.Text = Input.Text.Substring(0, Input.Text.Length - 1);
            }
            else if (buttonString == "ok")
            {
                if ((bool)RadioHumi.IsChecked || (bool)RadioTemp.IsChecked)
                {
                    double input;
                    bool isitDouble = double.TryParse(Input.Text, out input);
                    if (!isitDouble)
                    {
                        InfoBox.Text = "Invalid input";
                    }
                    if ((bool) RadioHumi.IsChecked)
                    {
                        if (input > 100)
                        {
                            InfoBox.Text = "You can't go above maximum (100)";
                            Input.Text = String.Empty;
                        }
                        else
                        {
                           
                            Humi.Text = input.ToString("N2");
                            Input.Text = String.Empty;
                        }
                    }
                    else if ((bool)RadioTemp.IsChecked)
                    {
                        if (input > 120)
                        {
                            InfoBox.Text = "You can't go above maximum(120)";
                            Input.Text = String.Empty;
                        }
                        else
                        {
                            Temp.Text = input.ToString("N2");
                            Input.Text = String.Empty;
                        }
                    }
                }
                else
                {
                    InfoBox.Text = "Invalid input";
                }
            }
        }
    }
}

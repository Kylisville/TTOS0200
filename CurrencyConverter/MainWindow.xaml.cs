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

namespace CurrencyConverter
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
            //tarkastetaan onko syöttö luku
            bool check = double.TryParse(Amount.Text, out double d);
            if (!check)
                {
                ErrorBox.Text = "Invalid input. Please enter numbers only.";
                return;
                }
            ErrorBox.Text = String.Empty;
       
            if (Combo1.SelectedIndex == 0 && Combo2.SelectedIndex == 1)
                {
                
                //Muunnetaan eurot dollareiksi
                double t = d / 0.8997;
                ConvertedAmount.Text = "Converted Amount: " + t.ToString("0.00") + "\t $";
            }
            else if (Combo1.SelectedIndex == 1 && Combo2.SelectedIndex == 0)
            {
                //muunnetaan dollarit euroiksi
                double t = d * 0.8997;
                ConvertedAmount.Text = "Converted Amount: " + t.ToString("0.00") + "\t €";
            }
            else
            {
                ConvertedAmount.Text = "You can't convert same currency!";
            }
        }
    }
}

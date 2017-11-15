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
            Combo1.SelectionChanged += new SelectionChangedEventHandler(Combo1_SelectedIndexChanged);
            Combo2.SelectionChanged += new SelectionChangedEventHandler(Combo2_SelectedIndexChanged);
        }
        
        
       
           


        private void Amount_TextChanged(object sender, TextChangedEventArgs e)
        {
            Conversion();
            
        }

        
    
        private void Conversion()
        {
            try
            {
                //tarkastetaan onko syöttö luku
                bool check = double.TryParse(Amount.Text, out double d);
                if (!check)
                {
                    ErrorBox.Text = "Invalid input. Please enter numbers only.";
                    ConvertedAmount.Text = string.Empty;
                    return;
                }


                if (Combo1.SelectedIndex == 0 && Combo2.SelectedIndex == 1)
                {
                    ErrorBox.Text = string.Empty;
                    ConvertedAmount.Text = (d / 0.8997).ToString("0.00 $");

                }
                else if (Combo1.SelectedIndex == 1 && Combo2.SelectedIndex == 0)
                {
                    ErrorBox.Text = string.Empty;
                    ConvertedAmount.Text = (d * 0.8997).ToString("0.00 €");

                }
                else if (Combo1.SelectedIndex == Combo2.SelectedIndex)
                {
                    ErrorBox.Text = string.Empty;
                    ConvertedAmount.Text = d.ToString("0.00");

                }
            }
            catch (Exception)
            {
                ErrorBox.Text = "Invalid input. Please enter numbers only.";
            }
        }

        private void Combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
          // Conversion();


        }

        private void Combo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Conversion();
        }


    }
}

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
        private void btnNappi_Click(object sender, RoutedEventArgs e)
        {
            int korkeus;
            int leveys;
            int karmi;
            bool leveysTarkistus = int.TryParse(txtLeveys.Text, out leveys);
            if (!leveysTarkistus)
            {
                txtLeveys.Text = "Invalid input";
            }
            bool korkeusTarkistus = int.TryParse(txtKorkeus.Text, out korkeus);
            if (!korkeusTarkistus)
            {
                txtKorkeus.Text = "Invalid input";
            }
            bool karmiTarkistus = int.TryParse(txtKarmi.Text, out karmi);
            if (!karmiTarkistus)
            {
                txtKarmi.Text = "Invalid input";
            }
            if (leveysTarkistus && korkeusTarkistus && karmiTarkistus)
            {
                txtIkkunanPintaAla.Text = ((leveys * korkeus) / 10).ToString() + " cm^2";
              
                txtLasinPintaAla.Text = (((leveys - 2 * (karmi)) * (korkeus - 2 * (karmi))) / 10).ToString() + " cm^2";
               
                txtKarminPiiri.Text = (((2 * leveys) + (2 * korkeus)) / 10).ToString() + " cm";
            }
        }
    }
}


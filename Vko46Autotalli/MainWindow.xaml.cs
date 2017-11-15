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

namespace Vko46Autotalli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Auto> autot;
        private const string polku = @"D:\\H9109\\";
        public MainWindow()
        {
            //tänne koodi joka suoritetaan ikkunana avauksen luonnissa.
            InitializeComponent();
            NaytaKuva("autotalli.png");
        }

        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {
            //pyydetään BL-kerrokselta autot, ja näytetään käyttäjälle
            autot = Autotalli.HaeAutot();
            imgAutot.ItemsSource = autot;
        }
        private void NaytaKuva(string url)
        {
            try
            {

                if (string.IsNullOrEmpty(url))
                {
                    url = "puuttuu.png";
                }
                url = polku + url;
                //kuvan näyttö
                BitmapImage pic = new BitmapImage();
                pic.BeginInit();
                pic.UriSource = new Uri(url);
                pic.EndInit();
                imgAuto.Stretch = Stretch.Fill;
                imgAuto.Source = pic;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void imgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //huom, olemme itse populoineet DataGridin Auto-olioilla, joten kukin  DatGridin jäsen/alkio on itseasiassa auto-olio.
            object obj = imgAutot.SelectedItem;
            if (obj != null)
            {
                Auto valittu = (Auto)obj;
                NaytaKuva(valittu.URL);
            }
        }

        private void btnHaeAudit_Click(object sender, RoutedEventArgs e)
        {
            //näkyviin pelkästään Audi-merkkiset autot
            var result = autot.Where(m => m.Merkki.Contains("Audi"));
            imgAutot.ItemsSource = result;
        }
    }
}

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

namespace Team
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private List<Players> pelaajat;
        public MainWindow()
        {
            InitializeComponent();
            Title = "Saipa 2017-2018";
        }

        private void HaePelaajat_Click(object sender, RoutedEventArgs e)
        {
            pelaajat = Joukkue.HaePelaajat();
            PlayerList.ItemsSource = pelaajat;
        }
    }
}

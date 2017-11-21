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
using WPFLottery;

namespace WPFLottery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Lotto: arvotaan 7 numeroa väliltä 1-40
    /// Viking Lotto: arvotaan 6 numeroa 1-48
    ///Eurojackpot: arvotaan 5 numeroa 1-50 ja ja 2 tähtinumeroa väliltä 1-10
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeGames();
        }
        private void InitializeGames()
        {
            Game.Items.Add(new Lotto());
            Game.Items.Add(new Vikinglotto());
            Game.Items.Add(new Eurojackpot());
        }
        private void DrawBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Game.SelectedIndex >= 0)
                {
                    Lottery game = (Lottery)Game.SelectedItem;
                    Results.Text = "";
                    int number = int.Parse(DrawAmt.Text);
                    for (int x = 0; x < number; x++)
                    {
                        game.Generate();
                        Results.Text += String.Format("Rivi {0}: ", x + 1) + game.LineToString() + "\n";
                        game.Numbers.Clear();
                    }
                }
            }
            catch (Exception)
            {
                Results.Text += "Please enter the amount of lines";
            }
        }
        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            Results.Text = String.Empty;
            DrawAmt.Text = String.Empty;
            Game.SelectedIndex = -1;
        }
    }
}

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

namespace Vko45
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
        public TextAlignment Textalignment { get; set; }
        private int btn1 = 0;
        private int btn2 = 0;
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            btn1++;
            TxtBox1.Text = btn1.ToString();
            
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            btn2++;
            TxtBox2.Text = btn2.ToString();
        }
        
    }
}

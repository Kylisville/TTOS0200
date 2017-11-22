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

namespace ShoppingList
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List.Clear();
                foreach (object o in STpanel.Children)
                {
                    if (o is CheckBox)
                    {
                        CheckBox cb = (CheckBox)o;
                        if ((bool)cb.IsChecked)
                        {
                            List.Text += cb.Content + " ";
                           
                        }
                    }
                }
            }
            catch(Exception)
            {
                // do something
            }
        }
    }
}

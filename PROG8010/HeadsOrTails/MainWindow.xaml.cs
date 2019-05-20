//my group members are:
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            heads_pic.Visibility = Visibility.Hidden;
            tails_pic.Visibility = Visibility.Hidden;
        }

        private void Heads_Click(object sender, RoutedEventArgs e)
        {
            heads_pic.Visibility = Visibility.Visible;
            tails_pic.Visibility = Visibility.Hidden;
        }

        private void Tails_Click(object sender, RoutedEventArgs e)
        {
            heads_pic.Visibility = Visibility.Hidden;
            tails_pic.Visibility = Visibility.Visible;
        }

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random(); 
            int x = random.Next (1, 3);

            if (x == 1)
            {
                heads_pic.Visibility = Visibility.Hidden;
                tails_pic.Visibility = Visibility.Visible;
            }

            else if (x == 2)
            {
                heads_pic.Visibility = Visibility.Visible;
                tails_pic.Visibility = Visibility.Hidden;
            }

            else
            {
                heads_pic.Visibility = Visibility.Hidden;
                tails_pic.Visibility = Visibility.Hidden;
            }


        }
    }
}
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

namespace Week4F2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;

            vm.CurrentIndex = 2;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LbItems.SelectedItem != null)
            {
                string tag = (string)((ListBoxItem)LbItems.SelectedItem).Tag;

                string word = CbEnglish.IsChecked == true ? "One" : "Un";

                switch (tag)
                {
                    case "0":
                        LblOut.Content = $"{word} Million Pounds";
                        break;
                    case "1":
                        LblOut.Content = $"{word} Billion Pounds";
                        break;
                    case "2":
                        LblOut.Content = $"{word} Trillion Pounds";
                        break;
                    default:
                        LblOut.Content = $"{word} Pound";
                        break;
                }
            }
        }

        private void CbEnglish_Checked(object sender, RoutedEventArgs e)
        {
            ListBox_SelectionChanged(null, null);
        }
    }
}

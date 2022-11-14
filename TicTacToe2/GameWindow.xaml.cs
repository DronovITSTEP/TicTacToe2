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
using System.Windows.Shapes;

namespace TicTacToe2
{
    /// <summary>
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (One.Content == null)
            {
                One.Content = Resources["Image.First"];
                One.IsEnabled = false;
            }
        }
        private void One_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            One.Background = Brushes.Transparent;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (Two.Content == null)
            {
                Two.Content = Resources["Image.First"];
                Two.IsEnabled = false;
            }
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (Three.Content == null)
            {
                Three.Content = Resources["Image.First"];
                Three.IsEnabled = false;

            }
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}

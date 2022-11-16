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
                One.IsEnabled = false;
            }          
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (Two.IsEnabled == true)
            {
                Two.IsEnabled = false;
                Two.Background = Brushes.Red;
            }
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (Three.Content == null)
            {
                Three.IsEnabled = false;
            }
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (Four.Content == null)
            {
                Four.IsEnabled = false;
            }
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (Five.Content == null)
            {
                Five.IsEnabled = false;
            }
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (Six.Content == null)
            {
                Six.IsEnabled = false;
            }
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (Seven.Content == null)
            {
                Seven.IsEnabled = false;
            }
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (Eight.Content == null)
            {
                Eight.IsEnabled = false;
            }
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (Nine.Content == null)
            {
                Nine.IsEnabled = false;
            }
        }

    }
}

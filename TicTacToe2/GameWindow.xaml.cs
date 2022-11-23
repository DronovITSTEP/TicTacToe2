using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        List<string> lists= new List<string>
        {
            "Image/krest.png",
            "Image/nol.png"
        };
        int r;
    public GameWindow()
        {
            InitializeComponent();
            r = new Random().Next(2);

        }

        private Image SetImage()
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri(lists[r], UriKind.Relative));
            return img;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button= (Button)sender;
            button.IsEnabled = false;
            button.Content = SetImage();
        }
    }
}

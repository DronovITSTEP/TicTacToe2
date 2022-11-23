using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace TicTacToe2
{
    internal class LogicGame
    {
        Image image;
        int rand;
        Random random;
        List<Button> buttons;
        static List<int> lists = new List<int> {3,3,3,3,3,3,3,3,3 };
        public LogicGame(List<string> l, int r, List<Button> buttons, int index) {
            random = new Random();
            lists[index] = 0;
            if (r == 1)
                rand = 0;
            else
                rand = 1;
            this.buttons = buttons;

            image = new Image();
            image.Source = new BitmapImage(new Uri(l[rand], UriKind.Relative));

        }

        public bool Move()
        {
            if (!Win())
            {
                int i;
                while (true)
                {
                    i = random.Next(0, 9);
                    if (buttons[i].IsEnabled == true)
                    {
                        buttons[i].IsEnabled = false;
                        buttons[i].Content = image;
                        lists[i] = 1;
                        if (Win()) return true;
                        break;
                    }
                }
            }
            else return true;
            return false;
        }

        public bool Win() 
        {
            for (int i = 0; i <= 6; i += 3)
            {
                if (lists[i] == lists[i + 1] && lists[i] == lists[i + 2] && lists[i] != 3)
                {
                    MessageBox.Show("winner!");
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (lists[i] == lists[i + 3] && lists[i] == lists[i + 6] && lists[i] != 3)
                {
                    MessageBox.Show("winner!");
                    return true;
                }
            }
            if (lists[0] == lists[4] && lists[0] == lists[8] && lists[0] != 3)
            {
                MessageBox.Show("winner!");
                return true;
            }
            if (lists[2] == lists[4] && lists[2] == lists[6] && lists[2] != 3)
            {
                MessageBox.Show("winner!");
                return true;
            }
            return false;
        }
    }
}

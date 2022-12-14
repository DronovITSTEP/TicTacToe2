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

        public int Move()
        {
            int w = Win();
            if (w == -1)
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
                        if ((w = Win()) != -1) return w;
                        break;
                    }
                }
            }
            else return w;
            return -1;
        }

        private int Win() 
        {
            for (int i = 0; i <= 6; i += 3)
            {
                if (lists[i] == lists[i + 1] && lists[i] == lists[i + 2] && lists[i] != 3)
                {                   
                    RestartList();
                    return (i == 0)?3:((i == 3)?4:5);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (lists[i] == lists[i + 3] && lists[i] == lists[i + 6] && lists[i] != 3)
                {
                    RestartList();
                    return i;
                }
            }
            if (lists[0] == lists[4] && lists[0] == lists[8] && lists[0] != 3)
            {
                RestartList();
                return 7;
            }
            if (lists[2] == lists[4] && lists[2] == lists[6] && lists[2] != 3)
            {
                RestartList();
                return 6;
            }
            return -1;
        }

        private void RestartList()
        {
            for (int i = 0; i < 9; i++)
            {
                lists[i] = 3;
            }
        }
    }
}

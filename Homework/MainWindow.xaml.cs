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

namespace XOGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Player = 0, Winner = 0;
        int[] CheckRule = new int[9];

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)e.Source;

            Player++;
            if (Player % 2 == 0)
            {
                CheckRule[1] = -1;
                btn.Content = "X";
            }
            else
            {
                CheckRule[1] = 1;
                btn.Content = "O";
            }
            btn.IsEnabled = false;
            CheckWinner();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)e.Source;

            Player++;
            if (Player % 2 == 0)
            {
                CheckRule[2] = -1;
                btn.Content = "X";
            }
            else
            {
                CheckRule[2] = 1;
                btn.Content = "O";
            }
            btn.IsEnabled = false;
            CheckWinner();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)e.Source;

            Player++;
            if (Player % 2 == 0)
            {
                CheckRule[3] = -1;
                btn.Content = "X";
            }
            else
            {
                CheckRule[3] = 1;
                btn.Content = "O";
            }
            btn.IsEnabled = false;
            CheckWinner();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)e.Source;

            Player++;
            if (Player % 2 == 0)
            {
                CheckRule[4] = -1;
                btn.Content = "X";
            }
            else
            {
                CheckRule[4] = 1;
                btn.Content = "O";
            }
            btn.IsEnabled = false;
            CheckWinner();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)e.Source;

            Player++;
            if (Player % 2 == 0)
            {
                CheckRule[5] = -1;
                btn.Content = "X";
            }
            else
            {
                CheckRule[5] = 1;
                btn.Content = "O";
            }
            btn.IsEnabled = false;
            CheckWinner();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)e.Source;

            Player++;
            if (Player % 2 == 0)
            {
                CheckRule[6] = -1;
                btn.Content = "X";
            }
            else
            {
                CheckRule[6] = 1;
                btn.Content = "O";
            }
            btn.IsEnabled = false;
            CheckWinner();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)e.Source;

            Player++;
            if (Player % 2 == 0)
            {
                CheckRule[7] = -1;
                btn.Content = "X";
            }
            else
            {
                CheckRule[7] = 1;
                btn.Content = "O";
            }
            btn.IsEnabled = false;
            CheckWinner();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)e.Source;

            Player++;
            if (Player % 2 == 0)
            {
                CheckRule[8] = -1;
                btn.Content = "X";
            }
            else
            {
                CheckRule[8] = 1;
                btn.Content = "O";
            }
            btn.IsEnabled = false;
            CheckWinner();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Player = 0;
            Winner = 0;
            for (int i=0;i<9;i++)
            {
                CheckRule[i] = 0;
            }
            GameBox1.Content = "";
            GameBox1.IsEnabled = true;
            GameBox2.Content = "";
            GameBox2.IsEnabled = true;
            GameBox3.Content = "";
            GameBox3.IsEnabled = true;
            GameBox4.Content = "";
            GameBox4.IsEnabled = true;
            GameBox5.Content = "";
            GameBox5.IsEnabled = true;
            GameBox6.Content = "";
            GameBox6.IsEnabled = true;
            GameBox7.Content = "";
            GameBox7.IsEnabled = true;
            GameBox8.Content = "";
            GameBox8.IsEnabled = true;
            GameBox9.Content = "";
            GameBox9.IsEnabled = true;
            WinnerShow.Visibility = Visibility.Hidden;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)e.Source;

            Player++;
            if (Player%2 == 0)
            {
                CheckRule[0] = -1;
                btn.Content = "X";
            }
            else
            {
                CheckRule[0] = 1;
                btn.Content = "O";
            }
            btn.IsEnabled = false;
            CheckWinner();
        }

        private void CheckWinner()
        {
            if (CheckRule[0] == CheckRule[1] && CheckRule[1] == CheckRule[2])
            {
                Winner = CheckRule[0];
            }
            else if (CheckRule[3] == CheckRule[4] && CheckRule[4] == CheckRule[5])
            {
                Winner = CheckRule[3];
            }
            else if (CheckRule[6] == CheckRule[7] && CheckRule[7] == CheckRule[8])
            {
                Winner = CheckRule[6];
            }
            else if (CheckRule[0] == CheckRule[3] && CheckRule[3] == CheckRule[6])
            {
                Winner = CheckRule[0];
            }
            else if (CheckRule[1] == CheckRule[4] && CheckRule[4] == CheckRule[7])
            {
                Winner = CheckRule[1];
            }
            else if (CheckRule[2] == CheckRule[5] && CheckRule[5] == CheckRule[8])
            {
                Winner = CheckRule[2];
            }
            else if (CheckRule[0] == CheckRule[4] && CheckRule[4] == CheckRule[8])
            {
                Winner = CheckRule[0];
            }
            else if (CheckRule[2] == CheckRule[4] && CheckRule[4] == CheckRule[6])
            {
                Winner = CheckRule[2];
            }

            if ((Winner != 0 && Player>3) || Player == 9)
            {
                if (Winner == -1)
                {
                    WinnerShow.Text = "此局，X 贏了";
                }
                else if (Winner == 1)
                {
                    WinnerShow.Text = "此局，O 贏了";
                }
                else
                {
                    WinnerShow.Text = "平局";
                }
                WinnerShow.Visibility = Visibility.Visible;
            }
        }
    }
}

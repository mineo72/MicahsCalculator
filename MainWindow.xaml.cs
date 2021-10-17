using System;
using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int block1;
        private int block2;
        private string enterBox = "";
        private char sym;
        private bool stage2 = false;
        private bool end = false;
        private char lastIn;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            if (stage2 == true && enterBox != "")
            {
                block2 = Convert.ToInt32(enterBox);
                enterBox = "";
                if (sym == '+')
                {
                    textBlock.Text = Convert.ToString(block1 + block2);
                }
                else if (sym == '-')
                {
                    textBlock.Text = Convert.ToString(block1 - block2);
                }
                else if (sym == '*')
                {
                    textBlock.Text = Convert.ToString(block1 * block2);
                }
                else if (sym == '/')
                {
                    textBlock.Text = Convert.ToString(block1 / block2);
                }
                stage2 = false;
                end = true;

            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }



        private void clear_Click(object sender, RoutedEventArgs e)
        {
            enterBox = "";
            textBlock.Text = "";
            stage2 = false;
            end = false;
        }

        private void un_Click(object sender, RoutedEventArgs e)
        {
            NumAdd("1");
        }

        private void deux_Click(object sender, RoutedEventArgs e)
        {
            NumAdd("2");
        }

        private void trois_Click(object sender, RoutedEventArgs e)
        {
            NumAdd("3");
        }

        private void quatre_Click(object sender, RoutedEventArgs e)
        {
            NumAdd("4");
        }

        private void cinq_Click(object sender, RoutedEventArgs e)
        {
            NumAdd("5");
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            NumAdd("6");
        }

        private void sept_Click(object sender, RoutedEventArgs e)
        {
            NumAdd("7");
        }

        private void huit_Click(object sender, RoutedEventArgs e)
        {
            NumAdd("8");
        }

        private void neuf_Click(object sender, RoutedEventArgs e)
        {
            NumAdd("9");
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (end == false)
            {
                NumAdd("0");
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            SymChoice('+');
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            SymChoice('-');
        }

        private void multi_Click(object sender, RoutedEventArgs e)
        {
            SymChoice('*');
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            SymChoice('/');
        }
        public void NumAdd(string insNum)
        {
            if (end == false)
            {
                enterBox = enterBox + insNum;
                textBlock.Text = enterBox;
                lastIn = Convert.ToChar(insNum);

            }
        }
        public void SymChoice(char symb)
        {
            if (stage2 == false && end != true)
            {
                block1 = Convert.ToInt32(enterBox);
                enterBox = "";
                sym = symb;
                stage2 = true;
            }
            else
            {
                MessageBox.Show("Symbol Already Chosen");
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (enterBox != "" && end != true)
            {
                enterBox = enterBox.Remove(enterBox.Length - 1, 1);
                textBlock.Text = enterBox;
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}

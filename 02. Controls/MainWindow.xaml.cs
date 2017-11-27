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

namespace _02.Controls
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

        public bool Image = false;
        public void btn1_Click(object sender, RoutedEventArgs e)
        {
            if(btn1.Content.ToString() == "")
            {
                if(Image == false)
                {
                    btn1.Content = "x";
                    Image = true;
                }
                else if (Image == true)
                {
                    btn1.Content = "o";
                    Image = false;
                        
                }
            }
            Winner();
        }

        public void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (btn2.Content.ToString() == "")
            {
                if (Image == false)
                {
                    btn2.Content = "x";
                    Image = true;
                }
                else if (Image == true)
                {
                    btn2.Content = "o";
                    Image = false;

                }
            }
            Winner();
        }

        public void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (btn3.Content.ToString() == "")
            {
                if (Image == false)
                {
                    btn3.Content = "x";
                    Image = true;
                }
                else if (Image == true)
                {
                    btn3.Content = "o";
                    Image = false;

                }
            }
            Winner();
        }

        public void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (btn4.Content.ToString() == "")
            {
                if (Image == false)
                {
                    btn4.Content = "x";
                    Image = true;
                }
                else if (Image == true)
                {
                    btn4.Content = "o";
                    Image = false;

                }
            }
            Winner();
        }

        public void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (btn5.Content.ToString() == "")
            {
                if (Image == false)
                {
                    btn5.Content = "x";
                    Image = true;
                }
                else if (Image == true)
                {
                    btn5.Content = "o";
                    Image = false;

                }
            }
            Winner();
        }

        public void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (btn6.Content.ToString() == "")
            {
                if (Image == false)
                {
                    btn6.Content = "x";
                    Image = true;
                }
                else if (Image == true)
                {
                    btn6.Content = "o";
                    Image = false;

                }
            }
            Winner();
        }

        public void btn7_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btn7.Content == "")
            {
                if (Image == false)
                {
                    btn7.Content = "x";
                    Image = true;
                }
                else if (Image == true)
                {
                    btn7.Content = "o";
                    Image = false;

                }
            }
            Winner();
        }

        public void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (btn8.Content.ToString() == "")
            {
                if (Image == false)
                {
                    btn8.Content = "x";
                    Image = true;
                }
                else if (Image == true)
                {
                    btn8.Content = "o";
                    Image = false;

                }
            }
            Winner();
        }

        public void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (btn9.Content.ToString() == "")
            {
                if (Image == false)
                {
                    btn9.Content = "x";
                    Image = true;
                }
                else if (Image == true)
                {
                    btn9.Content = "o";
                    Image = false;

                }
            }
            Winner();
        }  
        
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            btn1.Content = "";
            btn2.Content = "";
            btn3.Content = "";
            btn4.Content = "";
            btn5.Content = "";
            btn6.Content = "";
            btn7.Content = "";
            btn8.Content = "";
            btn9.Content = "";
        }
        
        public void Winner()
        {
            string test = "x";
            Winner1(test);
            test = "0";
            Winner1(test);
        }

        public void Winner1(string test)
        {
            if (btn1.Content.ToString() == test && btn2.Content.ToString() == test && btn3.Content.ToString() == test || btn4.Content.ToString() == test && btn5.Content.ToString() == test && btn6.Content.ToString() == test || btn7.Content.ToString() == test && btn8.Content.ToString() == test && btn9.Content.ToString() == test
            || btn1.Content.ToString() == test && btn4.Content.ToString() == test && btn7.Content.ToString() == test || btn2.Content.ToString() == test && btn5.Content.ToString() == test && btn8.Content.ToString() == test || btn3.Content.ToString() == test && btn6.Content.ToString() == test && btn9.Content.ToString() == test
            || btn1.Content.ToString() == test && btn5.Content.ToString() == test && btn9.Content.ToString() == test || btn3.Content.ToString() == test && btn5.Content.ToString() == test && btn7.Content.ToString() == test)
            {
                if (test == "X")
                {
                    MessageBox.Show(" X je hebt gewonnen", "Gefeliciteerd");
                }
                else
                {
                    MessageBox.Show(" 0 je hebt gewonnen", "Gefeliciteerd");
                }

                Button_Click(null, null);
            }
           
        }
    }

}

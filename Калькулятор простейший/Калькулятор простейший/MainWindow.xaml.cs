using System.Windows;

namespace Калькулятор_простейший
{
    public partial class MainWindow : Window
    {
        int one = 0;
        int two = 0;
        bool flagstart = true;
        bool flagend = true;
        string str = "";
        string last = "";
        char znak = ' ';

        private void ClickOne (object sender, RoutedEventArgs e)
        {

            if ( flagend == true && flagstart == true)
            {
                str += "1";
                last = "1";
                Text.Text = str;
                one = one * 10 + 1;
            }

            else if (str != "" && flagstart == false)
            {
                flagend = false;
                str += "1";
                last = "1";
                Text.Text = str;
                two = two * 10 + 1;
            }

        }

        private void ClickTwo(object sender, RoutedEventArgs e)
        {

            if (flagend == true && flagstart == true)
            {
                str += "2";
                last = "2";
                Text.Text = str;
                one = one * 10 + 2;
            }

            else if (str != "" && flagstart == false)
            {
                flagend = false;
                str += "2";
                last = "2";
                Text.Text = str;
                two = two * 10 + 2;
            }

        }
        private void ClickThree(object sender, RoutedEventArgs e)
        {

            if (flagend == true && flagstart == true)
            {
                str += "3";
                last = "3";
                Text.Text = str;
                one = one * 10 + 3;
            }

            else if (str != "" && flagstart == false)
            {
                flagend = false;
                str += "3";
                last = "3";
                Text.Text = str;
                two = two * 10 + 3;
            }

        }
        private void ClickFour(object sender, RoutedEventArgs e)
        {

            if (flagend == true && flagstart == true)
            {
                str += "4";
                last = "4";
                Text.Text = str;
                one = one * 10 + 4;
            }

            else if (str != "" && flagstart == false)
            {
                flagend = false;
                str += "4";
                last = "4";
                Text.Text = str;
                two = two * 10 + 4;
            }

        }
        private void ClickFive(object sender, RoutedEventArgs e)
        {

            if (flagend == true && flagstart == true)
            {
                str += "5";
                last = "5";
                Text.Text = str;
                one = one * 10 + 5;
            }

            else if (str != "" && flagstart == false)
            {
                flagend = false;
                str += "5";
                last = "5";
                Text.Text = str;
                two = two * 10 + 5;
            }

        }
        private void ClickSix(object sender, RoutedEventArgs e)
        {

            if (flagend == true && flagstart == true)
            {
                str += "6";
                last = "6";
                Text.Text = str;
                one = one * 10 + 6;
            }

            else if (str != "" && flagstart == false)
            {
                flagend = false;
                str += "6";
                last = "6";
                Text.Text = str;
                two = two * 10 + 6;            }

        }
        private void ClickSeven(object sender, RoutedEventArgs e)
        {

            if (flagend == true && flagstart == true)
            {
                str += "7";
                last = "7";
                Text.Text = str;
                one = one * 10 + 7;
            }

            else if (str != "" && flagstart == false)
            {
                flagend = false;
                str += "7";
                last = "7";
                Text.Text = str;
                two = two * 10 + 7;
            }

        }
        private void ClickEight(object sender, RoutedEventArgs e)
        {

            if (flagend == true && flagstart == true)
            {
                str += "8";
                last = "8";
                Text.Text = str;
                one = one * 10 + 8;
            }

            else if (str != "" && flagstart == false)
            {
                flagend = false;
                str += "8";
                last = "8";
                Text.Text = str;
                two = two * 10 + 8;
            }

        }
        private void ClickNine(object sender, RoutedEventArgs e)
        {

            if (flagend == true && flagstart == true)
            {
                str += "9";
                last = "9";
                Text.Text = str;
                one = one * 10 + 9;
            }

            else if (str != "" && flagstart == false)
            {
                flagend = false;
                str += "9";
                last = "9";
                Text.Text = str;
                two = two * 10 + 9;
            }

        }
        private void ClickZero(object sender, RoutedEventArgs e)
        {

            if (flagend == true && flagstart == true)
            {
                str += "0";
                last = "0";
                Text.Text = str;
                one = one * 10;
            }

            else if (str != "" && flagstart == false)
            {
                flagend = false;
                str += "1";
                last = "1";
                Text.Text = str;
                two = two * 10;
            }

        }
        private void ClickPlus(object sender, RoutedEventArgs e)
        {

            if (last != "+" && last != "-" && last != "*" && last != "/" && str != "")
            {
                flagstart = false;
                last = "+";
                str += "+";
                Text.Text = str;
                znak = '+';
            }
;
        }
        private void ClickMinus(object sender, RoutedEventArgs e)
        {

            if (last != "+" && last != "-" && last != "*" && last != "/" && str != "")
            {
                flagstart = false;
                last = "-";
                str += "-";
                Text.Text = str;
                znak = '-';
            }

        }
        private void ClickUmn(object sender, RoutedEventArgs e)
        {

            if (last != "+" && last != "-" && last != "*" && last != "/" && str != "")
            {
                flagstart = false;
                last = "*";
                str += "*";
                Text.Text = str;
                znak = '*';
            }

        }
        private void ClickMinMin(object sender, RoutedEventArgs e)
        {

            str += "(-)";
            Text.Text = str;

        }
        private void ClickRavn(object sender, RoutedEventArgs e)
        {
            if (flagend == false)
            {
                if (znak == '+')
                {
                    int ans = one + two;
                    Answer.Text = ans.ToString();
                }

                else if (znak == '-')
                {
                    int ans = one - two;
                    Answer.Text = ans.ToString();
                }

                else if (znak == '*')
                {
                    int ans = one * two;
                    Answer.Text = ans.ToString();
                }

                else if (znak == '/')
                {
                    double ans = (double)one / two;
                    Answer.Text = ans.ToString();
                }
            }

        }
        private void ClickAllDel(object sender, RoutedEventArgs e)
        {

            one = 0;
            two = 0;
            flagstart = true;
            flagend = true;
            str = "";
            last = "";
            znak = ' ';

            Text.Text = str;
            Answer.Text = "=";

        }
        private void ClickDelet(object sender, RoutedEventArgs e)
        {

            if (last != "+" && last != "-" && last != "*" && last != "/" && str != "")
            {
                flagstart = false;
                last = "/";
                str += "/";
                Text.Text = str;
                znak = '/';
            }

        }
        private void ClickDel(object sender, RoutedEventArgs e)
        {

            str = str.Remove(str.Length - 1);   
            Text.Text = str;

            if (flagstart == true && flagend == true)
            {
                last = "";
                one = one / 10;
            }

            else if (flagstart == false && flagend == false)
            {
                two = two / 10;
                last = "";
            }

            else if (flagstart == false && flagend == true)
            {
                znak = ' ';
                last = "";
            }
        }


        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

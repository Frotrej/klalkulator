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

namespace kalk4
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool action = false; //Czy + - * / było klikniete ?
        public bool actionEqual = false; // Czy = było klikniete ?
        public int sign=0; //0=default  1=add    2=sub   3=mul   4=div  
        public double first = 0, second = 0;

        
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Number(string strNumber)
        {

            if (action == true || actionEqual==true)
            {                
                result.Text = "";
                action = false;
                actionEqual = false;
            }

            result.Text += strNumber;
        }

        private double Result2ToInt()
        {
            return Convert.ToDouble(result2.Text);
        }

        private double ResultToInt()
        {
            return Convert.ToDouble(result.Text);
        }

        private void RefreshRes2()
        {
            result2.Text = Convert.ToString(first);
        }

        private void SetSign(int set)
        {
            sign = set;
        }

        //---------------------------------------------------------

        private void one_Click(object sender, RoutedEventArgs e)
        {
            Number("1");
        }
        
        private void two_Click(object sender, RoutedEventArgs e)
        {
            Number("2");
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            Number("3");
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            Number("4");
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            Number("5");
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            Number("6");
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            Number("7");
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            Number("8");
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            Number("9");
        }

        private void addition_Click(object sender, RoutedEventArgs e)
        {
            Add();
            SetSign(1);
        }
        private void Add()
        {
            if (sign == 1 || sign == 0)
            {
                first = Result2ToInt();
                second = ResultToInt();
                first += second;
                RefreshRes2();
                action = true;
            }
        }
        //
        //
        private void subtraction_Click(object sender, RoutedEventArgs e)
        {
            Sub();
            SetSign(2);
        }
        private void Sub()
        {
            if (sign == 2 || sign == 0)
            {
                first = Result2ToInt();
                second = ResultToInt();
                first -= second;
                RefreshRes2();
                action = true;
            }
        }
        //
        //
        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            Mul();
            SetSign(3);
        }
        private void Mul()
        {
            if (sign == 3 || sign == 0)
            {
                first = Result2ToInt();
                second = ResultToInt();
                first *= second;
                RefreshRes2();
                action = true;
            }
        }
        //
        //
        private void division_Click(object sender, RoutedEventArgs e)
        {
            Div();
            SetSign(4);
        }
        private void Div()
        {
            if (sign == 4 || sign == 0)
            {
                first = Result2ToInt();
                second = ResultToInt();
                if (second != 0)//dzielenie przez 0
                {
                    first /= second;
                }
                if (second != 0 || first == 0)
                {
                    RefreshRes2();
                }
                action = true;
            }
        }
        //
        //
        private void equal_Click(object sender, RoutedEventArgs e)
        {
            switch (sign)
             {
                 case 1:
                    Add();
                    break;

                case 2:
                    Sub();
                     break;

                 case 3:
                    Mul();
                     break;

                 case 4:
                    Div();
                     break;

                 default:
                     break;
             }

            actionEqual = true;
        }

    }
}

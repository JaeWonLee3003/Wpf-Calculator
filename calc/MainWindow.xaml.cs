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

namespace calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastresult;
        double result;

        public MainWindow()
        {
            InitializeComponent();
            ButtonCreate();
            CalcTextBox.Text = "0";

        }

        public enum SelectedOperator
        {
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        public class SimpleMath
        {
            public static double Add(double n1, double n2)
            {
                return n1 + n2;
            }
            public static double Subtract(double n1, double n2)
            {
                return n1 - n2;
            }
            public static double Multiple(double n1, double n2)
            {
                return n1 * n2;
            }
            public static double Divide(double n1, double n2)
            {
                return n1 / n2;
            }

        }
        private void ButtonCreate()
        {
            /* Number Button Create Method */
            NineButton.Click += NumberButton_Click;
            EightButton.Click += NumberButton_Click;
            SevenButton.Click += NumberButton_Click;
            SixButton.Click += NumberButton_Click;
            FiveButton.Click += NumberButton_Click;
            FourButton.Click += NumberButton_Click;
            ThreeButton.Click += NumberButton_Click;
            TwoButton.Click += NumberButton_Click;
            OneButton.Click += NumberButton_Click;
            ZeroButton.Click += NumberButton_Click;



            /* Four basic operations Button Create Method */
            PlusButton.Click += PlusButton_Click;
            MinusButton.Click += MinusButton_Click;
            DivisButton.Click += DivisButton_Click;

            /* Etc Button Create Method */
            PlusMinusButton.Click += PlusMinusButton_Click;
            DotButton.Click += DotButton_Click;
            ResultButton.Click += ResultButton_Click;
            ClearButton.Click += ClearButton_Click;
            ClearEntryButton.Click += ClearEntryButton_Click;

        }

        private void ClearEntryButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            CalcTextBox.Text = "0";
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            // 1. 어떤 버튼을 눌러는지 파악
            // 1.1 TextBox에 표시된 수를 확인해야함
            //      "0" -> 1를 누름 -> "1"
            //      "1" -> 2를 누름 -> "12"
            //
            // 2. UI에 표시됨
            double input = 0;
            if (CalcTextBox.Text == "0")
            {
                if (sender == NineButton)
                {
                    input = 9;
                }
                if (sender == EightButton)
                {
                    input = 8;
                }
                if (sender == SevenButton)
                {
                    input = 7;
                }
                if (sender == SixButton)
                {
                    input = 6;
                }
                if (sender == FiveButton)
                {
                    input = 5;
                }
                if (sender == FourButton)
                {
                    input = 4;
                }
                if (sender == ThreeButton)
                {
                    input = 3;
                }
                if (sender == TwoButton)
                {
                    input = 2;
                }
                if (sender == OneButton)
                {
                    input = 1;
                }
                if (sender == ZeroButton)
                {
                    input = 0;
                }
                CalcTextBox.Text = input.ToString();
            }
            else
            {
                if (sender == NineButton)
                {
                    input = 9;
                }
                if (sender == EightButton)
                {
                    input = 8;
                }
                if (sender == SevenButton)
                {
                    input = 7;
                }
                if (sender == SixButton)
                {
                    input = 6;
                }
                if (sender == FiveButton)
                {
                    input = 5;
                }
                if (sender == FourButton)
                {
                    input = 4;
                }
                if (sender == ThreeButton)
                {
                    input = 3;
                }
                if (sender == TwoButton)
                {
                    input = 2;
                }
                if (sender == OneButton)
                {
                    input = 1;
                }
                if (sender == ZeroButton)
                {
                    input = 0;
                }
                CalcTextBox.Text += input.ToString();
            }

             
            
        }

        /* Calculator Method*/



        /* Number Button Methods*/
        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }



        /* Etc Button Methods */
        private void DivisButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void DotButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void PlusMinusButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        
    }
}

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
using static calc.MainWindow;

namespace calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber;
        double result;
        SelectedOperator selectedOperator;

        public MainWindow()
        {
            InitializeComponent();
            ButtonCreate();
            CalcTextBox.Text = "0";

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

        public enum SelectedOperator
        {
            Addition,
            Subtraction,
            Multiplication,
            Division
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
            PlusButton.Click += OperationButton_Click;
            MinusButton.Click += OperationButton_Click;
            MultipleButton.Click += OperationButton_Click;
            DivisButton.Click += OperationButton_Click;

            /* Etc Button Create Method */
            PlusMinusButton.Click += EtcButton_Click;
            DotButton.Click += EtcButton_Click;
            ResultButton.Click += EtcButton_Click;
            ClearButton.Click += EtcButton_Click;
            ClearEntryButton.Click += EtcButton_Click;

        }

        private void EtcButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender == ClearButton)
            {
                CalcTextBox.Text = "0";
            }

            if(sender == ResultButton)
            {
                double newNumber;
                newNumber = double.Parse(CalcTextBox.Text);

                switch (selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = SimpleMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Subtraction:
                        result = SimpleMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        result = SimpleMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                        result = SimpleMath.Add(lastNumber, newNumber);
                        break;
                }

                CalcTextBox.Text = result.ToString();


                }
        }
        /// <summary>
        /// 숫자 버튼을 입력했을 때 출력 되는 발생하는 함수
        /// </summary>
        /// <param name="sender">숫자 버튼 이름</param>
        /// <param name="e"></param>
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            // 1. 어떤 버튼을 눌러는지 파악
            // 1.1 TextBox에 표시된 수를 확인해야함
            //      "0" -> 1를 누름 -> "1"
            //      "1" -> 2를 누름 -> "12"
            //
            // 2. UI에 표시됨
            double inputNum = 0;
            if (CalcTextBox.Text == "0")
            {
                if (sender == NineButton)
                {
                    inputNum = 9;
                }
                if (sender == EightButton)
                {
                    inputNum = 8;
                }
                if (sender == SevenButton)
                {
                    inputNum = 7;
                }
                if (sender == SixButton)
                {
                    inputNum = 6;
                }
                if (sender == FiveButton)
                {
                    inputNum = 5;
                }
                if (sender == FourButton)
                {
                    inputNum = 4;
                }
                if (sender == ThreeButton)
                {
                    inputNum = 3;
                }
                if (sender == TwoButton)
                {
                    inputNum = 2;
                }
                if (sender == OneButton)
                {
                    inputNum = 1;
                }
                if (sender == ZeroButton)
                {
                    inputNum = 0;
                }
                CalcTextBox.Text = inputNum.ToString();
            }
            else
            {
                if (sender == NineButton)
                {
                    inputNum = 9;
                }
                if (sender == EightButton)
                {
                    inputNum = 8;
                }
                if (sender == SevenButton)
                {
                    inputNum = 7;
                }
                if (sender == SixButton)
                {
                    inputNum = 6;
                }
                if (sender == FiveButton)
                {
                    inputNum = 5;
                }
                if (sender == FourButton)
                {
                    inputNum = 4;
                }
                if (sender == ThreeButton)
                {
                    inputNum = 3;
                }
                if (sender == TwoButton)
                {
                    inputNum = 2;
                }
                if (sender == OneButton)
                {
                    inputNum = 1;
                }
                if (sender == ZeroButton)
                {
                    inputNum = 0;
                }
                CalcTextBox.Text += inputNum.ToString();
            }
            lastNumber = double.Parse(CalcTextBox.Text);


        }

        /// <summary>
        /// 연산 기호 버튼을 눌렀을 때 연산해주는 함수
        /// </summary>
        /// <param name="sender">연산 기호 버튼 이름</param>
        /// <param name="e"></param>
        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender == PlusButton)
            {
                selectedOperator = SelectedOperator.Addition;
            }
            if (sender == MinusButton)
            {
                selectedOperator = SelectedOperator.Subtraction;
            }
            if (sender == DivisButton)
            {
                selectedOperator = SelectedOperator.Division;
            }
            if (sender == MultipleButton)
            {
                selectedOperator = SelectedOperator.Multiplication;
            }
        }

        

        
    }
}

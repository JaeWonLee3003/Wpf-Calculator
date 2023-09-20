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
        public MainWindow()
        {
            InitializeComponent();
            ButtonCreate();
            
        }

        private void ButtonCreate()
        {
            /* Number Button Create Method */
            NineButton.Click += NineButton_Click;
            EightButton.Click += EightButton_Click;
            SevenButton.Click += SevenButton_Click;
            SixButton.Click += SixButton_Click;
            FiveButton.Click += FiveButton_Click;
            FourButton.Click += FourButton_Click;
            ThreeButton.Click += ThreeButton_Click;
            TwoButton.Click += TwoButton_Click;
            OneButton.Click += OneButton_Click;

            /* Four basic operations Button Create Method */
            PlusButton.Click += PlusButton_Click;
            MinusButton.Click += MinusButton_Click;
            DivisButton.Click += DivisButton_Click;

            /* Etc Button Create Method */
            PlusMinusButton.Click += PlusMinusButton_Click;
            DotButton.Click += DotButton_Click;
            ResultButton.Click += ResultButton_Click;
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

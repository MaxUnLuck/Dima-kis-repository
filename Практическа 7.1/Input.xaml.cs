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
using System.Windows.Shapes;

namespace Практическа_7._1
{
    /// <summary>
    /// Логика взаимодействия для Input.xaml
    /// </summary>
    public partial class Input : Window
    {
        public Input()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        { 
        if(Composition.IsChecked.Value)
        {
                CalcTB.Text = Num1TextBox.Text + Num2TextBox.Text;
                Cal


        }    
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)//сложение
        {
           
        }

        private void Num1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}

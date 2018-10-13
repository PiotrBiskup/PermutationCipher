using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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

namespace SzyfrPermutacyjny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int keyLenght = 2;
        List<TextBox> keyTextBoxList = new List<TextBox>();
        List<int> keyValueList = new List<int>(9) { 0 , 0, 0, 0, 0, 0, 0 ,0 ,0};



        public MainWindow()
        {
            InitializeComponent();

            keyTextBoxList.Add(keyTexBox1);
            keyTextBoxList.Add(keyTexBox2);
            keyTextBoxList.Add(keyTexBox3);
            keyTextBoxList.Add(keyTexBox4);
            keyTextBoxList.Add(keyTexBox5);
            keyTextBoxList.Add(keyTexBox6);
            keyTextBoxList.Add(keyTexBox7);
            keyTextBoxList.Add(keyTexBox8);
            keyTextBoxList.Add(keyTexBox9);

            keyTexBox3.Visibility = Visibility.Hidden;
            keyTexBox4.Visibility = Visibility.Hidden;
            keyTexBox5.Visibility = Visibility.Hidden;
            keyTexBox6.Visibility = Visibility.Hidden;
            keyTexBox7.Visibility = Visibility.Hidden;
            keyTexBox8.Visibility = Visibility.Hidden;
            keyTexBox9.Visibility = Visibility.Hidden;

            LenghtDropDown.SelectedIndex = 0;

        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {     
            Regex regex = new Regex("[^1-9]");
            e.Handled = regex.IsMatch(e.Text);
       
        }


        private void LenghtDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            keyLenght = (int)combo.SelectedValue;

            for(int i = 0; i < 9; i++)
            {
                if (i < keyLenght)
                {
                    keyTextBoxList[i].Visibility = Visibility.Visible;
                }
                else
                {
                    keyTextBoxList[i].Visibility = Visibility.Hidden;
                }
            }


        }


        private void keyTexBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;
            int key;
            int.TryParse(tb.Text, out key);

            keyValueList[0] = 0;

            if (key > 0 && key <= keyLenght && !keyValueList.Contains(key))
            {
                keyValueList[0] = key;
                
            }
            else
            {
                tb.Clear();
             
            }
            
        }

        private void keyTexBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;
            int key;
            int.TryParse(tb.Text, out key);

            keyValueList[1] = 0;

            if (key > 0 && key <= keyLenght && !keyValueList.Contains(key))
            {
                keyValueList[1] = key;

            }
            else
            {
                tb.Clear();

            }
        }

        private void keyTexBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;
            int key;
            int.TryParse(tb.Text, out key);

            keyValueList[2] = 0;

            if (key > 0 && key <= keyLenght && !keyValueList.Contains(key))
            {
                keyValueList[2] = key;

            }
            else
            {
                tb.Clear();

            }
        }

        private void keyTexBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;
            int key;
            int.TryParse(tb.Text, out key);

            keyValueList[3] = 0;

            if (key > 0 && key <= keyLenght && !keyValueList.Contains(key))
            {
                keyValueList[3] = key;

            }
            else
            {
                tb.Clear();

            }
        }

        private void keyTexBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;
            int key;
            int.TryParse(tb.Text, out key);

            keyValueList[4] = 0;

            if (key > 0 && key <= keyLenght && !keyValueList.Contains(key))
            {
                keyValueList[4] = key;

            }
            else
            {
                tb.Clear();

            }
        }

        private void keyTexBox6_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;
            int key;
            int.TryParse(tb.Text, out key);

            keyValueList[5] = 0;

            if (key > 0 && key <= keyLenght && !keyValueList.Contains(key))
            {
                keyValueList[5] = key;

            }
            else
            {
                tb.Clear();

            }
        }

        private void keyTexBox7_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;
            int key;
            int.TryParse(tb.Text, out key);

            keyValueList[6] = 0;

            if (key > 0 && key <= keyLenght && !keyValueList.Contains(key))
            {
                keyValueList[6] = key;

            }
            else
            {
                tb.Clear();

            }
        }

        private void keyTexBox8_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;
            int key;
            int.TryParse(tb.Text, out key);

            keyValueList[7] = 0;

            if (key > 0 && key <= keyLenght && !keyValueList.Contains(key))
            {
                keyValueList[7] = key;

            }
            else
            {
                tb.Clear();

            }
        }

        private void keyTexBox9_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;
            int key;
            int.TryParse(tb.Text, out key);

            keyValueList[8] = 0;

            if (key > 0 && key <= keyLenght && !keyValueList.Contains(key))
            {
                keyValueList[8] = key;

            }
            else
            {
                tb.Clear();

            }
        }








        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

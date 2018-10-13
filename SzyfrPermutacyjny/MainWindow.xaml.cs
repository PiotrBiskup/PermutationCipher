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

namespace SzyfrPermutacyjny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int keyLenght = 2;
        List<ComboBox> keys = new List<ComboBox>(10);
        List<int> keyValues = new List<int>();
        int key1 , key2, key3, key4, key5, key6, key7, key8, key9, key10;



        public MainWindow()
        {
            InitializeComponent();

            keys.Add(Key1);
            keys.Add(Key2);
            keys.Add(Key3);
            keys.Add(Key4);
            keys.Add(Key5);
            keys.Add(Key6);
            keys.Add(Key7);
            keys.Add(Key8);
            keys.Add(Key9);
            keys.Add(Key10);

            Key3.Visibility = Visibility.Hidden;
            Key4.Visibility = Visibility.Hidden;
            Key5.Visibility = Visibility.Hidden;
            Key6.Visibility = Visibility.Hidden;
            Key7.Visibility = Visibility.Hidden;
            Key8.Visibility = Visibility.Hidden;
            Key9.Visibility = Visibility.Hidden;
            Key10.Visibility = Visibility.Hidden;

            LenghtDropDown.SelectedIndex = 0;

        }
            
        

        private void LenghtDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            keyLenght = (int)combo.SelectedValue;

            keyValues.Clear();

            for(int i = 1; i <= keyLenght; i++)
            {
                keyValues.Add(i);
            }

            for(int i = 0; i < 10; i++)
            {
                if(i < keyLenght)
                {
                    keys[i].Visibility = Visibility.Visible;
                    keys[i].ItemsSource = keyValues;
                } else
                {
                    keys[i].Visibility = Visibility.Hidden;
                    keys[i].ItemsSource = keyValues;
                    keys[i].Text = "";
                }
            }
        }



        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RefreshKeyValues(int selectedValue)
        {
            
            keyValues.Remove(selectedValue);
            foreach (ComboBox key in keys)
            {
                key.ItemsSource = keyValues;
            }
            

        }

        private void RefreshKeyValues()
        {
            foreach (ComboBox key in keys)
            {
                key.ItemsSource = keyValues;
            }
        }

        private void Key1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            key1 = (int)combo.SelectedValue;

            RefreshKeyValues(key1);
        }

        private void Key2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            key2 = (int)combo.SelectedValue;

            RefreshKeyValues(key2);
        }

        private void Key3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            key3 = (int)combo.SelectedValue;

            RefreshKeyValues(key3);
        }

        private void Key4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            key4 = (int)combo.SelectedValue;

            RefreshKeyValues(key4);
        }

        private void Key5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            key5 = (int)combo.SelectedValue;

            RefreshKeyValues(key5);
        }

        private void Key6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            key6 = (int)combo.SelectedValue;

            RefreshKeyValues(key6);
        }

        private void Key7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            key7 = (int)combo.SelectedValue;

            RefreshKeyValues(key7);
        }

        private void Key8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            key8 = (int)combo.SelectedValue;

            RefreshKeyValues(key8);
        }

        private void Key9_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            key9 = (int)combo.SelectedValue;

            RefreshKeyValues(key9);
        }

        private void Key10_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            key10 = (int)combo.SelectedValue;

            RefreshKeyValues(key10);
        }
    }
}

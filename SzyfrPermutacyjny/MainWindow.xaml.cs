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
using System.IO;
using Microsoft.Win32;

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
        Boolean isKeyCompleted = false;
        
    
        public MainWindow()
        {
            InitializeComponent();

            opistextBlock.Text = "Permutation Cipher jest to program, który pozwala na szyfrowanie i deszyfrowanie tekstu zgodnie z działaniem szyfru permutacyjnego o podanym kluczu. \n\nZasada działania szyfru permutacyjnego: teskt wejściowy dzielimy na n-elementowe łańcuchy znaków, gdzie n to długość klucza. Każdy element klucza musi być z przedziału ( 0, dlugosc_klucza > i elementy nie mogą się powtarzać. Wartość elementu klucza oznacza nowy indeks dla odpowiadającego mu elementu z n-elementowego łańcucha znaków. Jeżeli wprowadzony tekst jest niepodzielny przez długość klucza, dopełniony zostaje znakiem ' '.\n\nZasada działania programu: \n1. Wybierz długość klucza - minimalny 2, maksymalny 9.\n2. Wprowadź elementy klucza - program w czasie rzeczywistym sprawdza, czy wprowadzone dane są poprawne (akceptuje tylko znaki numeryczne, a wartości z poza prawidłowego przedziału są usuwane). Poniżej wyświetlana jest zawsze lista możliwych do wpisania liczb.\n3. Wprowadź lub wczytaj z pliku tekst (za pomocą przycisku \"Load from file\"), który chcesz szyfrować/zdeszyfrować. Dozwolone są wszystkie znaki.\n4. Kliknij na przycisk Encrypt/Decrypt w zależności co chcesz osiągnąć. Przyciski działają tylko jeżeli uzupełniony jest klucz. Program wyświetli odpowiedni komunikat w przypadku błędu.\n5. Zaszyfrowany/zdeszyfrowany teskt wyświetla się w oznaczonym TextBox'ie i moża go zapisać do pliku za pomocą przycisku \"Save output to file\".\n6. Przycisk \"Reset\" pozwala na wyczyszczenie wszystkich pól.";

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

        private void ShowRemainingDigits()
        {
            int countRemainingDigits = 0;
            string remainingDigits = "Remaining digits: ";
            for (int i = 1; i <= keyLenght; i++)
            {
                if (!keyValueList.Contains(i))
                {
                    remainingDigits += " [" + i + "]";
                    countRemainingDigits++;
                }
            }
            if(countRemainingDigits != 0)
            {
                TextBlockRemainingDigits.Text = remainingDigits;
                isKeyCompleted = false;

            } else
            {
                TextBlockRemainingDigits.Text = "Your key is complete!";
                HintsTextBlock.Text = "";
                isKeyCompleted = true;
            }
            
        }

        private void ClearKeyTextBox()
        {
            foreach(TextBox textBox in keyTextBoxList)
            {
                textBox.Clear();
            }
        }

        private void ClearKeys()
        {
           for (int i = 0; i < 9; i++)
            {
                keyValueList[i] = 0;
            }
        }


        private void LenghtDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            keyLenght = (int)combo.SelectedValue;

            ClearKeyTextBox();
            ClearKeys();

            ShowRemainingDigits();

            for (int i = 0; i < 9; i++)
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
                ShowRemainingDigits();

            }
            else
            {
                tb.Clear();
                ShowRemainingDigits();

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
                ShowRemainingDigits();

            }
            else
            {
                tb.Clear();
                ShowRemainingDigits();

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
                ShowRemainingDigits();

            }
            else
            {
                tb.Clear();
                ShowRemainingDigits();

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
                ShowRemainingDigits();

            }
            else
            {
                tb.Clear();
                ShowRemainingDigits();

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
                ShowRemainingDigits();

            }
            else
            {
                tb.Clear();
                ShowRemainingDigits();

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
                ShowRemainingDigits();

            }
            else
            {
                tb.Clear();
                ShowRemainingDigits();

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
                ShowRemainingDigits();

            }
            else
            {
                tb.Clear();
                ShowRemainingDigits();

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
                ShowRemainingDigits();

            }
            else
            {
                tb.Clear();
                ShowRemainingDigits();

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
                ShowRemainingDigits();

            }
            else
            {
                tb.Clear();
                ShowRemainingDigits();

            }
        }

        private void EncryptButton_Click(object sender, RoutedEventArgs e)
        {
            EncryptedTextBox.Clear();

            if(isKeyCompleted)
            {
                EncryptedTextBox.Text = Encrypt(TypedTextToEncrypt.Text);
            }
            else
            {
                HintsTextBlock.Text = "Complete your key!";
            }

        }

        private void DecryptButton_Click(object sender, RoutedEventArgs e)
        {
            EncryptedTextBox.Clear();

            if (isKeyCompleted)
            {
                EncryptedTextBox.Text = Decrypt(TypedTextToEncrypt.Text);
            }
            else
            {
                HintsTextBlock.Text = "Complete your key!";
            }

        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ClearKeys();
            ClearKeyTextBox();
            ShowRemainingDigits();
            TypedTextToEncrypt.Clear();
            EncryptedTextBox.Clear();


        }

        private String Encrypt(String stringToEncrypt)
        {
            int counter = 0;
            String EncryptedText = "";
            List<char> tempcharList = new List<char>();
            List<char> tempEncryptedCharList = new List<char>(keyLenght);

            for(int y =0; y < keyLenght; y++)
            {
                tempEncryptedCharList.Add('0');
            }

            for (int i = 0; i < stringToEncrypt.Length; i++)
            {
                tempcharList.Add(stringToEncrypt[i]);
                counter++;
                if(counter == keyLenght)
                {
                    
                    for (int j = 0; j < tempcharList.Count; j++)
                    {
                        tempEncryptedCharList[keyValueList[j]-1] = tempcharList[j];
                    }

                    for(int y = 0; y < tempEncryptedCharList.Count; y++)
                    {
                        EncryptedText += tempEncryptedCharList[y];
                    }

                   
                    counter = 0;
                    tempcharList.Clear();
                    

                }
            }

            Console.WriteLine("dlugosc: " + tempcharList.Count);

            if(tempcharList.Count != 0)
            {
                String tempRest = "";

                for (int i = 0; i < keyLenght - tempcharList.Count; i++)
                {
                    tempcharList.Add(' ');
                }

                for (int i = 0; i < tempcharList.Count; i++)
                {
                    tempRest += tempcharList[i];
                }

                EncryptedText += Encrypt(tempRest);
            }

           

            return EncryptedText;
        }

        private String Decrypt(String stringToDecrypt)
        {
            int counter = 0;
            String EncryptedText = "";
            List<char> tempcharList = new List<char>();
            List<char> tempEncryptedCharList = new List<char>(keyLenght);

            for (int y = 0; y < keyLenght; y++)
            {
                tempEncryptedCharList.Add('0');
            }

            for(int i = 0; i < stringToDecrypt.Length; i++)
            {
                tempcharList.Add(stringToDecrypt[i]);
                counter++;
                if (counter == keyLenght)
                {
                    for(int j = 0; j < tempcharList.Count; j++)
                    {
                        tempEncryptedCharList[j] = tempcharList[keyValueList[j]-1];
                    }

                    for (int y = 0; y < tempEncryptedCharList.Count; y++)
                    {
                        EncryptedText += tempEncryptedCharList[y];
                    }

                    counter = 0;
                    tempcharList.Clear();
                }
            }

            if (tempcharList.Count != 0)
            {
                for (int i = 0; i < keyLenght - tempcharList.Count; i++)
                {
                    EncryptedText += tempcharList[i];
                }
            }

            return EncryptedText;
        }


        private void LoadFromFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
            ofd.Filter = "Text documents (.txt)|*.txt";

            if (ofd.ShowDialog() == true)
            {
               /* String file = File.ReadAllText(ofd.FileName);
                for(int i = 0; i < file.Length; i++)
                {
                    Console.WriteLine(i + " : " + file[i]);
                }*/

                TypedTextToEncrypt.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void SaveToFileButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".txt";
            sfd.Filter = "Text documents (.txt)|*.txt";

            if (sfd.ShowDialog() == true)
            {
                File.WriteAllText(sfd.FileName, EncryptedTextBox.Text);
            }
        }
    }
}

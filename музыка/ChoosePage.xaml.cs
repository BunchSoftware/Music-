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
using музыка.Properties;
namespace музыка
{
    /// <summary>
    /// Логика взаимодействия для ChoosePage.xaml
    /// </summary>
    /// 
    public class RandomArray
    {      
        public int Random(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);           
        }
        public void DeleteIndexArray(ref int[] pageArray, int randomValue)
        {
            int[] newPageArray = new int[pageArray.Length - 1];
            for (int i = 0; i < randomValue; i++)
            {
                newPageArray[i] = pageArray[i]; 
            }
            for (int i = randomValue + 1; i < pageArray.Length; i++)
            {
                newPageArray[i - 1] = pageArray[i];
            }
            pageArray = newPageArray;
        }
        public int IndexOf(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return 0;
        }
    }
    public partial class ChoosePage : Page
    {      
        bool isSound = false;
        bool isOne = false;
        RandomArray randomArray = new RandomArray();
        public int[] instrumentValue = {0, 1, 2 , 3 ,4 , 5, 6};
        public bool instrumentBool = false;
        public int[] composerValue = { 0, 1, 2, 3, 4, 5, 6 };
        public bool composerBool = false;
        public int[] melodyValue = { 0, 1, 2, 3, 4, 5, 6 };
        public bool melodyBool = false;
        public int[] rusFolkValue = { 0, 1, 2, 3, 4, 5, 6 };
        public bool rusFolkBool = false;
        public int[] singerValue = { 0, 1, 2, 3, 4, 5, 6 };
        public bool singerBool = false;

        public ChoosePage()
        {
            InitializeComponent();
            if (isOne == false)
            {
                media.Play();
                isOne = true;
            }
        }
        private void Close_MouseDown(object sender, MouseButtonEventArgs e) => Application.Current.MainWindow.Close();

        private void Min_MouseDown(object sender, MouseButtonEventArgs e) => Application.Current.MainWindow.WindowState = WindowState.Minimized;

        private void InstrumentsCheckButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InstrumentsPage());
        }

        private void InstrumentsCheckButton1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InstrumentPage1());
        }

        private void InstrumentsCheckButton2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new InstrumentPage2());
        }

        private void InstrumentsCheckButton3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InstrumentPage3());
        }

        private void InstrumentsCheckButton4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InstrumentPage4());
        }

        private void InstrumentsCheckButton5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InstrumentPage5());
        }

        private void InstrumentsCheckButton6_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InstrumentPage6());
        }

        private void InstrumentsButton_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref instrumentValue, randomArray.IndexOf(instrumentValue, 0));
            this.InstrumentsButton.Visibility = Visibility.Hidden;
            this.InstrumentsCheckButton.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new InstrumentsPage());
        }

        private void InstrumentsButton1_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref instrumentValue, randomArray.IndexOf(instrumentValue, 1));
            this.InstrumentsButton1.Visibility = Visibility.Hidden;
            this.InstrumentsCheckButton1.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new InstrumentPage1());
        }

        private void InstrumentsButton2_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref instrumentValue, randomArray.IndexOf(instrumentValue, 2));
            this.InstrumentsButton2.Visibility = Visibility.Hidden;
            this.InstrumentsCheckButton2.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new InstrumentPage2());
        }

        private void InstrumentsButton3_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref instrumentValue, randomArray.IndexOf(instrumentValue, 3));
            this.InstrumentsButton3.Visibility = Visibility.Hidden;
            this.InstrumentsCheckButton3.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new InstrumentPage3());
        }

        private void InstrumentsButton4_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref instrumentValue, randomArray.IndexOf(instrumentValue, 4));
            this.InstrumentsButton4.Visibility = Visibility.Hidden;
            this.InstrumentsCheckButton4.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new InstrumentPage3());
        }

        private void InstrumentsButton5_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref instrumentValue, randomArray.IndexOf(instrumentValue, 5));
            this.InstrumentsButton5.Visibility = Visibility.Hidden;
            this.InstrumentsCheckButton5.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new InstrumentPage5());
        }

        private void InstrumentsButton6_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref instrumentValue, randomArray.IndexOf(instrumentValue, 6));
            this.InstrumentsButton6.Visibility = Visibility.Hidden;
            this.InstrumentsCheckButton6.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new InstrumentPage6());
        }

        private void ComposerCheckButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComposerPage());
        }

        private void ComposerCheckButton1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComposerPage1());
        }

        private void ComposerCheckButton2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComposerPage2());
        }

        private void ComposerCheckButton3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComposerPage3());
        }

        private void ComposerCheckButton4_Click(object sender, RoutedEventArgs e) 
        {
            NavigationService.Navigate(new ComposerPage4());
        }
        private void ComposerCheckButton5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComposerPage5());
        }

        private void ComposerCheckButton6_Click(object sender, RoutedEventArgs e) 
        {
            NavigationService.Navigate(new ComposerPage6());
        }

        private void ComposerButton_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref composerValue, randomArray.IndexOf(composerValue, 0));
            this.ComposerButton.Visibility = Visibility.Hidden;
            this.ComposerCheckButton.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new ComposerPage());
        }

        private void ComposerButton1_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref composerValue, randomArray.IndexOf(composerValue, 1));
            this.ComposerButton1.Visibility = Visibility.Hidden;
            this.ComposerCheckButton1.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new ComposerPage1());
        }

        private void ComposerButton2_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref composerValue, randomArray.IndexOf(composerValue, 2));
            this.ComposerButton2.Visibility = Visibility.Hidden;
            this.ComposerCheckButton2.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new ComposerPage2());
        }

        private void ComposerButton3_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref composerValue, randomArray.IndexOf(composerValue, 3));
            this.ComposerButton3.Visibility = Visibility.Hidden;
            this.ComposerCheckButton3.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new ComposerPage3());
        }

        private void ComposerButton4_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref composerValue, randomArray.IndexOf(composerValue, 4));
            this.ComposerButton4.Visibility = Visibility.Hidden;
            this.ComposerCheckButton4.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new ComposerPage4());
        }

        private void СomposerButton5_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref composerValue, randomArray.IndexOf(composerValue, 5));
            this.СomposerButton5.Visibility = Visibility.Hidden;
            this.ComposerCheckButton5.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new ComposerPage5());
        }

        private void ComposerButton6_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref composerValue, randomArray.IndexOf(composerValue, 6));
            this.ComposerButton6.Visibility = Visibility.Hidden;
            this.ComposerCheckButton6.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new ComposerPage6());
        }

        private void SingerCheckButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SingerPage());
        }

        private void SingerCheckButton1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SingerPage1());
        }

        private void SingerCheckButton2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SingerPage2());
        }

        private void SingerCheckButton3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SingerPage3());
        }

        private void SingerCheckButton4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SingerPage4());
        }

        private void SingerCheckButton5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SingerPage5());
        }

        private void SingerCheckButton6_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SingerPage6());
        }

        private void SingerButton_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref singerValue, randomArray.IndexOf(singerValue, 0));
            this.SingerButton.Visibility = Visibility.Hidden;
            this.SingerCheckButton.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new SingerPage());
        }

        private void SingerButton1_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref singerValue, randomArray.IndexOf(singerValue, 1));
            this.SingerButton1.Visibility = Visibility.Hidden;
            this.SingerCheckButton1.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new SingerPage1());
        }

        private void SingerButton2_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref singerValue, randomArray.IndexOf(singerValue, 2));
            this.SingerButton2.Visibility = Visibility.Hidden;
            this.SingerCheckButton2.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new SingerPage2());
        }

        private void SingerButton3_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref singerValue, randomArray.IndexOf(singerValue, 3));
            this.SingerButton3.Visibility = Visibility.Hidden;
            this.SingerCheckButton3.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new SingerPage3());
        }

        private void SingerCheckButton3_Click_1(object sender, RoutedEventArgs e)
        {
            this.SingerButton3.Visibility = Visibility.Hidden;
            this.SingerCheckButton3.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new SingerPage3());
        }

        private void SingerButton4_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref singerValue, randomArray.IndexOf(singerValue, 4));
            this.SingerButton4.Visibility = Visibility.Hidden;
            this.SingerCheckButton4.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new SingerPage4());
        }

        private void SingerButton5_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref singerValue, randomArray.IndexOf(singerValue, 5));
            this.SingerButton5.Visibility = Visibility.Hidden;
            this.SingerCheckButton5.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new SingerPage5());
        }

        private void SingerButton6_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref singerValue, randomArray.IndexOf(singerValue, 6));
            this.SingerButton6.Visibility = Visibility.Hidden;
            this.SingerCheckButton6.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new SingerPage6());
        }

        private void RusFolkCheckButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RusFolkPage());
        }

        private void RusFolkCheckButton1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RusFolkPage1());
        }

        private void RusFolkCheckButton2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RusFolkPage2());
        }

        private void RusFolkCheckButton3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RusFolkPage3());
        }

        private void RusFolkCheckButton4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RusFolkPage4());
        }

        private void RusFolkCheckButton5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RusFolkPage5());
        }

        private void RusFolkCheckButton6_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RusFolkPage6());
        }

        private void RusFolkButton_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref rusFolkValue, randomArray.IndexOf(rusFolkValue, 0));
            this.RusFolkButton.Visibility = Visibility.Hidden;
            this.RusFolkCheckButton.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new RusFolkPage());
        }

        private void RusFolkButton1_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref rusFolkValue, randomArray.IndexOf(rusFolkValue, 1));
            this.RusFolkButton1.Visibility = Visibility.Hidden;
            this.RusFolkCheckButton1.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new RusFolkPage1());
        }

        private void RusFolkButton2_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref rusFolkValue, randomArray.IndexOf(rusFolkValue, 2));
            this.RusFolkButton2.Visibility = Visibility.Hidden;
            this.RusFolkCheckButton2.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new RusFolkPage2());
        }

        private void RusFolkButton3_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref rusFolkValue, randomArray.IndexOf(rusFolkValue, 3));
            this.RusFolkButton3.Visibility = Visibility.Hidden;
            this.RusFolkCheckButton3.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new RusFolkPage3());
        }

        private void RusFolkButton4_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref rusFolkValue, randomArray.IndexOf(rusFolkValue, 4));
            this.RusFolkButton4.Visibility = Visibility.Hidden;
            this.RusFolkCheckButton4.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new RusFolkPage4());
        }

        private void RusFolkButton5_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref rusFolkValue, randomArray.IndexOf(rusFolkValue, 5));
            this.RusFolkButton5.Visibility = Visibility.Hidden;
            this.RusFolkCheckButton5.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new RusFolkPage5());
        }

        private void RusFolkButton6_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref rusFolkValue, randomArray.IndexOf(rusFolkValue, 6));
            this.RusFolkButton6.Visibility = Visibility.Hidden;
            this.RusFolkCheckButton6.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new RusFolkPage6());
        }

        private void MelodyCheckButton_Click(object sender, RoutedEventArgs e) => this.NavigationService.Navigate(new MelodyPage());

        private void MelodyCheckButton1_Click(object sender, RoutedEventArgs e) => this.NavigationService.Navigate(new MelodyPage1());

        private void MelodyCheckButton2_Click(object sender, RoutedEventArgs e) => this.NavigationService.Navigate(new MelodyPage2());

        private void MelodyCheckButton3_Click(object sender, RoutedEventArgs e) => this.NavigationService.Navigate(new MelodyPage3());

        private void MelodyCheckButton4_Click(object sender, RoutedEventArgs e) => this.NavigationService.Navigate(new MelodyPage4());

        private void MelodyCheckButton5_Click(object sender, RoutedEventArgs e) => this.NavigationService.Navigate(new MelodyPage5());

        private void MelodyCheckButton6_Click(object sender, RoutedEventArgs e) => this.NavigationService.Navigate(new MelodyPage6());

        private void MelodyButton_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref melodyValue, randomArray.IndexOf(melodyValue, 0));
            this.MelodyButton.Visibility = Visibility.Hidden;
            this.MelodyCheckButton.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new MelodyPage());
        }

        private void MelodyButton1_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref melodyValue, randomArray.IndexOf(melodyValue, 1));
            this.MelodyButton1.Visibility = Visibility.Hidden;
            this.MelodyCheckButton1.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new MelodyPage1());
        }

        private void MelodyButton2_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref melodyValue, randomArray.IndexOf(melodyValue, 2));
            this.MelodyButton2.Visibility = Visibility.Hidden;
            this.MelodyCheckButton2.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new MelodyPage2());
        }

        private void MelodyButton3_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref melodyValue, randomArray.IndexOf(melodyValue, 3));
            this.MelodyButton3.Visibility = Visibility.Hidden;
            this.MelodyCheckButton3.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new MelodyPage3());
        }

        private void MelodyButton4_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref melodyValue, randomArray.IndexOf(melodyValue, 4));
            this.MelodyButton4.Visibility = Visibility.Hidden;
            this.MelodyCheckButton4.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new MelodyPage4());
        }

        private void MelodyButton5_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref melodyValue, randomArray.IndexOf(melodyValue, 5));
            this.MelodyButton5.Visibility = Visibility.Hidden;
            this.MelodyCheckButton5.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new MelodyPage5());
        }

        private void MelodyButton6_Click(object sender, RoutedEventArgs e)
        {
            randomArray.DeleteIndexArray(ref melodyValue, randomArray.IndexOf(melodyValue, 6));
            this.MelodyButton6.Visibility = Visibility.Hidden;
            this.MelodyCheckButton6.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new MelodyPage6());
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isSound == false)
            {
                media.Pause();
                NoSound.Visibility = Visibility.Hidden;
                Sound.Visibility = Visibility.Visible;
                isSound = true;
            }           
            else if (isSound == true)
            {
                NoSound.Visibility = Visibility.Visible;
                Sound.Visibility = Visibility.Hidden;
                media.Play();
                isSound = false;
            }
        }
        private void media_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (isSound == true)
            {
                media.Play();
            }
        }

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            Instrument();           
        }
        private void Instrument()
        {
            int randomI = randomArray.Random(0, instrumentValue.Length);
            if (instrumentValue.Length == 0)
            {
                instrumentBool = true;
            }
            if (instrumentBool == false)
            {
                switch (instrumentValue[randomI])
                {
                    case 0:
                        {
                            this.InstrumentsButton.Visibility = Visibility.Hidden;
                            this.InstrumentsCheckButton.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new InstrumentsPage());
                            randomArray.DeleteIndexArray(ref instrumentValue, randomI);
                            break;
                        }
                    case 1:
                        {
                            this.InstrumentsButton1.Visibility = Visibility.Hidden;
                            this.InstrumentsCheckButton1.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new InstrumentPage1());
                            randomArray.DeleteIndexArray(ref instrumentValue, randomI);
                            break;
                        }
                    case 2:
                        {
                            this.InstrumentsButton2.Visibility = Visibility.Hidden;
                            this.InstrumentsCheckButton2.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new InstrumentPage2());
                            randomArray.DeleteIndexArray(ref instrumentValue, randomI);
                            break;
                        }
                    case 3:
                        {
                            this.InstrumentsButton3.Visibility = Visibility.Hidden;
                            this.InstrumentsCheckButton3.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new InstrumentPage3());
                            randomArray.DeleteIndexArray(ref instrumentValue, randomI);
                            break;
                        }
                    case 4:
                        {
                            this.InstrumentsButton4.Visibility = Visibility.Hidden;
                            this.InstrumentsCheckButton4.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new InstrumentPage4());
                            randomArray.DeleteIndexArray(ref instrumentValue, randomI);
                            break;
                        }
                    case 5:
                        {
                            this.InstrumentsButton5.Visibility = Visibility.Hidden;
                            this.InstrumentsCheckButton5.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new InstrumentPage5());
                            randomArray.DeleteIndexArray(ref instrumentValue, randomI);
                            break;
                        }
                    case 6:
                        {
                            this.InstrumentsButton6.Visibility = Visibility.Hidden;
                            this.InstrumentsCheckButton6.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new InstrumentPage6());
                            randomArray.DeleteIndexArray(ref instrumentValue, randomI);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        private void Composer()
        {
            int random = randomArray.Random(0, composerValue.Length);
            if (composerValue.Length == 0)
            {
                composerBool = true;
            }
            if (composerBool == false)
            {
                switch (composerValue[random])
                {
                    case 0:
                        {
                            this.ComposerButton.Visibility = Visibility.Hidden;
                            this.ComposerCheckButton.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new ComposerPage());
                            randomArray.DeleteIndexArray(ref composerValue, random);
                            break;
                        }
                    case 1:
                        {
                            this.ComposerButton1.Visibility = Visibility.Hidden;
                            this.ComposerCheckButton1.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new ComposerPage1());
                            randomArray.DeleteIndexArray(ref composerValue, random);
                            break;
                        }
                    case 2:
                        {
                            this.ComposerButton2.Visibility = Visibility.Hidden;
                            this.ComposerCheckButton2.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new ComposerPage2());
                            randomArray.DeleteIndexArray(ref composerValue, random);
                            break;
                        }
                    case 3:
                        {
                            this.ComposerButton3.Visibility = Visibility.Hidden;
                            this.ComposerCheckButton3.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new ComposerPage3());
                            randomArray.DeleteIndexArray(ref composerValue, random);
                            break;
                        }
                    case 4:
                        {
                            this.ComposerButton4.Visibility = Visibility.Hidden;
                            this.ComposerCheckButton4.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new ComposerPage4());
                            randomArray.DeleteIndexArray(ref composerValue, random);
                            break;
                        }
                    case 5:
                        {
                            this.СomposerButton5.Visibility = Visibility.Hidden;
                            this.ComposerCheckButton5.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new ComposerPage5());
                            randomArray.DeleteIndexArray(ref composerValue, random);
                            break;
                        }
                    case 6:
                        {
                            this.ComposerButton6.Visibility = Visibility.Hidden;
                            this.ComposerCheckButton6.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new ComposerPage6());
                            randomArray.DeleteIndexArray(ref composerValue, random);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        private void Singer()
        {
            int random = randomArray.Random(0, singerValue.Length);
            if (singerValue.Length == 0)
            {
                singerBool = true;
            }
            if (singerBool == false)
            {
                switch (singerValue[random])
                {
                    case 0:
                        {
                            this.SingerButton.Visibility = Visibility.Hidden;
                            this.SingerCheckButton.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new SingerPage());
                            randomArray.DeleteIndexArray(ref singerValue, random);
                            break;
                        }
                    case 1:
                        {
                            this.SingerButton1.Visibility = Visibility.Hidden;
                            this.SingerCheckButton1.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new SingerPage1());
                            randomArray.DeleteIndexArray(ref singerValue, random);
                            break;
                        }
                    case 2:
                        {
                            this.SingerButton2.Visibility = Visibility.Hidden;
                            this.SingerCheckButton2.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new SingerPage2());
                            randomArray.DeleteIndexArray(ref singerValue, random);
                            break;
                        }
                    case 3:
                        {
                            this.SingerButton3.Visibility = Visibility.Hidden;
                            this.SingerCheckButton3.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new SingerPage3());
                            randomArray.DeleteIndexArray(ref singerValue, random);
                            break;
                        }
                    case 4:
                        {
                            this.SingerButton4.Visibility = Visibility.Hidden;
                            this.SingerCheckButton4.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new SingerPage4());
                            randomArray.DeleteIndexArray(ref singerValue, random);
                            break;
                        }
                    case 5:
                        {
                            this.SingerButton5.Visibility = Visibility.Hidden;
                            this.SingerCheckButton5.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new SingerPage5());
                            randomArray.DeleteIndexArray(ref singerValue, random);
                            break;
                        }
                    case 6:
                        {
                            this.SingerButton6.Visibility = Visibility.Hidden;
                            this.SingerCheckButton6.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new SingerPage6());
                            randomArray.DeleteIndexArray(ref singerValue, random);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        private void RusFolk()
        {
            int random = randomArray.Random(0, rusFolkValue.Length);
            if (rusFolkValue.Length == 0)
            {
                rusFolkBool = true;
            }
            if (rusFolkBool == false)
            {
                switch (rusFolkValue[random])
                {
                    case 0:
                        {
                            this.RusFolkButton.Visibility = Visibility.Hidden;
                            this.RusFolkCheckButton.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new RusFolkPage());
                            randomArray.DeleteIndexArray(ref rusFolkValue, random);
                            break;
                        }
                    case 1:
                        {
                            this.RusFolkButton1.Visibility = Visibility.Hidden;
                            this.RusFolkCheckButton1.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new RusFolkPage1());
                            randomArray.DeleteIndexArray(ref rusFolkValue, random);
                            break;
                        }
                    case 2:
                        {
                            this.RusFolkButton2.Visibility = Visibility.Hidden;
                            this.RusFolkCheckButton2.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new RusFolkPage2());
                            randomArray.DeleteIndexArray(ref rusFolkValue, random);
                            break;
                        }
                    case 3:
                        {
                            this.RusFolkButton3.Visibility = Visibility.Hidden;
                            this.RusFolkCheckButton3.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new RusFolkPage3());
                            randomArray.DeleteIndexArray(ref rusFolkValue, random);
                            break;
                        }
                    case 4:
                        {
                            this.RusFolkButton4.Visibility = Visibility.Hidden;
                            this.RusFolkCheckButton4.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new RusFolkPage4());
                            randomArray.DeleteIndexArray(ref rusFolkValue, random);
                            break;
                        }
                    case 5:
                        {
                            this.СomposerButton5.Visibility = Visibility.Hidden;
                            this.RusFolkCheckButton5.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new RusFolkPage5());
                            randomArray.DeleteIndexArray(ref rusFolkValue, random);
                            break;
                        }
                    case 6:
                        {
                            this.RusFolkButton6.Visibility = Visibility.Hidden;
                            this.RusFolkCheckButton6.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new RusFolkPage6());
                            randomArray.DeleteIndexArray(ref rusFolkValue, random);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        private void Melody()
        {
            int random = randomArray.Random(0, melodyValue.Length);
            if (melodyValue.Length == 0)
            {
                melodyBool = true;
            }
            if (melodyBool == false)
            {
                switch (melodyValue[random])
                {
                    case 0:
                        {
                            this.MelodyButton.Visibility = Visibility.Hidden;
                            this.MelodyCheckButton.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new MelodyPage());
                            randomArray.DeleteIndexArray(ref melodyValue, random);
                            break;
                        }
                    case 1:
                        {
                            this.MelodyButton1.Visibility = Visibility.Hidden;
                            this.MelodyCheckButton1.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new MelodyPage1());
                            randomArray.DeleteIndexArray(ref melodyValue, random);
                            break;
                        }
                    case 2:
                        {
                            this.MelodyButton2.Visibility = Visibility.Hidden;
                            this.MelodyCheckButton2.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new MelodyPage2());
                            randomArray.DeleteIndexArray(ref melodyValue, random);
                            break;
                        }
                    case 3:
                        {
                            this.MelodyButton3.Visibility = Visibility.Hidden;
                            this.MelodyCheckButton3.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new MelodyPage3());
                            randomArray.DeleteIndexArray(ref melodyValue, random);
                            break;
                        }
                    case 4:
                        {
                            this.MelodyButton4.Visibility = Visibility.Hidden;
                            this.MelodyCheckButton4.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new MelodyPage4());
                            randomArray.DeleteIndexArray(ref melodyValue, random);
                            break;
                        }
                    case 5:
                        {
                            this.СomposerButton5.Visibility = Visibility.Hidden;
                            this.MelodyCheckButton5.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new MelodyPage5());
                            randomArray.DeleteIndexArray(ref melodyValue, random);
                            break;
                        }
                    case 6:
                        {
                            this.MelodyButton6.Visibility = Visibility.Hidden;
                            this.MelodyCheckButton6.Visibility = Visibility.Visible;
                            this.NavigationService.Navigate(new MelodyPage6());
                            randomArray.DeleteIndexArray(ref melodyValue, random);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        private void Random1_Click(object sender, RoutedEventArgs e)
        {
            Composer();
        }
        private void Random2_Click(object sender, RoutedEventArgs e)
        {
            Singer();
        }

        private void Random3_Click(object sender, RoutedEventArgs e)
        {
            RusFolk();
        }

        private void Random4_Click(object sender, RoutedEventArgs e)
        {
            Melody();
        }

        private void RandomFull_Click(object sender, RoutedEventArgs e)
        {
            float random = randomArray.Random(0, 4);
            switch (random)
            {
                case 0:
                    Instrument();
                    break;
                case 1:
                    Composer();
                    break;
                case 2:
                    Singer();   
                    break;
                case 3:
                    RusFolk();
                    break;
                case 4:
                    Melody();
                    break;
            }
        }
    }
}

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
using System.Windows.Threading;

namespace музыка
{
    /// <summary>
    /// Логика взаимодействия для MelodyPage.xaml
    /// </summary>
    public partial class MelodyPage3 : Page
    {
        bool isDragging = false;
        bool isButton = false;
        bool isPause = false;
        bool isEnded = false;
        TimeSpan _position;
        DispatcherTimer _timer = new DispatcherTimer();
        public MelodyPage3()
        {
            InitializeComponent();
            _timer.Interval = TimeSpan.FromMilliseconds(1000);
            _timer.Tick += new EventHandler(ticktock);
            _timer.Start();
        }
        void ticktock(object sender, EventArgs e)
        {
            if (!isDragging)
            {
                Progress.Value = MediaElement1.Position.TotalSeconds;
            }
        }
        private void media_MediaOpened(object sender, RoutedEventArgs e)
        {
            _position = MediaElement1.NaturalDuration.TimeSpan;
            Progress.Maximum = _position.TotalSeconds;
        }
        private void Close_MouseDown(object sender, MouseButtonEventArgs e) => Application.Current.MainWindow.Close();

        private void Min_MouseDown(object sender, MouseButtonEventArgs e) => Application.Current.MainWindow.WindowState = WindowState.Minimized;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isPause == false)
            {
                MediaElement1.Play();
                Play.Visibility = Visibility.Hidden;
                Pause.Visibility = Visibility.Visible;
                isPause = true;
                isButton = true;
            }
            else if (isPause == true & isEnded == true)
            {
                Pause.Visibility = Visibility.Hidden;
                Play.Visibility = Visibility.Visible;
                MediaElement1.Stop();
                isPause = false;
                isButton = true;
                isEnded = false;
            }
            else if (isPause == true)
            {
                Play.Visibility = Visibility.Visible;
                Pause.Visibility = Visibility.Hidden;
                MediaElement1.Pause();
                isPause = false;
                isButton = false;
            }
        }
        private void Progress_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            if (isButton == false)
            {
                Progress.Value = 0;
            }
            isDragging = false;
            MediaElement1.Position = TimeSpan.FromSeconds(Progress.Value);
        }

        private void Progress_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            isDragging = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Text.Visibility = Visibility.Visible;
            Img.Visibility = Visibility.Visible;
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void MediaElement1_MediaEnded(object sender, RoutedEventArgs e)
        {
            isEnded = true;
        }
    }
}

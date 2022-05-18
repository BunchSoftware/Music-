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

namespace музыка
{
    public partial class InstrumentsPage : Page
    {
        public InstrumentsPage()
        {
            InitializeComponent();
        }
        private void Close_MouseDown(object sender, MouseButtonEventArgs e) => Application.Current.MainWindow.Close();

        private void Min_MouseDown(object sender, MouseButtonEventArgs e) => Application.Current.MainWindow.WindowState = WindowState.Minimized;

        private void Button_Click(object sender, RoutedEventArgs e) => this.NavigationService.GoBack();

        private void Button_Click_1(object sender, RoutedEventArgs e) => this.NavigationService.Navigate(new False());

        private void Button_Click_2(object sender, RoutedEventArgs e) => this.NavigationService.Navigate(new True());

        private void Button_Click_3(object sender, RoutedEventArgs e) => this.NavigationService.Navigate(new False());
    }
}

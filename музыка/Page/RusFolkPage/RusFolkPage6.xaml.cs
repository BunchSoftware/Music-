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
    /// <summary>
    /// Логика взаимодействия для RusFolkPage.xaml
    /// </summary>
    public partial class RusFolkPage6 : Page
    {
        public RusFolkPage6()
        {
            InitializeComponent();
        }
        private void Close_MouseDown(object sender, MouseButtonEventArgs e) => Application.Current.MainWindow.Close();

        private void Min_MouseDown(object sender, MouseButtonEventArgs e) => Application.Current.MainWindow.WindowState = WindowState.Minimized;

        private void Button_Click(object sender, RoutedEventArgs e) => this.NavigationService.Navigate((object)new False());

        private void Button_Click_1(object sender, RoutedEventArgs e) => this.NavigationService.Navigate((object)new False());

        private void Button_Click_2(object sender, RoutedEventArgs e) => this.NavigationService.Navigate((object)new True());
    }
}

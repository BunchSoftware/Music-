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
    /// Логика взаимодействия для False.xaml
    /// </summary>
    public partial class False : Page
    {
        public False()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
            this.NavigationService.GoBack();
        }

        private void Close_MouseDown(object sender, MouseButtonEventArgs e) => Application.Current.MainWindow.Close();

        private void Min_MouseDown(object sender, MouseButtonEventArgs e) => Application.Current.MainWindow.WindowState = WindowState.Minimized;
    }
}

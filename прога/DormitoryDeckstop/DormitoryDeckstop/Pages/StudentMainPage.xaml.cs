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

namespace DormitoryDeckstop.Pages
{
    /// <summary>
    /// Логика взаимодействия для StudentMainPage.xaml
    /// </summary>
    public partial class StudentMainPage : Page
    {
        public StudentMainPage()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void watch_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WatchPage());
        }

        private void student_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StudentsWatchPage());
        }
    }
}

using DormitoryDeckstop.Class;
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
    /// Логика взаимодействия для WatchPage.xaml
    /// </summary>
    public partial class WatchPage : Page
    {
        public WatchPage()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = dbContext.db.Watch.ToList();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            datagrid.ItemsSource = dbContext.db.Watch.Where(item => item.Janitor.JanitorName.Contains(search.Text)).ToList();
        }
    }
}

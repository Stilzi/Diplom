using DormitoryDeckstop.Class;
using DormitoryDeckstop.Model;
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
    /// Логика взаимодействия для JanitorPage.xaml
    /// </summary>
    public partial class JanitorPage : Page
    {
        public JanitorPage()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            Janitor removejanitor = (Janitor)janitordatagrid.SelectedItem;
            dbContext.db.Janitor.Remove(removejanitor);
            dbContext.db.SaveChanges();
            janitordatagrid.ItemsSource = dbContext.db.Janitor.ToList();
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            Janitor janitor = (Janitor)janitordatagrid.SelectedItem;
            if (janitor != null)
            {
                NavigationService.Navigate(new UpdateJanitorPage(janitor));
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            janitordatagrid.ItemsSource = dbContext.db.Janitor.ToList();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            janitordatagrid.ItemsSource = dbContext.db.Janitor.Where(item => item.JanitorName.Contains(search.Text)).ToList();
        }
    }
}

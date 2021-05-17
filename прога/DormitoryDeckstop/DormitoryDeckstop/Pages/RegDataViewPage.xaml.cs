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
    /// Логика взаимодействия для RegDataViewPage.xaml
    /// </summary>
    public partial class RegDataViewPage : Page
    {
        public RegDataViewPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            userdatagrid.ItemsSource = dbContext.db.Registration.ToList();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            Registration remove = (Registration)userdatagrid.SelectedItem;
            dbContext.db.Registration.Remove(remove);
            dbContext.db.SaveChanges();
            userdatagrid.ItemsSource = dbContext.db.Registration.ToList();
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            Registration user = (Registration)userdatagrid.SelectedItem;
            if (user != null)
            {
                NavigationService.Navigate(new UpdateUserPage(user));
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            userdatagrid.ItemsSource = dbContext.db.Registration.Where(item => item.Login.Contains(search.Text)).ToList();
        }
    }
}

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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();

            role.ItemsSource = dbContext.db.Role.Select(item => item.Role1).ToList();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            var insertrole = dbContext.db.Role.FirstOrDefault(item => item.Role1 == role.Text);
            Registration reg = new Registration()
            {
                RoleId = insertrole.Id,
                Login = txbEmail.Text,
                Password = txbPassword.Password
            };
            dbContext.db.Registration.Add(reg);
            dbContext.db.SaveChanges();
            MessageBox.Show("Вы зарегестрировали пользователя", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            txbEmail.Clear();
            txbPassword.Clear();
        }

        private void table_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegDataViewPage());
        }
    }
}

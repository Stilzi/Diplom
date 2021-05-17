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
    /// Логика взаимодействия для UpdateUserPage.xaml
    /// </summary>
    public partial class UpdateUserPage : Page
    {
        private Registration selecteditem;
        public UpdateUserPage(Registration selecteditem)
        {
            InitializeComponent();
            this.selecteditem = selecteditem;
            txbEmail.Text = selecteditem.Login;
            txbPassword.Text = selecteditem.Password;
            role.ItemsSource = dbContext.db.Role.Select(item => item.Role1).ToList();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            var userupdate = dbContext.db.Registration.FirstOrDefault(Item => Item.Id == selecteditem.Id);
            userupdate.Role.Role1 = role.Text;
            userupdate.Login = txbEmail.Text;
            userupdate.Password = txbPassword.Text;
            dbContext.db.SaveChanges();

            MessageBox.Show("Данные отредактированы", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

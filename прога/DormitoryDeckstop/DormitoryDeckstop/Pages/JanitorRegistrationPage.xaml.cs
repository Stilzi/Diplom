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
    /// Логика взаимодействия для JanitorRegistrationPage.xaml
    /// </summary>
    public partial class JanitorRegistrationPage : Page
    {
        public JanitorRegistrationPage()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            Janitor janitorinsert = new Janitor()
            {
                JanitorName = txbEmail.Text
            };
            dbContext.db.Janitor.Add(janitorinsert);
            dbContext.db.SaveChanges();
            MessageBox.Show("Вахтер добавлен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            txbEmail.Clear();
        }

        private void table_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new JanitorPage());
        }
    }
}

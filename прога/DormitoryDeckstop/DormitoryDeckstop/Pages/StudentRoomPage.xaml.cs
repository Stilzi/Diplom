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
    /// Логика взаимодействия для StudentRoomPage.xaml
    /// </summary>
    public partial class StudentRoomPage : Page
    {
        public StudentRoomPage()
        {
            InitializeComponent();

            cmbGroup.ItemsSource = dbContext.db.Group.Select(item => item.NumberGroup).ToList();
            cmbRoom.ItemsSource = dbContext.db.Rooms.Select(item => item.Number).ToList();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            var cmbGroupinsert = dbContext.db.Group.FirstOrDefault(item => item.NumberGroup == cmbGroup.Text);
            var cmbRoomsinsert = dbContext.db.Rooms.FirstOrDefault(item => item.Number == cmbRoom.Text);

            Students insert = new Students() {
                Name = txbEmail.Text,
                IdRoom = cmbRoomsinsert.Id,
                IdGroup = cmbGroupinsert.Id
            };
            dbContext.db.Students.Add(insert);
            dbContext.db.SaveChanges();
            MessageBox.Show("Студент заселен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void table_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StudentsTablePage());
        }
    }
}

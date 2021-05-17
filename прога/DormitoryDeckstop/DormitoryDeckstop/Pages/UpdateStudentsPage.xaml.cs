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
    /// Логика взаимодействия для UpdateStudentsPage.xaml
    /// </summary>
    public partial class UpdateStudentsPage : Page
    {
        private Students selecteditem;
        public UpdateStudentsPage(Students selecteditem)
        {
            InitializeComponent();
            this.selecteditem = selecteditem;
            txbEmail.Text = selecteditem.Name;
            cmbGroup.ItemsSource = dbContext.db.Group.Select(item => item.NumberGroup).ToList();
            cmbRoom.ItemsSource = dbContext.db.Rooms.Select(item => item.Number).ToList();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            var studentsupdate = dbContext.db.Students.FirstOrDefault(item => item.Id == selecteditem.Id);
            studentsupdate.Group.NumberGroup = cmbGroup.Text;
            studentsupdate.Rooms.Number = cmbRoom.Text;
            studentsupdate.Name = txbEmail.Text;
            dbContext.db.SaveChanges();

            MessageBox.Show("Данные отредактированы", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

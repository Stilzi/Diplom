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
    /// Логика взаимодействия для StudentsTablePage.xaml
    /// </summary>
    public partial class StudentsTablePage : Page
    {
        public StudentsTablePage()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            Students remove = (Students)datagrid.SelectedItem;
            dbContext.db.Students.Remove(remove);
            dbContext.db.SaveChanges();
            datagrid.ItemsSource = dbContext.db.Students.ToList();
            MessageBox.Show("Студент выселен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = dbContext.db.Students.ToList();
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            Students study = (Students)datagrid.SelectedItem;
            if(study != null)
            {
                NavigationService.Navigate(new UpdateStudentsPage(study));
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            datagrid.ItemsSource = dbContext.db.Students.Where(item => item.Name.Contains(search.Text)).ToList();
        }
    }
}

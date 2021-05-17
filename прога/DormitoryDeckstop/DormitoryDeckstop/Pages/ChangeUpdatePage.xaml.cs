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
    /// Логика взаимодействия для ChangeUpdatePage.xaml
    /// </summary>
    public partial class ChangeUpdatePage : Page
    {
        private Watch selecteditem;
        public ChangeUpdatePage(Watch selecteditem)
        {
            InitializeComponent();

            this.selecteditem = selecteditem;
            cmbjanitor.ItemsSource = dbContext.db.Janitor.Select(item => item.JanitorName).ToList();
            cmbTime.ItemsSource = dbContext.db.Change.Select(item => item.ChangeTime).ToList();
            cmbFloor.ItemsSource = dbContext.db.Floor.Select(item => item.FloorNumber).ToList();
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            var update = dbContext.db.Watch.FirstOrDefault(item => item.Id == selecteditem.Id);
            update.Janitor.JanitorName = cmbjanitor.Text;
            update.Floor.FloorNumber = Convert.ToInt32(cmbFloor.Text);
            update.Change.ChangeTime = cmbTime.Text;
            dbContext.db.SaveChanges();

            MessageBox.Show("Данные отредактированы", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}

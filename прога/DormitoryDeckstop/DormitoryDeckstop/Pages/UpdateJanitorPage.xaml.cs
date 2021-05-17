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
    /// Логика взаимодействия для UpdateJanitorPage.xaml
    /// </summary>
    public partial class UpdateJanitorPage : Page
    {
        private Janitor selecteditem;
        public UpdateJanitorPage(Janitor selecteditem)
        {
            InitializeComponent();
            this.selecteditem = selecteditem;
            txbEmail.Text = selecteditem.JanitorName;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            var updatejanitor = dbContext.db.Janitor.FirstOrDefault(Item => Item.Id == selecteditem.Id);
            updatejanitor.JanitorName = txbEmail.Text;
            MessageBox.Show("Данные отредактированны", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

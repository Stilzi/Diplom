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
    /// Логика взаимодействия для ChangePage.xaml
    /// </summary>
    public partial class ChangePage : Page
    {
        public ChangePage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = dbContext.db.Watch.ToList();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            Watch watch = (Watch)datagrid.SelectedItem;
            if (watch != null)
            {
                NavigationService.Navigate(new ChangeUpdatePage(watch));
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

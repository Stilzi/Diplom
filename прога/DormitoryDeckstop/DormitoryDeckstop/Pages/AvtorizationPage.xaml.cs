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
    /// Логика взаимодействия для AvtorizationPage.xaml
    /// </summary>
    public partial class AvtorizationPage : Page
    {
        public AvtorizationPage()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }

        private void Avtorization_Click(object sender, RoutedEventArgs e)
        {
            var avtorization = dbContext.db.Registration.FirstOrDefault(item => item.Login == txbEmail.Text && item.Password == txbPassword.Password);

                if (avtorization == null)
            {
                MessageBox.Show("Вы ввели неверные данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                txbEmail.Clear();
                txbPassword.Clear();
            }
            else
            {
                if (avtorization.RoleId == 1)
                { 
                    MessageBox.Show("Вы авторизовались как админ", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new AdminMainPage());
                    txbEmail.Clear();
                    txbPassword.Clear();
                }
                else
                {
                    if (avtorization.RoleId == 2)
                    {
                        MessageBox.Show("Вы авторизовались как вахтерша", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                        NavigationService.Navigate(new WatchMainPage());
                        txbEmail.Clear();
                        txbPassword.Clear();
                    }
                        else
                        {
                            MessageBox.Show("Вы авторизовались как студент", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                            NavigationService.Navigate(new StudentMainPage());
                            txbEmail.Clear();
                            txbPassword.Clear();
                    }
                }
            }
        }

        }
    }

using CRB.AppData;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace CRB.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddStafForm.xaml
    /// </summary>
    public partial class AddStafForm : Page
    {
        static Users users;
        public AddStafForm(Users userss)
        {
            InitializeComponent();
            DataContext = users = userss is null ? new Users() : userss;
            RoleCmb.ItemsSource = ConnectDB.GetCont().Role.ToList();
            OtdelCmb.ItemsSource = ConnectDB.GetCont().Departments.ToList();
        }

        private void OtdelCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RoleCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.frame.GoBack();
        }

        private void AddStaffBtn_Click(object sender, RoutedEventArgs e)
        {
            if (users.id_user == 0)
                ConnectDB.GetCont().Users.Add(users);
            try
            {
                ConnectDB.GetCont().SaveChanges();
                MessageBox.Show("Данные сохранены!");
                Nav.frame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка сохранения!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelBtn_Click_1(object sender, RoutedEventArgs e)
        {
            Nav.frame.GoBack();
        }
    }
}

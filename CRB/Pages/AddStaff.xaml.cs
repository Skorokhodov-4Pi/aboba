using CRB.AppData;
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

namespace CRB.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddStaff.xaml
    /// </summary>
    public partial class AddStaff : Page
    {
        public AddStaff()
        {
            InitializeComponent();
            Update();
            CmbFilterRole.ItemsSource = new string[]
            {
                "Все",
                "Админ",
                "Врач",
                "Cтаршая медицинская сестра",
                "Медицинская сестра"
            };
            

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Update();
            
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            Right.editUsers = (sender as Button).DataContext as Users;
            Nav.frame.Navigate(new EditStaff());
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.frame.GoBack();
        }
        void Update()
        {
            if(CmbFilterRole.SelectedIndex == 0)
            {
                var up = ConnectDB.GetCont().Users.ToList();
                AddStaffLV.ItemsSource = up;
            }
            else if (CmbFilterRole.SelectedIndex == 1)
            {
                var up = ConnectDB.GetCont().Users.ToList();
                up = up.Where(x => x.Role.id_role == 1).ToList();
                AddStaffLV.ItemsSource = up;
            }
            else if (CmbFilterRole.SelectedIndex == 2)
            {
                var up = ConnectDB.GetCont().Users.ToList();
                up = up.Where(x => x.Role.id_role == 2).ToList();
                AddStaffLV.ItemsSource = up;
            }
            else if (CmbFilterRole.SelectedIndex == 3)
            {
                var up = ConnectDB.GetCont().Users.ToList();
                up = up.Where(x => x.Role.id_role == 3).ToList();
                AddStaffLV.ItemsSource = up;
            }
            else if (CmbFilterRole.SelectedIndex == 4)
            {
                var up = ConnectDB.GetCont().Users.ToList();
                up = up.Where(x => x.Role.id_role == 4).ToList();
                AddStaffLV.ItemsSource = up;
            }
            
        }

        private void CmbFilterRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Nav.frame.Navigate(new AddStafForm(null));
        }
    }
}

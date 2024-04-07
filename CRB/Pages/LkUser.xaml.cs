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
    /// Логика взаимодействия для LkUser.xaml
    /// </summary>
    public partial class LkUser : Page
    {
        public LkUser()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PLV.ItemsSource = new List<Users> { Right.curUser };
            PLV2.ItemsSource = new List<Users> { Right.curUser };
            PLV3.ItemsSource = new List<Users> { Right.curUser };

        }
    }
}

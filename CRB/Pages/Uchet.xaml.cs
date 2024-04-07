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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace CRB.Pages
{
    /// <summary>
    /// Логика взаимодействия для Uchet.xaml
    /// </summary>
   
    public partial class Uchet : Page
    {
        Users curUser = Right.curUser;
        public Uchet()
        {
            InitializeComponent();
            Update();
            CmbFilter.ItemsSource = new string[]
            {
                "Все",
                "Выписан",
                "Переведен на другой профиль коек",
                "Переведен в другое ЛПУ",
                "Смерть"
            };
        }

        void Update()
        {
            if (CmbFilter.SelectedIndex == 0)
            {
                var up = ConnectDB.GetCont().Electronic_medical_card.ToList();
                PacLV.ItemsSource = up;
            }
            else if (CmbFilter.SelectedIndex == 1)
            {
                var up = ConnectDB.GetCont().Electronic_medical_card.ToList();
                up = up.Where(x => x.id_outcomes == 1).ToList();
                PacLV.ItemsSource = up;
            }
            else if (CmbFilter.SelectedIndex == 2)
            {
                var up = ConnectDB.GetCont().Electronic_medical_card.ToList();
                up = up.Where(x => x.id_outcomes == 2).ToList();
                PacLV.ItemsSource = up;
            }
            else if (CmbFilter.SelectedIndex == 3)
            {
                var up = ConnectDB.GetCont().Electronic_medical_card.ToList();
                up = up.Where(x => x.id_outcomes == 3).ToList();
                PacLV.ItemsSource = up;
            }
            else if (CmbFilter.SelectedIndex == 4)
            {
                var up = ConnectDB.GetCont().Electronic_medical_card.ToList();
                up = up.Where(x => x.id_outcomes == 4).ToList();
                PacLV.ItemsSource = up;
            }

     
            
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            CurElMedCard.card = (sender as Button).DataContext as Electronic_medical_card;
            Nav.frame.Navigate(new UchetEdit());
        }


        private void SearchTxt_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            var mat = ConnectDB.GetCont().Electronic_medical_card.ToList();
            mat = mat.Where(x => x.Patient.Surname.Contains(SearchTxt.Text)).ToList();
            PacLV.ItemsSource = mat;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void OtchetBtn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;

            //Новая книга
            Microsoft.Office.Interop.Excel.Workbook wb = excel.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet ws = wb.Sheets[1];

            //Заголовки
            ws.Cells[1, 1] = "Фамилия";
            ws.Cells[1, 1].Font.Bold = true;
            ws.Cells[1, 2] = "Имя";
            ws.Cells[1, 2].Font.Bold = true;
            ws.Cells[1, 3] = "Отчество";
            ws.Cells[1, 3].Font.Bold = true;
            ws.Cells[1, 4] = "Дата рождения";
            ws.Cells[1, 4].Font.Bold = true;
            ws.Cells[1, 5] = "Дата поступления";
            ws.Cells[1, 5].Font.Bold = true;
            ws.Cells[1, 6] = "Диагноз";
            ws.Cells[1, 6].Font.Bold = true;


            int row = 2;
            foreach (var item in PacLV.Items)
            {
                dynamic otchet = item;

                ws.Cells[row, 1] = otchet.Patient.Surname;
                ws.Cells[row, 2] = otchet.Patient.First_name;
                ws.Cells[row, 3] = otchet.Patient.Patronymic;
                ws.Cells[row, 4] = otchet.Patient.date_of_birth;
                ws.Cells[row, 5] = otchet.date_receipt;
                List<string> m = new List<string>();
                foreach (var a in otchet.MKB)
                {
                    m.Add(a.name_diagnosis);
                }
                ws.Cells[row, 6] = string.Join(", ", m);
                row++;

            }
            ws.Cells[row, 1] = "Кол-во пациентов:";
            ws.Cells[row, 1].Font.Bold = true;
            ws.Cells[row, 6] = row - 2;
        }

        private void CmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.frame.GoBack();
        }
    }
}

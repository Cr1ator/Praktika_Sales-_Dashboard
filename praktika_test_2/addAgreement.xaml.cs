using praktika_test_2.UserControls;
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
using System.Windows.Shapes;

namespace praktika_test_2
{
    /// <summary>
    /// Логика взаимодействия для addAgreement.xaml
    /// </summary>
    public partial class addAgreement : Window
    {
        public addAgreement()
        {
            InitializeComponent();
        }

        private string _username;

        //public string Username
        //{
        //    get { return _username; }
        //    set { _username = value; OnPropertyChanged(nameof(CodeAgreement)); }
        //}

        //private void MyTextBox_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    MyTextBox.Text = string.Empty;
        //}

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void SaveAgreement_Click(object sender, RoutedEventArgs e)
        {
            //Получить значения полей
            var codeAgreement = ((MyTextBox)this.FindName("CodeAgreement")).textBox.Text;
            var numberAgreement = ((MyTextBox)this.FindName("NumberAgreement")).textBox.Text;

            var _dateAgreement = DateAgreement.SelectedDate;
            var _dateSrokAgreement = DateSrokAgreement.SelectedDate;
            var _dateEndAgreement = DateEndAgreement.SelectedDate;

            var nameAgreement = ((MyTextBox)this.FindName("NameAgreement")).textBox.Text;
            var countryAgreement = ((MyTextBox)this.FindName("CountryAgreement")).textBox.Text;
            var areaAgreement = ((MyTextBox)this.FindName("AreaAgreement")).textBox.Text;

            var typeAgreement = ((MyTextBox)this.FindName("TypeAgreement")).textBox.Text;
            var relationshipsAgreement = ((MyTextBox)this.FindName("RelationshipsAgreement")).textBox.Text;
            var statusMMZAgreement = ((MyTextBox)this.FindName("StatusMMZAgreement")).textBox.Text;
            var statusAgreement = ((MyTextBox)this.FindName("StatusAgreement")).textBox.Text;

            var sumAgreement = ((MyTextBox)this.FindName("SumAgreement")).textBox.Text;
            var countsAgreement = ((MyTextBox)this.FindName("CountsAgreement")).textBox.Text;
            var sumTransAgreement = ((MyTextBox)this.FindName("SumTransAgreement")).textBox.Text;
            var nameProduct = ((MyTextBox)this.FindName("NameProduct")).textBox.Text;

            var typePayement = ((MyTextBox)this.FindName("TypePayement")).textBox.Text;
            var datePayement = ((MyTextBox)this.FindName("DatePayement")).textBox.Text;
            var dayAgreement = ((MyTextBox)this.FindName("DayAgreement")).textBox.Text;
            var dateOfShipment = ((MyTextBox)this.FindName("DateOfShipment")).textBox.Text;

            //получение времени c utc
            DateTime _dateAgreement_utc = DateTime.SpecifyKind(_dateAgreement.Value, DateTimeKind.Utc);
            DateTime _dateSrokAgreement_utc = DateTime.SpecifyKind(_dateSrokAgreement.Value, DateTimeKind.Utc);
            DateTime _dateEndAgreement_utc = DateTime.SpecifyKind(_dateEndAgreement.Value, DateTimeKind.Utc);

            using (ApplicationContext db = new ApplicationContext())
            {
                Agreement agreement = new Agreement {
                    codeAgreement = Convert.ToInt32(codeAgreement),
                    numberAgreement = Convert.ToInt32(numberAgreement),
                    dateAgreement = _dateAgreement_utc,
                    dateSrokAgreement = _dateSrokAgreement_utc,
                    dateEndAgreement = _dateEndAgreement_utc,
                    nameAgreement = nameAgreement,
                    countryAgreement = countryAgreement,
                    areaAgreement = areaAgreement,
                    typeAgreement = typeAgreement,
                    relationshipsAgreement = relationshipsAgreement,
                    statusMMZAgreement = statusMMZAgreement,
                    statusAgreement = statusAgreement,
                    sumAgreement = Convert.ToInt32(sumAgreement),
                    countsAgreement = Convert.ToInt32(countsAgreement),
                    sumTransAgreement = Convert.ToInt32(sumTransAgreement),
                    nameProduct = nameProduct,
                    typePayement = Convert.ToInt32(typePayement),
                    dayDatePayement = Convert.ToInt32(datePayement),
                    dayAgreement = Convert.ToInt32(dayAgreement),
                    dayDateOfShipment = Convert.ToInt32(dateOfShipment) 
                };

                // добавляем в бд
                db.Agreement.Add(agreement);
                ((MainWindow)System.Windows.Application.Current.MainWindow).AddAgreement(agreement);
                db.SaveChanges();


                MessageBox.Show("Договор успешно добавлен");
            }
        }

        //закрытие модального окна
        private void CancelAgreement_Click(object sender, RoutedEventArgs e) => Close();

        //Свернуть окно
        private void hideAgreement_Click(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;

        private void TestAgreement_Click(object sender, RoutedEventArgs e)
        {
            //if (e.ChangedButton == MouseButton.Left)
            //{
            //    this.DragMove();
            //}
        }
    }
}

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
    /// Логика взаимодействия для viewingAgreement.xaml
    /// </summary>
    public partial class viewingAgreement : Window
    {
        private int _selectIndex;

        public int SelectIndex
        {
            get { return _selectIndex; }
            set { _selectIndex = value; }
        }

        public viewingAgreement()
        {
            InitializeComponent();
            try
            {
                var agreement = ((MainWindow)System.Windows.Application.Current.MainWindow).Agreement;
                SelectIndex = ((MainWindow)System.Windows.Application.Current.MainWindow).GetSelectIndex();
                codeAgreement.Text = agreement[SelectIndex].codeAgreement.ToString();
                numberAgreement.Text = agreement[SelectIndex].numberAgreement.ToString();

                _dateAgreement.Text = agreement[SelectIndex].dateAgreement.ToString().Substring(0, 11);
                _dateSrokAgreement.Text = agreement[SelectIndex].dateSrokAgreement.ToString().Substring(0, 11);
                _dateEndAgreement.Text = agreement[SelectIndex].dateEndAgreement.ToString().Substring(0, 11);

                nameAgreement.Text = agreement[SelectIndex].nameAgreement.ToString();
                countryAgreement.Text = agreement[SelectIndex].countryAgreement.ToString();
                areaAgreement.Text = agreement[SelectIndex].areaAgreement.ToString();

                typeAgreement.Text = agreement[SelectIndex].typeAgreement.ToString();
                relationshipsAgreement.Text = agreement[SelectIndex].relationshipsAgreement.ToString();
                statusMMZAgreement.Text = agreement[SelectIndex].statusMMZAgreement.ToString();
                statusAgreement.Text = agreement[SelectIndex].statusAgreement.ToString();

                sumAgreement.Text = agreement[SelectIndex].sumAgreement.ToString();
                countsAgreement.Text = agreement[SelectIndex].countsAgreement.ToString();
                sumTransAgreement.Text = agreement[SelectIndex].sumTransAgreement.ToString();
                nameProduct.Text = agreement[SelectIndex].nameProduct.ToString();

                typePayement.Text = agreement[SelectIndex].typePayement.ToString();
                dayDatePayement.Text = agreement[SelectIndex].dayDatePayement.ToString();
                dayAgreement.Text = agreement[SelectIndex].dayAgreement.ToString();
                dayDateOfShipment.Text = agreement[SelectIndex].dayDateOfShipment.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка просмотра");
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void RedactAgreement_Click(object sender, RoutedEventArgs e) 
        {
            Close();
            var agreement = ((MainWindow)System.Windows.Application.Current.MainWindow).Agreement[SelectIndex];
            ((MainWindow)System.Windows.Application.Current.MainWindow).RedactAgreement(agreement);
        }

        //закрытие модального окна
        private void CancelAgreement_Click(object sender, RoutedEventArgs e) => Close();

        //Свернуть окно
        private void hideAgreement_Click(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;

        private void DeleteAgreement_Click(object sender, RoutedEventArgs e)
        {
            var agreement = ((MainWindow)System.Windows.Application.Current.MainWindow).Agreement[SelectIndex];
            ((MainWindow)System.Windows.Application.Current.MainWindow).DeleteAgreement(agreement);
            Close();
        }
    }
}

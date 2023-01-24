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
            //if (e.ChangedButton == MouseButton.Left)
            //{
            //    this.DragMove();
            //}
        }

        private void CancelAgreement_Click(object sender, RoutedEventArgs e)
        {
            //if (e.ChangedButton == MouseButton.Left)
            //{
            //    this.DragMove();
            //}
        }
        
        private void TestAgreement_Click(object sender, RoutedEventArgs e)
        {
            //if (e.ChangedButton == MouseButton.Left)
            //{
            //    this.DragMove();
            //}
        }
    }
}

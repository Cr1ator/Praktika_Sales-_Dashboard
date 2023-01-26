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

namespace praktika_test_2.ViewWindow
{
    /// <summary>
    /// Логика взаимодействия для banWindow.xaml
    /// </summary>
    public partial class banWindow : Window
    {
        public banWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        //закрытие модального окна
        private void CancelAgreement_Click(object sender, RoutedEventArgs e) => Close();

        //Свернуть окно
        private void hideAgreement_Click(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;
    }
}

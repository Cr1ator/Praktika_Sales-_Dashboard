using Microsoft.VisualBasic.ApplicationServices;
using praktika_test_2.ViewWindow;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace praktika_test_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Agreement> _agreement;

        public List<Agreement> Agreement
        {
            get { return _agreement; }
            set { _agreement = value;}
        }

        public MainWindow()
        {
            InitializeComponent();

            using (ApplicationContext db = new ApplicationContext())
            {

                // создаем два объекта User
                //User user1 = new User { Name = "Tom", Age = 33 };
                //User user2 = new User { Name = "Alice", Age = 26 };

                // добавляем их в бд
                //db.Users.AddRange(user1, user2);
                //db.SaveChanges();

                Agreement = db.Agreement.ToList();
                membersDataGrid.ItemsSource = Agreement;
            }
        }
        public int GetSelectIndex()
        {
            return membersDataGrid.SelectedIndex;
        }

        public void AddAgreement(Agreement agreement)
        {
            Agreement.Add(agreement);
            membersDataGrid.Items.Refresh();
        }
        public void UpdateAgreement(Agreement agreement)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Agreement[membersDataGrid.SelectedIndex] = agreement;
                db.Agreement.Update(agreement);
                db.SaveChanges();
                membersDataGrid.Items.Refresh();
            }
        }

        public void RedactAgreement(Agreement agreement)
        {
            addAgreement addAgreement = new addAgreement();
            addAgreement.Show();
            addAgreement.GetRedactAgreement(agreement);
            //var a = viewingAgreement_win.SelectIndex;
            //var b = ((viewingAgreement)System.Windows.Application.Current.viewingAgreement).SelectIndex;
            //MessageBox.Show(membersDataGrid.SelectedIndex.ToString());
        }

        private void CancelAgreement_Click(object sender, RoutedEventArgs e) => Close();

        private void No_Click(object sender, RoutedEventArgs e)
        {
            banWindow bW = new banWindow();
            bW.ShowDialog();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //if (e.ChangedButton==MouseButton.Left) 
            //{ 
            //    this.DragMove();
            //}
        }

        bool IsMaximized = false;

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //if (e.ClickCount == 2)
            //{
            //    if (this.IsMaximized)
            //    {
            //        this.WindowState = WindowState.Normal;
            //        this.Width = 1280;
            //        this.Height = 780;

            //        this.IsMaximized = false;
            //    }
            //    else
            //    {
            //        this.WindowState= WindowState.Maximized;

            //        this.IsMaximized = true;
            //    }
            //}
        }

        private void AddAgreement_Click(object sender, RoutedEventArgs e)
        {
            addAgreement addAgreement = new addAgreement();
            addAgreement.Show();
        }
        public void DeleteAgreement(Agreement select_agreement)
        {
            Agreement.Remove((Agreement)select_agreement);
            using (ApplicationContext db = new ApplicationContext())
            {
                //Удаление
                db.Agreement.Remove((Agreement)select_agreement);
                db.SaveChanges();
            }
            membersDataGrid.Items.Refresh();
        }
        private void RedactAgreement_Click(object sender, RoutedEventArgs e)
        {
            int selectIndex = GetSelectIndex();
            RedactAgreement(Agreement[selectIndex]);
        }

        private void DeleteAgreement_Click(object sender, RoutedEventArgs e)
        {
            var select_agreement = membersDataGrid.SelectedItem;
            Agreement.Remove((Agreement)select_agreement);
            using (ApplicationContext db = new ApplicationContext())
            {
                //Удаление
                db.Agreement.Remove((Agreement)select_agreement);
                db.SaveChanges();
            }
            membersDataGrid.Items.Refresh();
        }

        private void membersDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void membersDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            viewingAgreement viewingAgreement_win = new viewingAgreement();
            viewingAgreement_win.Show();
        }
    }

    public class Member
    {
        public string Character { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BGColor { get; set; }
    }
}

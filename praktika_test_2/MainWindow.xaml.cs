using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace praktika_test_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта User
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Alice", Age = 26 };

                // добавляем их в бд
                db.Users.AddRange(user1, user2);
                db.SaveChanges();
            }

            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>
            {
                //Create DataGrid Items Info
                new Member { Number = "1", Character = "F", BGColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "ОАО Azmovl", Position = "2423423", Email = "008-7322/05-22/10164", Phone = "BY33BAP" },
                new Member { Number = "2", Character = "R", BGColor = (Brush)converter.ConvertFromString("#1d88e5"), Name = "ОАО Azmovl", Position = "422343", Email = "008-7322/05-22/10164", Phone = "BY33BAP" },
                new Member { Number = "3", Character = "D", BGColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "ОАО Azmovl", Position = "234234", Email = "008-7322/05-22/10164", Phone = "BY33BAP" },
                new Member { Number = "4", Character = "G", BGColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "ОАО Azmovl", Position = "34534534", Email = "008-7322/05-22/10164", Phone = "BY33BAP" },
                new Member { Number = "5", Character = "L", BGColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "ОАО Azmovl", Position = "53453", Email = "008-7322/05-22/10164", Phone = "BY33BAP" },
                new Member { Number = "6", Character = "B", BGColor = (Brush)converter.ConvertFromString("#6741d9"), Name = "ОАО Azmovl", Position = "5345345", Email = "008-7322/05-22/10164", Phone = "BY33BAP" },
                new Member { Number = "7", Character = "S", BGColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "ОАО Azmovl", Position = "5345345", Email = "008-7322/05-22/10164", Phone = "BY33BAP" },
                new Member { Number = "8", Character = "A", BGColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Сара Ким", Position = "64556", Email = "008-7322/05-22/10164", Phone = "BY33BAP" },
                new Member { Number = "9", Character = "F", BGColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "ОАО Azmovl", Position = "234534", Email = "008-7322/05-22/10164", Phone = "BY33BAP" },
                new Member { Number = "10", Character = "S", BGColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "ОАО Azmovl", Position = "2354534", Email = "008-7322/05-22/10164", Phone = "BY33BAP" },

                new Member { Number = "11", Character = "J", BGColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Анна Коваленко", Position = "Генеральный директор", Email = "john.smith@gmail.com", Phone = "+375 29 123-45-67" },
                new Member { Number = "12", Character = "R", BGColor = (Brush)converter.ConvertFromString("#1d88e5"), Name = "Михаил Петров", Position = "Финансовый директор", Email = "emily.rodriguez@yahoo.com", Phone = "+375 33 456-78-90" },
                new Member { Number = "13", Character = "D", BGColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Джессика Иванова", Position = "Технический директор", Email = "alexander.pavlov@outlook.com", Phone = "+375 44 789-01-23" },
                new Member { Number = "14", Character = "G", BGColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Кристофер Новак", Position = "Президент", Email = "sarah.kim@aol.com", Phone = "+375 25 012-34-56" },
                new Member { Number = "15", Character = "L", BGColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Джеймс Смит", Position = "Вице-президент", Email = "michael.petrov@gmail.com", Phone = "+375 29 345-67-89" },
                new Member { Number = "16", Character = "B", BGColor = (Brush)converter.ConvertFromString("#6741d9"), Name = "Эмили Родригес", Position = "Директор", Email = "jessica.ivanova@yahoo.com", Phone = "+375 33 678-90-12" },
                new Member { Number = "17", Character = "S", BGColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "Александр Павлов", Position = "Менеджер", Email = "christopher.novak@outlook.com", Phone = "+375 44 901-23-45" },
                new Member { Number = "18", Character = "A", BGColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Сара Ким", Position = "Супервайзер", Email = "anna.kovalenko@aol.com", Phone = "+375 25 234-56-78" },
                new Member { Number = "19", Character = "F", BGColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Джон Уильямс", Position = "Ведущий инженер", Email = "rachel.brown@gmail.com", Phone = "+375 29 567-89-01" },
                new Member { Number = "20", Character = "S", BGColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Рейчел Браун", Position = "Менеджер проекта", Email = "james.smith@yahoo.com", Phone = "+375 33 890-12-34" },

                new Member { Number = "21", Character = "J", BGColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Анна Коваленко", Position = "Генеральный директор", Email = "john.smith@gmail.com", Phone = "+375 29 123-45-67" },
                new Member { Number = "22", Character = "R", BGColor = (Brush)converter.ConvertFromString("#1d88e5"), Name = "Михаил Петров", Position = "Финансовый директор", Email = "emily.rodriguez@yahoo.com", Phone = "+375 33 456-78-90" },
                new Member { Number = "23", Character = "D", BGColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Джессика Иванова", Position = "Технический директор", Email = "alexander.pavlov@outlook.com", Phone = "+375 44 789-01-23" },
                new Member { Number = "24", Character = "G", BGColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Кристофер Новак", Position = "Президент", Email = "sarah.kim@aol.com", Phone = "+375 25 012-34-56" },
                new Member { Number = "25", Character = "L", BGColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Джеймс Смит", Position = "Вице-президент", Email = "michael.petrov@gmail.com", Phone = "+375 29 345-67-89" },
                new Member { Number = "26", Character = "B", BGColor = (Brush)converter.ConvertFromString("#6741d9"), Name = "Эмили Родригес", Position = "Директор", Email = "jessica.ivanova@yahoo.com", Phone = "+375 33 678-90-12" },
                new Member { Number = "27", Character = "S", BGColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "Александр Павлов", Position = "Менеджер", Email = "christopher.novak@outlook.com", Phone = "+375 44 901-23-45" },
                new Member { Number = "28", Character = "A", BGColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Сара Ким", Position = "Супервайзер", Email = "anna.kovalenko@aol.com", Phone = "+375 25 234-56-78" },
                new Member { Number = "29", Character = "F", BGColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Джон Уильямс", Position = "Ведущий инженер", Email = "rachel.brown@gmail.com", Phone = "+375 29 567-89-01" },
                new Member { Number = "30", Character = "S", BGColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Рейчел Браун", Position = "Менеджер проекта", Email = "james.smith@yahoo.com", Phone = "+375 33 890-12-34" }
            };

            membersDataGrid.ItemsSource = members;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton==MouseButton.Left) 
            { 
                this.DragMove();
            }
        }

        bool IsMaximized= false;

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (this.IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1280;
                    this.Height = 780;

                    this.IsMaximized = false;
                }
                else
                {
                    this.WindowState= WindowState.Maximized;

                    this.IsMaximized = true;
                }
            }
        }

        private void AddAgreement_Click(object sender, RoutedEventArgs e)
        {
            addAgreement addAgreement = new addAgreement();
            addAgreement.Show();
            //MessageBox.Show("работает");
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

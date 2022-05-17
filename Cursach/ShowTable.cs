using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Cursach
{
    /// <summary>
    /// окно вывода таблиц
    /// </summary>
    public partial class ShowTable : Window
    {
        ApplicationContext _db;

        string Condition;

        List<User> Users;


        public ShowTable(string cond)
        {
            InitializeComponent();

            _db = new ApplicationContext();

            Condition = cond;
        }

        public ShowTable(List<User> users)
        {
            InitializeComponent();

            _db = new ApplicationContext();

            Condition = "Поиск:";

            Users = users;

        }

        public void TableGrid_OnLoaded(object sender, RoutedEventArgs e)
        {


            Cond.Text = Condition;

            var users = _db.Users.ToList();

            if (Condition.Equals("Студенты"))
            {
                var usersSelect = users.Select(t => new
                {
                    Name = t.Name,
                    Group = t.GroupNum,
                    Physic = t.PhysicsLesson,
                    DataBase = t.DataBaseLesson,
                    Math = t.MathLesson,
                    Engish = t.EngishLesson,
                    Programming = t.ProgramLesson,
                }).ToList();

                TableGrid.ItemsSource = usersSelect;

                CountUser.Text += $"{usersSelect.Count}";
            }
            else if (Condition == "Математика")
            {

                var usersSelect = users.FindAll(t => t.MathLesson.Equals(1));

                if (usersSelect.Count > 15)
                {
                    usersSelect.OrderBy(t => t.AverageRating);

                    var t = usersSelect;

                    for (int i = 0; i < 15; i++)
                    {
                        usersSelect[i] = t[i];
                    }
                }



                var usersSelectGrid = usersSelect.Select(t => new
                {
                    Name = t.Name,
                    Group = t.GroupNum,
                    Rating = t.AverageRating
                }).ToList();

                CountUser.Text += $"{usersSelectGrid.Count}";

                TableGrid.ItemsSource = usersSelectGrid;
            }

            else if (Condition == "Физика")
            {

                var usersSelect = users.FindAll(t => t.PhysicsLesson.Equals(1));

                if (usersSelect.Count > 15)
                {
                    usersSelect.OrderBy(t => t.AverageRating);

                    var t = usersSelect;

                    for (int i = 0; i < 15; i++)
                    {
                        usersSelect[i] = t[i];
                    }
                }



                var usersSelectGrid = usersSelect.Select(t => new
                {
                    Name = t.Name,
                    Group = t.GroupNum,
                    Rating = t.AverageRating
                }).ToList();

                CountUser.Text += $"{usersSelectGrid.Count}";

                TableGrid.ItemsSource = usersSelectGrid;
            }
            else if (Condition == "Английский")
            {

                var usersSelect = users.FindAll(t => t.EngishLesson.Equals(1));

                if (usersSelect.Count > 15)
                {
                    usersSelect.OrderBy(t => t.AverageRating);

                    var t = usersSelect;

                    for (int i = 0; i < 15; i++)
                    {
                        usersSelect[i] = t[i];
                    }
                }



                var usersSelectGrid = usersSelect.Select(t => new
                {
                    Name = t.Name,
                    Group = t.GroupNum,
                    Rating = t.AverageRating
                }).ToList();

                TableGrid.ItemsSource = usersSelectGrid;

                CountUser.Text += $"{usersSelectGrid.Count}";
            }
            else if (Condition == "Программирование")
            {

                var usersSelect = users.FindAll(t => t.ProgramLesson.Equals(1));

                if (usersSelect.Count > 15)
                {
                    usersSelect.OrderBy(t => t.AverageRating);

                    var t = usersSelect;

                    for (int i = 0; i < 15; i++)
                    {
                        usersSelect[i] = t[i];
                    }
                }



                var usersSelectGrid = usersSelect.Select(t => new
                {
                    Name = t.Name,
                    Group = t.GroupNum,
                    Rating = t.AverageRating
                }).ToList();

                TableGrid.ItemsSource = usersSelectGrid;

                CountUser.Text += $"{usersSelectGrid.Count}";
            }

            else if (Condition == "Базы данных")
            {

                var usersSelect = users.FindAll(t => t.DataBaseLesson.Equals(1));

                if (usersSelect.Count > 15)
                {
                    usersSelect.OrderBy(t => t.AverageRating);

                    var t = usersSelect;

                    for (int i = 0; i < 15; i++)
                    {
                        usersSelect[i] = t[i];
                    }
                }

                var usersSelectGrid = usersSelect.Select(t => new
                {
                    Name = t.Name,
                    Group = t.GroupNum,
                    Rating = t.AverageRating
                }).ToList();

                TableGrid.ItemsSource = usersSelectGrid;

                CountUser.Text += $"{usersSelectGrid.Count}";
            }

            else if (Condition == "Поиск:")
            {


                var usersSelectGrid = Users.Select(t => new
                {
                    Name = t.Name,
                    Group = t.GroupNum,
                    Rating = t.AverageRating
                }).ToList();

                TableGrid.ItemsSource = usersSelectGrid;

                CountUser.Text += $"{usersSelectGrid.Count}";
            }
        }
    }
}

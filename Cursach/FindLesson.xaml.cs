using System.Linq;
using System.Windows;

namespace Cursach
{
    /// <summary>
    /// Окно поиска предметов
    /// </summary>
    public partial class FindLesson : Window
    {

        ApplicationContext _db;
        public FindLesson()
        {
            InitializeComponent();

            _db = new ApplicationContext();
        }


        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            NameError.Text = "";

            if (ByName.IsChecked.Equals(true))
            {
                if (NameTextBox.Text.Equals("Математика"))
                {
                    var users = _db.Users.ToList().FindAll(t => t.MathLesson.Equals(1));

                    var showTable = new ShowTable(users);

                    showTable.Show();
                }
                else if (NameTextBox.Text.Equals("Физика"))
                {
                    var users = _db.Users.ToList().FindAll(t => t.PhysicsLesson.Equals(1));

                    var showTable = new ShowTable(users);

                    showTable.Show();
                }
                else if (NameTextBox.Text.Equals("Английкий"))
                {
                    var users = _db.Users.ToList().FindAll(t => t.EngishLesson.Equals(1));

                    var showTable = new ShowTable(users);

                    showTable.Show();
                }
                else if (NameTextBox.Text.Equals("Программирование"))
                {
                    var users = _db.Users.ToList().FindAll(t => t.ProgramLesson.Equals(1));

                    var showTable = new ShowTable(users);

                    showTable.Show();
                }

                else if (NameTextBox.Text.Equals("Базы данных"))
                {
                    var users = _db.Users.ToList().FindAll(t => t.DataBaseLesson.Equals(1));

                    var showTable = new ShowTable(users);

                    showTable.Show();
                }

                else
                {
                    NameError.Text = "Не корректный ввод";
                }
            }

            if (ByAverRating.IsChecked.Equals(true))
            {

                double doubleRating = 0;


                if (double.TryParse(NameTextBox.Text, out doubleRating) || doubleRating < 0)
                {
                    var users = _db.Users.ToList().FindAll(t => t.ProgramLesson.Equals(1));

                    if (users.Count != 0 && users.Average(t => t.AverageRating) >= doubleRating)
                    {
                        MessageBox.Show("Прогаммирование");
                    }

                    users = _db.Users.ToList().FindAll(t => t.EngishLesson.Equals(1));

                    if (users.Count != 0 && users.Average(t => t.AverageRating) >= doubleRating)
                    {
                        MessageBox.Show("Английский");
                    }

                    users = _db.Users.ToList().FindAll(t => t.PhysicsLesson.Equals(1));

                    if (users.Count != 0 && users.Average(t => t.AverageRating) >= doubleRating)
                    {
                        MessageBox.Show("Физика");
                    }

                    users = _db.Users.ToList().FindAll(t => t.MathLesson.Equals(1));

                    if (users.Count != 0 && users.Average(t => t.AverageRating) >= doubleRating)
                    {
                        MessageBox.Show("Матеиатика");
                    }

                    users = _db.Users.ToList().FindAll(t => t.DataBaseLesson.Equals(1));

                    if (users.Count != 0 && users.Average(t => t.AverageRating) >= doubleRating)
                    {
                        MessageBox.Show("Базы  данныйх");
                    }

                }
                else
                {
                    NameError.Text = "Неверное число";

                }


            }

            if (ByCount.IsChecked.Equals(true))
            {

                int doubleCount = 0;


                if (int.TryParse(NameTextBox.Text, out doubleCount) || doubleCount < 0)
                {
                    if (_db.Users.ToList().FindAll(t => t.ProgramLesson.Equals(1)).Count >= doubleCount)
                    {
                        MessageBox.Show("Програмирование");
                    }

                    if (_db.Users.ToList().FindAll(t => t.EngishLesson.Equals(1)).Count >= doubleCount)
                    {
                        MessageBox.Show("Английский");
                    }

                    if (_db.Users.ToList().FindAll(t => t.PhysicsLesson.Equals(1)).Count >= doubleCount)
                    {
                        MessageBox.Show("Физика");
                    }

                    if (_db.Users.ToList().FindAll(t => t.MathLesson.Equals(1)).Count >= doubleCount)
                    {
                        MessageBox.Show("Матеиатика");
                    }

                    if (_db.Users.ToList().FindAll(t => t.DataBaseLesson.Equals(1)).Count >= doubleCount)
                    {
                        MessageBox.Show("Базы  данныйх");
                    }

                }
                else
                {
                    NameError.Text = "Неверное число";

                }
            }
        }
    }
}

using System.Linq;
using System.Windows;

namespace Cursach
{
    /// <summary>
    /// Добавление студента
    /// </summary>
    public partial class AddUser : Window
    {
        private readonly ApplicationContext _db;

        public AddUser()
        {
            InitializeComponent();

            _db = new ApplicationContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            NameError.Text = "";
            GroupeError.Text = "";
            LoginError.Text = "";
            PasswordError.Text = "";
            RatingError.Text = "";

            bool wrongValue = false;

            double rating = 0;

            if (!double.TryParse(Rating.Text, out rating) || rating < 0 || rating > 10)
            {
                RatingError.Text = "Это не число";

                wrongValue = true;
            }

            if (Name.Text.Equals(""))
            {
                NameError.Text = "Пустая строка";

                wrongValue = true;
            }

            if (Password.Text.Equals(""))
            {
                PasswordError.Text = "Пустая строка";

                wrongValue = true;
            }
            if (Login.Text.Equals(""))
            {
                LoginError.Text = "Пустая строка";

                wrongValue = true;
            }
            if (GroupeName.Text.Equals(""))
            {
                GroupeError.Text = "Пустая строка";

                wrongValue = true;
            }
            if (_db.Users.ToList().FindAll(t => t.Login.Equals(Login.Text)).Count != 0)
            {
                LoginError.Text = "Логин занят";

                wrongValue = true;
            }

            if (!wrongValue)
            {
                var user = new User(Name.Text, Password.Text, Login.Text, GroupeName.Text, rating);

                _db.Users.Add(user);

                _db.SaveChanges();

                Close();
            }

        }



    }
}
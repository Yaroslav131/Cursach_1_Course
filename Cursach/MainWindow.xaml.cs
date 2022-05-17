using System.Linq;
using System.Windows;

namespace Cursach
{
    /// <summary>
    /// Окно входа всистему
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            _db = new ApplicationContext();
        }

        private readonly ApplicationContext _db;

        private string _login;
        private string _password;

        private void Button_SIngInClick(object sender, RoutedEventArgs e)
        {
            _login = LoginTextbox.Text;
            _password = PasswordTextbox.Password;

            var admins = _db.Admins.ToList();

            var users = _db.Users.ToList();

            var user = users.Find(item => item.Login.Equals(_login));




            var admin = admins.Find(item => item.Login.Equals(_login));


            LoginError.Text = "";
            PasswordError.Text = "";

            if (_password.Length == 0)
            {
                return;
            }



            if (admin != null)
            {
                if (admin.Password.Equals(_password))
                {

                    AdminWind adminWind = new AdminWind();

                    adminWind.Show();

                    Close();
                }

                else
                {
                    PasswordError.Text = "Wrong password";
                }
            }

            else if (user == null)
            {
                LoginError.Text = "Unknown login";
            }
            else
            {
                if (user.Password.Equals(_password))
                {
                    App.userNow = user.Id;

                    var userMenu = new UserMenu();

                    userMenu.Show();

                    Close();
                }

                else
                {
                    PasswordError.Text = "Wrong password";
                }
            }
        }
    }
}

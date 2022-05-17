using System.Windows;

namespace Cursach
{
    /// <summary>
    /// Меню админа
    /// </summary>
    public partial class AdminWind : Window
    {
        public AdminWind()
        {
            InitializeComponent();
        }
        private void ButtonUserList_Click(object sender, RoutedEventArgs e)
        {
            var showUsersList = new ShowTable("Студенты");

            showUsersList.Owner = this;

            showUsersList.Show();
        }

        private void ButtonAddUser_Click(object sender, RoutedEventArgs e)
        {
            var wind = new AddUser();

            wind.Owner = this;

            wind.Show();
        }

        private void ButtonDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            var wind = new DeleteUser();

            wind.Owner = this;

            wind.Show();

        }

        private void ButtonFind_Click(object sender, RoutedEventArgs e)
        {
            var wind = new FindWindow();

            wind.Owner = this;

            wind.Show();
        }

        private void ButtonLessons_Click(object sender, RoutedEventArgs e)
        {
            var showUsersList = new LessonsListWind();

            showUsersList.Owner = this;

            showUsersList.Show();
        }

        private void ButtonReport_Click(object sender, RoutedEventArgs e)
        {
            var showUsersList = new MakeReport();

            showUsersList.Owner = this;

            showUsersList.Show();
        }
    }
}

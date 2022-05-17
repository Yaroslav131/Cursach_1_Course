using System.Linq;
using System.Windows;

namespace Cursach
{
    /// <summary>
    /// Меню юзера
    /// </summary>
    public partial class UserMenu : Window
    {
        private readonly ApplicationContext _db;

        public UserMenu()
        {
            InitializeComponent();

            _db = new ApplicationContext();
        }

        private void ButtonUserList_Click(object sender, RoutedEventArgs e)
        {
            var showUsersList = new ShowTable("Студенты");

            showUsersList.Owner = this;

            showUsersList.Show();
        }

     

        private void ButtonFind_Click(object sender, RoutedEventArgs e)
        {
            var wind = new FindLesson();

            wind.Owner = this;

            wind.Show();
        }

        private void ButtonLessons_Click(object sender, RoutedEventArgs e)
        {
            var wind = new ChooseLesson();

            wind.Owner = this;

            wind.Show();
        }

      
    }
}

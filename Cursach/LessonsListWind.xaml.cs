using System.Windows;

namespace Cursach
{
    /// <summary>
    /// окно выборапредмета
    /// </summary>
    public partial class LessonsListWind : Window
    {
        public LessonsListWind()
        {
            InitializeComponent();
        }

        private void ButtonMath_Click(object sender, RoutedEventArgs e)
        {
            var showUsersList = new ShowTable("Математика");

            showUsersList.Owner = this;

            showUsersList.Show();
        }

        private void ButtonPhith_Click(object sender, RoutedEventArgs e)
        {
            var showUsersList = new ShowTable("Физика");

            showUsersList.Owner = this;

            showUsersList.Show();
        }

        private void ButtonEng_Click(object sender, RoutedEventArgs e)
        {
            var showUsersList = new ShowTable("Английский");

            showUsersList.Owner = this;

            showUsersList.Show();
        }

        private void ButtonProg_Click(object sender, RoutedEventArgs e)
        {
            var showUsersList = new ShowTable("Программирование");

            showUsersList.Owner = this;

            showUsersList.Show();
        }

        private void ButtonBD_Click(object sender, RoutedEventArgs e)
        {
            var showUsersList = new ShowTable("Базы данных");

            showUsersList.Owner = this;

            showUsersList.Show();
        }
    }
}

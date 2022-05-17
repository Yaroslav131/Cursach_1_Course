using System.Linq;
using System.Windows;

namespace Cursach
{
    /// <summary>
    /// Удаление студента
    /// </summary>
    public partial class DeleteUser : Window
    {
        private readonly ApplicationContext _db;

        private string _name;

        public DeleteUser()
        {
            InitializeComponent();
            _db = new ApplicationContext();
        }

        private void Button_DeleteClick(object sender, RoutedEventArgs e)
        {
            _name = NameTextBox.Text.Trim();

            NameError.Text = "";

            var user = _db.Users.ToList().Find(t => t.Name.Equals(_name));

            if (user != null)
            {
                _db.Users.Remove(user);

                _db.SaveChanges();

                Close();
            }
            else
            {
                NameError.Text = "Нет такого студента";
            }
        }
    }
}

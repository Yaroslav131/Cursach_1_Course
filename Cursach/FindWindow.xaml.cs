using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Cursach
{
    /// <summary>
    /// Окно поиска студента
    /// </summary>
    public partial class FindWindow : Window
    {
        ApplicationContext _db;
        public FindWindow()
        {
            InitializeComponent();

            _db = new ApplicationContext();
        }


        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            NameError.Text = "";

            if (ByName.IsChecked.Equals(true))
            {
                var users = _db.Users.ToList().FindAll(t => t.Name.Equals(NameTextBox.Text));

                var showTable = new ShowTable(users);

                showTable.Show();
            }

            if (ByGroupe.IsChecked.Equals(true))
            {
                var users = _db.Users.ToList().FindAll(t => t.GroupNum.Equals(NameTextBox.Text));

                var showTable = new ShowTable(users);

                showTable.Show();
            }

            if (ByRating.IsChecked.Equals(true))
            {
                List<User> users = new List<User>();
                double doubleRating;

                if (double.TryParse(NameTextBox.Text, out doubleRating))
                {
                    foreach (User user in _db.Users.ToList())
                    {
                        if (user.AverageRating >= doubleRating)
                        {
                            users.Add(user);
                        }
                    }

                    var showTable = new ShowTable(users);

                    showTable.Show();
                }
                else
                {
                    NameError.Text = "Это не число";

                }

            }
        }
    }
}

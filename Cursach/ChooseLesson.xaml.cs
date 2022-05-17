using System.Linq;
using System.Windows;

namespace Cursach
{
    /// <summary>
    /// Окно подписки на предметы
    /// </summary>
    public partial class ChooseLesson : Window
    {
        private readonly ApplicationContext _db;


        public ChooseLesson()
        {
            InitializeComponent();
            _db = new ApplicationContext();
        }

        private void FocusWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            var user = _db.Users.ToList().Find(t => t.Id.Equals(App.userNow));

            if (user.MathLesson.Equals(1))
            {
                MathButton.IsChecked = true;
            }

            if (user.PhysicsLesson.Equals(1))
            {
                PhithButton.IsChecked = true;
            }

            if (user.EngishLesson.Equals(1))
            {
                EngButton.IsChecked = true;
            }

            if (user.ProgramLesson.Equals(1))
            {
                ProgButton.IsChecked = true;
            }

            if (user.DataBaseLesson.Equals(1))
            {
                DdButton.IsChecked = true;
            }
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            var user = _db.Users.ToList().Find(t => t.Id.Equals(App.userNow));

            if ((bool)MathButton.IsChecked)
            {
                user.MathLesson = 1;
            }
            else
            {
                user.MathLesson = 0;
            }

            if ((bool)PhithButton.IsChecked)
            {
                user.PhysicsLesson = 1;
            }
            else
            {
                user.PhysicsLesson = 0;
            }

            if ((bool)EngButton.IsChecked)
            {
                user.EngishLesson = 1;
            }
            else
            {
                user.EngishLesson = 0;
            }

            if ((bool)ProgButton.IsChecked)
            {
                user.ProgramLesson = 1;
            }
            else
            {
                user.ProgramLesson = 0;
            }

            if ((bool)DdButton.IsChecked)
            {
                user.DataBaseLesson = 1;
            }
            else
            {
                user.DataBaseLesson = 0;
            }

            _db.SaveChanges();


        }
    }
}

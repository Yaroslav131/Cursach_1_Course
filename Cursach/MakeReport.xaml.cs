    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;

    namespace Cursach
    {
        /// <summary>
        /// Окно созадния очета
        /// </summary>
        public partial class MakeReport : Window
        {
            private readonly ApplicationContext _db;
            private string _typeSearch;

            public MakeReport()
            {
                InitializeComponent();
                _db = new ApplicationContext();
            }


            public bool CheckType(string _typeCard)
            {
                if (_typeCard == null)
                {
                    TypeError.Text = "Choose period";
                    return false;
                }

                return true;
            }

            private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
            {
                var tvItem = (TreeViewItem)sender;

                _typeSearch = tvItem.Name;
            }

            private void MakeReport_Click(object sender, RoutedEventArgs e)
            {
                var user = _db.Users.ToList().Find(t => t.Id.Equals(App.userNow));

                string path = @"D:\Cursach";
                string textReport = "";

                if (CheckType(_typeSearch))
                {
                    if (_typeSearch == "Math")
                    {
                        var usersSelect = _db.Users.ToList().FindAll(t => t.MathLesson.Equals(1));

                        textReport = "Математика";


                        foreach (var report in usersSelect)
                        {
                            textReport += $"\n{report.Name} {report.GroupNum} {report.AverageRating}";
                        }

                        DirectoryInfo dirInfo = new DirectoryInfo(path);

                        if (!dirInfo.Exists)
                        {
                            dirInfo.Create();
                        }

                        string dataNowString = DateTime.Now.ToLongTimeString().ToString();
                        using (FileStream fstream = new FileStream($@"{path}\report_Математика.txt", FileMode.OpenOrCreate))
                        {
                            byte[] array = Encoding.Default.GetBytes(textReport);

                            fstream.Write(array, 0, array.Length);
                        }
                    }
                    else if (_typeSearch == "Phith")
                    {
                        var usersSelect = _db.Users.ToList().FindAll(t => t.MathLesson.Equals(1));

                        textReport = "Физика";


                        foreach (var report in usersSelect)
                        {
                            textReport += $"\n{report.Name} {report.GroupNum} {report.AverageRating}";
                        }

                        DirectoryInfo dirInfo = new DirectoryInfo(path);

                        if (!dirInfo.Exists)
                        {
                            dirInfo.Create();
                        }

                        string dataNowString = DateTime.Now.ToLongTimeString().ToString();
                        using (FileStream fstream = new FileStream($@"{path}\report_Физика.txt", FileMode.OpenOrCreate))
                        {
                            byte[] array = Encoding.Default.GetBytes(textReport);

                            fstream.Write(array, 0, array.Length);
                        }
                    }
                    else if (_typeSearch == "English")
                    {
                        var usersSelect = _db.Users.ToList().FindAll(t => t.MathLesson.Equals(1));

                        textReport = "Английский";


                        foreach (var report in usersSelect)
                        {
                            textReport += $"\n{report.Name} {report.GroupNum} {report.AverageRating}";
                        }

                        DirectoryInfo dirInfo = new DirectoryInfo(path);

                        if (!dirInfo.Exists)
                        {
                            dirInfo.Create();
                        }

                        string dataNowString = DateTime.Now.ToLongTimeString().ToString();
                        using (FileStream fstream = new FileStream($@"{path}\report_Английский.txt", FileMode.OpenOrCreate))
                        {
                            byte[] array = Encoding.Default.GetBytes(textReport);

                            fstream.Write(array, 0, array.Length);
                        }
                    }
                    else if (_typeSearch == "Prog")
                    {
                        var usersSelect = _db.Users.ToList().FindAll(t => t.MathLesson.Equals(1));

                        textReport = "Программирование";


                        foreach (var report in usersSelect)
                        {
                            textReport += $"\n{report.Name} {report.GroupNum} {report.AverageRating}";
                        }

                        DirectoryInfo dirInfo = new DirectoryInfo(path);

                        if (!dirInfo.Exists)
                        {
                            dirInfo.Create();
                        }

                        string dataNowString = DateTime.Now.ToLongTimeString().ToString();
                        using (FileStream fstream = new FileStream($@"{path}\report_Программирование.txt", FileMode.OpenOrCreate))
                        {
                            byte[] array = Encoding.Default.GetBytes(textReport);

                            fstream.Write(array, 0, array.Length);
                        }
                    }
                    else if (_typeSearch == "BD")
                    {
                        var usersSelect = _db.Users.ToList().FindAll(t => t.MathLesson.Equals(1));

                        textReport = "Базы данных";


                        foreach (var report in usersSelect)
                        {
                            textReport += $"\n{report.Name} {report.GroupNum} {report.AverageRating}";
                        }

                        DirectoryInfo dirInfo = new DirectoryInfo(path);

                        if (!dirInfo.Exists)
                        {
                            dirInfo.Create();
                        }

                        string dataNowString = DateTime.Now.ToLongTimeString().ToString();
                        using (FileStream fstream = new FileStream($@"{path}\report_БазыДанных.txt", FileMode.OpenOrCreate))
                        {
                            byte[] array = Encoding.Default.GetBytes(textReport);

                            fstream.Write(array, 0, array.Length);
                        }
                    }

                    Close();
                }
            }
        }
    }

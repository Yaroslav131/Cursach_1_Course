namespace Cursach
{
    public class User
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string GroupNum { get; set; }
        public double AverageRating { get; set; }
        public int MathLesson { get; set; }
        public int PhysicsLesson { get; set; }
        public int ProgramLesson { get; set; }
        public int EngishLesson { get; set; }
        public int DataBaseLesson { get; set; }

        public User(string name, string pasword, string login, string groupNum, double averageRating) 
        { 
           Name = name;
            Password = pasword;
            Login = login;
            GroupNum = groupNum;
            AverageRating = averageRating;
        }

        public User() 
        { 
        }
    }
}

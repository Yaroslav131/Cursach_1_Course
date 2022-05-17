using Microsoft.EntityFrameworkCore;

namespace Cursach
{
    //файл поключения к базе данных
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Admin> Admins { get; set; }


        private static bool _created = false;
        public ApplicationContext()
        {
            if (!_created)
            {
                _created = true;

                Database.EnsureCreated();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite(@"Data Source=D:\Cursach\Sample.db");
        }
    }
}

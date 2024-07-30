using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MyFriends.Models;

namespace MyFriends.DAL
{
    public class DBContext : DbContext
    {
        public DBContext(string connectionString) : base(GetOptions(connectionString)) {
            Database.EnsureCreated();
            if(friends.Count() == 0)
            {
                Seed();
            }
        }
        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }
        public DbSet<Friend> friends { get; set; }
        public DbSet<Images> images { get; set; }

        private void Seed()
        {
            Friend friend = new Friend
            {
                FirstName = "Chezky",
                LastName = "Kofman ",
                PhoneNumber = "1234567890",
                EmailAddress = "1@gmail.com",
            };
            friends.Add(friend);
            SaveChanges();
        }
    }

}

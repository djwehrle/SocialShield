using System.Data.Entity;

namespace SocialShield.Models
{
    public class SocialShieldDbContext : DbContext
    {
        public SocialShieldDbContext(string connectionString)
        {
            Database.Connection.ConnectionString = connectionString;
        }

        public DbSet<School> Schools { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSchool> UserSchools { get; set; }
    }
}
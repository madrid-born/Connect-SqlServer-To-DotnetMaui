using Microsoft.EntityFrameworkCore;

namespace SqlServerTest ;

    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext()
        {
            
        }
        
        public UserDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Connection string");
            }
        }

        public IEnumerable<User> GetUsers()
        {
            return Users.ToList();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
            SaveChanges();
        }
    }

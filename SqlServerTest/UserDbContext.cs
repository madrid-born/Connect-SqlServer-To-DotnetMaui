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
                optionsBuilder.UseSqlServer("Server=win2016-770ir.hostnegar.com\\MSSQLSERVER2022;Database=RaterDataBase;User ID=alireza;Password=15iX#6to0;TrustServerCertificate=True");
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
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CarCategory> CarCategories { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<AfterServiceDb> AfterServiceDbs { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                FirstName = "Admin",
                LastName = "",
                Email = "admin@gmail.com",
                MobileNumber = "1234567890",
                AccountStatus = AccountStatus.ACTIVE,
                UserType = UserType.ADMIN,
                Password = "admin1999",
                CreatedOn = new DateTime(2023, 11, 01, 13, 28, 12)
            }, new User()
            {
                Id = 2,
                FirstName = "service adviser",
                LastName = "",
                Email = "sa@gmail.com",
                MobileNumber = "1234567892",
                AccountStatus = AccountStatus.ACTIVE,
                UserType = UserType.SERVICE_ADVISER,
                Password = "sa1999",
                CreatedOn = new DateTime(2023, 11, 01, 13, 28, 12)
            });
          

            modelBuilder.Entity<CarCategory>().HasData(
                
                new CarCategory { Id = 8, Category = "Honda", SubCategory = "verna" });

            modelBuilder.Entity<Car>().HasData(
            
            new Car { Id = 8, CarCategoryId = 8, Ordered = false, Price = 3800, Owner = "Albert Einstein", Name = "verna9953" });
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<UserType>().HaveConversion<string>();
            configurationBuilder.Properties<AccountStatus>().HaveConversion<string>();
        }
    }
}

using GymSpot.Areas.Client.Models;
using Microsoft.EntityFrameworkCore;

namespace GymSpot.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasData(
             new UserModel
             {
                 UserId = 1,
                 Name = "Adam Kirwan",
                 DateofBirth = DateTime.Now,
                 AccountPassword = "123",
                 Address = "Some Address",
                 EmailAddress = "Adam@123Kirwan",
                 Gender = Gender.Male,
             }
           );
        }

    }
}

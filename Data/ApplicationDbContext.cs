using Microsoft.EntityFrameworkCore;
using DriftNews.Models;
using DriftNews.Helpers;
using DriftNews.Data.Enum;

namespace DriftNews.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<NewsRDS> NewsRDS { get; set; }
        public DbSet<NewsFD> NewsFD { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<DriversRDS> DriversRDS { get; set; }
        public DbSet<ResultsRDS> ResultsRDS { get; set; }
        public DbSet<DriversFDPRO> DriversFDPRO { get; set; }
        public DbSet<ResultsFDPRO> ResultsFDPRO { get; set; }
        public DbSet<ResultsDMEC>  ResultsDMEC { get; set; }
        public DbSet<NewsDMEC> NewsDMEC { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(builder =>
            {
                builder.HasData(new User
                {
                    Id = 1,
                    Username = "Admin",
                    Name = "Admin",
                    Password = HashPasswordHelper.HashPassword("cisco"),
                    Role = Role.Admin
                });
                builder.ToTable("Users").HasKey(x => x.Id);
                builder.Property(x => x.Id).ValueGeneratedOnAdd();
                builder.Property(x => x.Role).IsRequired(); 
                builder.Property(x => x.Password).HasMaxLength(128).IsRequired();
                builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            });
        }

    }
}

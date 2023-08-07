using Microsoft.EntityFrameworkCore;
using DriftNews.Models;
using DriftNewsParser.Models;

namespace DriftNews.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<NewsRDS> News { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<DriversRDS> Drivers { get; set; }
        public DbSet<ResultsRDS> ResultsRDS { get; set; }
        public DbSet<DriversFDPRO> DriversFDPRO { get; set; }
        public DbSet<ResultsFDPRO> ResultsFDPRO { get; set; }
    }
}

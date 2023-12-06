using DriftNews.Interfaces;
using DriftNews.Models;
using Microsoft.AspNetCore.Mvc;

namespace DriftNews.Data.Repository
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<News> GetNewsRDS ()
        {
            return _context.News.Where(c => c.Championship == "RDS").OrderBy(d => d.Date).Reverse().ToList();
        }
        public List<News> GetNewsFD()
        {
            return _context.News.Where(c => c.Championship == "FD").OrderBy(d => d.Date).Reverse().ToList();
        }
        public List<News> GetNewsDMEC()
        {
            return _context.News.Where(c => c.Championship == "DMEC").OrderBy(d => d.Date).Reverse().ToList();
        }
        public List<News> GetNews()
        {
            return _context.News.OrderBy(d => d.Date).ToList();
        }
        public List<DriversFDPRO> GetDriversFDPRO()
        {
            return _context.DriversFDPRO.ToList();
        }
        public List<DriversRDS> GetDriversRDS()
        {
            return _context.DriversRDS.ToList();
        }
        public List<ResultsFDPRO> GetResultsFDPRO()
        {
            return _context.ResultsFDPRO.ToList();
        }
        public IEnumerable<ResultsRDS> GetResultsRDS()
        {
            return _context.ResultsRDS.ToList();
        }
        public IEnumerable<ResultsDMEC> GetResultsDMEC()
        {
            return _context.ResultsDMEC.ToList();
        }


        

    }
}

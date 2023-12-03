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
        public List<NewsRDS> GetNewsRDS ()
        {
            return _context.NewsRDS.ToList();
        }
        public List<NewsFD> GetNewsFD()
        {
            return _context.NewsFD.ToList();
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
        public List<NewsDMEC> GetNewsDMEC()
        {
            return _context.NewsDMEC.ToList();
        }

        

    }
}

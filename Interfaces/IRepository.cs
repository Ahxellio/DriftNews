using DriftNews.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DriftNews.Interfaces
{
    public interface IRepository
    {
        public List<NewsRDS> GetNewsRDS();
        public List<DriversRDS> GetDriversRDS();
        public IEnumerable<ResultsRDS> GetResultsRDS();
        public List<NewsFD> GetNewsFD();
        public List<DriversFDPRO> GetDriversFDPRO();
        public List<ResultsFDPRO> GetResultsFDPRO();
        public IEnumerable<ResultsDMEC> GetResultsDMEC();
        public List<NewsDMEC> GetNewsDMEC();
    }
}

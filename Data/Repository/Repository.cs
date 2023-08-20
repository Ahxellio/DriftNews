using DriftNews.Models;

namespace DriftNews.Data.Repository
{
    public class Repository
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<NewsRDS> GetNews ()
        {
            return _context.NewsRDS.ToList();
        }
    }
}

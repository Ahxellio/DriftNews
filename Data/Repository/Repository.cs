﻿using DriftNews.Models;

namespace DriftNews.Data.Repository
{
    public class Repository
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
    }
}

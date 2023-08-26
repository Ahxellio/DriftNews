using DriftNews.Data.Repository;
using DriftNews.Models;
using DriftNews.Models.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace DriftNews.Controllers
{
    public class NewsController : Controller
    {
        private readonly Repository _repository;
        public NewsController(Repository repository)
        {
            _repository = repository;
        }
        public IActionResult Index( int pg = 1)
        {
            List<NewsFD> news = _repository.GetNewsFD();
            const int pageSize = 5;
            if(pg < 1)
            {
                pg = 1;
            }
            int recsCount = news.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = news.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            return View(data);
        }
    }
}

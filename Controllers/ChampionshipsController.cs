using DriftNews.Models.Infrastructure;
using DriftNews.Models;
using Microsoft.AspNetCore.Mvc;
using DriftNews.Data.Repository;

namespace DriftNews.Controllers
{
    public class ChampionshipsController : Controller
    {
        private readonly Repository _repository;
        public ChampionshipsController(Repository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RDS(int pg = 1)
        {
            List<NewsRDS> news = _repository.GetNewsRDS();
            const int pageSize = 5;
            if (pg < 1)
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
        public IActionResult DMEC()
        {
            return View();
        }
        public IActionResult FD(int pg = 1)
        {
            List<NewsFD> news = _repository.GetNewsFD();
            const int pageSize = 5;
            if (pg < 1)
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

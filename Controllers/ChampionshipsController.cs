using DriftNews.Models.Infrastructure;
using DriftNews.Models;
using Microsoft.AspNetCore.Mvc;
using DriftNews.Data.Repository;
using DriftNews.Data;

namespace DriftNews.Controllers
{
    public class ChampionshipsController : Controller
    {
        private readonly ApplicationDbContext _db;

        private readonly Repository _repository;
        public ChampionshipsController(Repository repository, ApplicationDbContext db)
        {
            _repository = repository;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NewsRDS obj)
        {
            if (ModelState.IsValid)
            {
                _db.NewsRDS.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category Created Succesfully";
                return RedirectToAction("RDS");
            }
            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) { return NotFound(); }
            var newsFromDb = _db.NewsRDS.Find(id);
            if (newsFromDb == null) { return NotFound(); }
            return View(newsFromDb);
        }
        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(NewsRDS obj)
        {
            if (ModelState.IsValid)
            {
                _db.NewsRDS.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Category Edited Succesfully";
                return RedirectToAction("RDS");
            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) { return NotFound(); }
            var categoryFromDb = _db.NewsRDS.Find(id);
            if (categoryFromDb == null) { return NotFound(); }
            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var newsFromDb = _db.NewsRDS.Find(id);
            if (newsFromDb == null) { return NotFound(); }
            _db.NewsRDS.Remove(newsFromDb);
            _db.SaveChanges();
            TempData["success"] = "Category Deleted Succesfully";
            return RedirectToAction("Index");
        }
        public IActionResult RDS(int pg = 1)
        {
            List<NewsRDS> news = _repository.GetNewsRDS();
            const int pageSize = 3;
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
        public IActionResult DMEC(int pg = 1)
        {
            List<NewsDMEC> news = _repository.GetNewsDMEC();
            const int pageSize = 10;
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

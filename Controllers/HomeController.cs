using DriftNews.Converters;
using DriftNews.Data;
using DriftNews.Data.Repository;
using DriftNews.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DriftNews.Controllers
{
    public class HomeController : Controller
    {
        private readonly Repository _repository;
        private readonly ApplicationDbContext _db;
        public HomeController(Repository repository, ApplicationDbContext db)
        {
            _repository = repository;
            _db = db;
        }

        public IActionResult Index()
        {
            var news = _repository.GetNewsFD();
            return View(news);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //public IActionResult GetNewsFromDB()
        //{
            
        //}
    }
}
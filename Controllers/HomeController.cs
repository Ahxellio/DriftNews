using DriftNews.Data.Repository;
using DriftNews.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DriftNews.Controllers
{
    public class HomeController : Controller
    {
        private readonly Repository _repository;
        public HomeController(Repository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var model = _repository.GetNewsFD();
            return View(model);
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
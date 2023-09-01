using DriftNews.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DriftNews.Controllers
{
    public class ResultsController : Controller
    {
        private readonly Repository _repository;
        public ResultsController(Repository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult RDS()
        {
            var model = _repository.GetResultsRDS();
            return View(model);
        }
        public IActionResult DMEC()
        {
            return View();
        }
        public IActionResult FD()
        {
            var model = _repository.GetResultsFDPRO();
            return View(model);
        }
    }
}

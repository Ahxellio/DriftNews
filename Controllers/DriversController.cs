using DriftNews.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DriftNews.Controllers
{
    public class DriversController : Controller
    {
        private readonly Repository _repository;
        public DriversController(Repository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RDS()
        {
            var model = _repository.GetDriversRDS();
            return View(model);
        }
        public IActionResult DMEC()
        {
            return View();
        }
        public IActionResult FD()
        {
            var model = _repository.GetDriversFDPRO();
            return View(model);
        }
    }
}

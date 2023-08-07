using Microsoft.AspNetCore.Mvc;

namespace DriftNews.Controllers
{
    public class ResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult RDS()
        {
            return View();
        }
        public IActionResult DMEC()
        {
            return View();
        }
        public IActionResult FD()
        {
            return View();
        }
    }
}

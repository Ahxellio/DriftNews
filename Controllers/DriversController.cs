using Microsoft.AspNetCore.Mvc;

namespace DriftNews.Controllers
{
    public class DriversController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace DriftNews.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

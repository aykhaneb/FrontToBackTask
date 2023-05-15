using Microsoft.AspNetCore.Mvc;

namespace FrontToBackTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

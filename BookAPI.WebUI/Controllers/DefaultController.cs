using Microsoft.AspNetCore.Mvc;

namespace BookAPI.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Deneme()
        {
            return View();
        }
    }
}


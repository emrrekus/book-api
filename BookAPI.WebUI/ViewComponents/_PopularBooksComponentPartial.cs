using Microsoft.AspNetCore.Mvc;

namespace BookAPI.WebUI.ViewComponents
{
    public class _PopularBooksComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
} 
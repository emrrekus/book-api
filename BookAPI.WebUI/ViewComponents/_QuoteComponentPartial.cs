using Microsoft.AspNetCore.Mvc;

namespace BookAPI.WebUI.ViewComponents
{
    public class _QuoteComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
} 
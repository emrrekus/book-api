using Microsoft.AspNetCore.Mvc;

namespace BookAPI.WebUI.ViewComponents
{
    public class _SpecialOfferComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
} 
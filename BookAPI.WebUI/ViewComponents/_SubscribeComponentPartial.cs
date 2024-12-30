using Microsoft.AspNetCore.Mvc;

namespace BookAPI.WebUI.ViewComponents
{
    public class _SubscribeComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
} 
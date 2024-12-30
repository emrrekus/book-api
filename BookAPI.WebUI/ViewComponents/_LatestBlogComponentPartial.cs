using Microsoft.AspNetCore.Mvc;

namespace BookAPI.WebUI.ViewComponents
{
    public class _LatestBlogComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
} 
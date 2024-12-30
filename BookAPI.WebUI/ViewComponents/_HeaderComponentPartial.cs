using Microsoft.AspNetCore.Mvc;

namespace BookAPI.WebUI.ViewComponents
{
	public class _HeaderComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}


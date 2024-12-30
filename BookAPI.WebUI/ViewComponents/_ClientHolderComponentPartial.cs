using Microsoft.AspNetCore.Mvc;

namespace BookAPI.WebUI.ViewComponents
{
	public class _ClientHolderComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

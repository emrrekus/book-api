using Microsoft.AspNetCore.Mvc;

namespace BookAPI.WebUI.ViewComponents
{
	public class _HeadComponentPartial : ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			return View();	
		}
	}
}

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using BookAPI.WebUI.Dtos.BookDtos;

namespace BookAPI.WebUI.ViewComponents
{
    public class _BestSellingComponentPartial : ViewComponent
    {

        		private readonly IHttpClientFactory _httpClientFactory;
public _BestSellingComponentPartial(IHttpClientFactory httpClientFactory)
{
	_httpClientFactory = httpClientFactory;
}
        public async Task<IViewComponentResult> InvokeAsync()
        {
			var client = _httpClientFactory.CreateClient();

			var responseMessage = await client.GetAsync("https://localhost:7093/api/Book/GetRandomBook");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ResultBookDto>(jsonData);
				return View(values);
			}
			return View();
        }
    }
} 
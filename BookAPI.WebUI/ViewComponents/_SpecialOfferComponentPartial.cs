using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using BookAPI.WebUI.Dtos.WriterDtos;
namespace BookAPI.WebUI.ViewComponents
{
    public class _SpecialOfferComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _SpecialOfferComponentPartial(IHttpClientFactory httpClientFactory)  
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7093/api/Writer");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultWriterDto>>(jsonData);
                return View(values);
            }
            return View();
        }
}
} 
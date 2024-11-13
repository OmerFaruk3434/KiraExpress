using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using KiraExpress.Areas.MarketPlace.ViewModels;
using KiraExpress.Areas.MarketPlace.DataTransferObjects;

namespace KiraExpress.Areas.MarketPlace.Controllers
{
    public class ProductController : Controller
    {
        private readonly HttpClient _httpClient;

        public ProductController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        [HttpGet]
        public IActionResult ProductAdd()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ProductAdd([FromBody]ProductDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var jsonContent = JsonSerializer.Serialize(model);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7034/ProductManagement/ProductAdd", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var jsonResponse = JsonSerializer.Deserialize<object>(responseContent);
                return Json(jsonResponse);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Ürün eklenirken bir hata oluştu.");
                return View(model);
            }
        }
    }
}

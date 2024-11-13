using Microsoft.AspNetCore.Mvc;
using KiraExpress.Areas.MarketPlace.ViewModels;
using KiraExpress.Areas.MarketPlace.DataTransferObjects;

namespace KiraExpress.Areas.MarketPlace.Controllers
{
    [Route("Api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("ProductAdd")]
        public async Task<IActionResult> ProductAdd([FromBody] ProductDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var product = await _productService.AddProductAsync(model);
                return Ok(new { message = "Ürün başarıyla eklendi", product });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Bir hata oluştu. Lütfen tekrar deneyin.");
            }
        }
    }
}
using KiraExpress.Areas.MarketPlace.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace KiraExpress.Areas.MarketPlace.Controllers
{
    [Area("MarketPlace")]
    public class ProductManagementController : Controller
    {
        public async Task<IActionResult> Products()
        {
            ViewBag.Title = "Ürünler";
            var model = new ProductSearchViewModel() { };
            return View(model);
        }
        public async Task<IActionResult> ProductsList()
        {
            return View();
        }
    }
}
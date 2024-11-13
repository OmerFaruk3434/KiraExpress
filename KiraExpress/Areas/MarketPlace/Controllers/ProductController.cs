using Microsoft.AspNetCore.Mvc;

namespace KiraExpress.Areas.MarketPlace.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

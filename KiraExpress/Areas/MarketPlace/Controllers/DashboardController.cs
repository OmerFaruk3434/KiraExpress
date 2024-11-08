using Microsoft.AspNetCore.Mvc;

namespace KiraExpress.Areas.MarketPlace.Controllers
{
    [Area("MarketPlace")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

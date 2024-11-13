using Microsoft.AspNetCore.Mvc;

namespace KiraExpress.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

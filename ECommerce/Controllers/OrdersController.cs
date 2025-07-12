using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

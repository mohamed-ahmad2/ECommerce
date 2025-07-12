using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

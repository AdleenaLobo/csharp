using Microsoft.AspNetCore.Mvc;

namespace MVCstart.Controllers
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

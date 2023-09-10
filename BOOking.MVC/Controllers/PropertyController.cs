using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Areas.AdminPanel.Controllers
{

    public class DashBoardController : AdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

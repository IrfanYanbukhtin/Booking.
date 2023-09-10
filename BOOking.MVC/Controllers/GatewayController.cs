using BOOking.DAL.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class GatewayController : Controller
    {
        public readonly AppDbContext _dbContext;

        public GatewayController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

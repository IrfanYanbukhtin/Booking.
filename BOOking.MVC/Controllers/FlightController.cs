using BOOking.DAL.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class FlightController : Controller
    {
        public readonly AppDbContext _dbContext;

        public FlightController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

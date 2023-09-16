using BOOking.DAL.DataContext;
using BOOking.MVC.Models;
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
            var header = _dbContext.Headers.ToList();

            var model = new FlightViewModel
            {
                Headers = header,
            };

            return View(model);
        }
    }
}

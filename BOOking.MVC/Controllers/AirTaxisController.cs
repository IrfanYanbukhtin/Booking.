using BOOking.DAL.DataContext;
using BOOking.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class AirTaxisController : Controller
    {
        public readonly AppDbContext _dbContext;

        public AirTaxisController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var header = _dbContext.Headers.ToList();

            var model = new AirTAxisViewModel
            {
                Headers = header,
            };

            return View(model);
        }
    }
}

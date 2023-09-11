using BOOking.DAL.DataContext;
using BOOking.MVC.Models;
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
            var gateway = _dbContext.Gateways.ToList();
            

            var model = new GatewayViewModel
            {
                Gateways = gateway,
            };

            return View(model);
        }
    }
}

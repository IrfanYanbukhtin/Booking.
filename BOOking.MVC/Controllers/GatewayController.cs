using BOOking.DAL.DataContext;
using BOOking.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class GatewayController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _gatewayCount;

        public GatewayController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _gatewayCount = _dbContext.Gateways.Count();
        }
        public IActionResult Index()
        {
            ViewBag.GatewayCount = _gatewayCount;

            var gateway = _dbContext.Gateways.Take(6).ToList();
            

            var model = new GatewayViewModel
            {
                Gateways = gateway,
            };

            return View(model);
        }

        public IActionResult LoadGateways(int skip)
        {
            if (skip >= _gatewayCount) return BadRequest();
            var gateways = _dbContext.Gateways.Skip(skip).Take(3).ToList();

            return View("Index", gateways);
        }

        
    }
}

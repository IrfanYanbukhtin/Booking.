using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using BOOking.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class SamaxiController : Controller
    {
        public readonly AppDbContext _dbContext;

        public SamaxiController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var samaxiHotel = _dbContext.SamaxiHotels.ToList();
            var header = _dbContext.Headers.ToList();

            var model = new SamaxiViewModel
            {
                SamaxiHotels = samaxiHotel,
                Headers = header,
            };

            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var samaxiHotel = _dbContext.SamaxiHotels.Find(id);

            return View(samaxiHotel);
        }
    }
}

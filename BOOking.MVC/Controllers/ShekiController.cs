using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using BOOking.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class ShekiController : Controller
    {
        public readonly AppDbContext _dbContext;

        public ShekiController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var shekiHotel = _dbContext.ShekiHotels.ToList();

            var model = new ShekiViewModel
            {
                ShekiHotels = shekiHotel,
            };

            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var shekiHotel = _dbContext.ShekiHotels.Find(id);

            return View(shekiHotel);
        }
    }
}

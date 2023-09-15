using BOOking.DAL.DataContext;
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

            return View(samaxiHotel);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var samaxiHotel = _dbContext.SamaxiHotels.Find(id);

            return View(samaxiHotel);
        }
    }
}

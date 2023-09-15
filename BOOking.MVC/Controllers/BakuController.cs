using BOOking.DAL.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class BakuController : Controller
    {
        public readonly AppDbContext _dbContext;

        public BakuController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var bakuHotel = _dbContext.BakuHotels.ToList();

            return View(bakuHotel);
        }
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var bakuHotel = _dbContext.BakuHotels.Find(id);

            return View(bakuHotel);
        }
    }
}

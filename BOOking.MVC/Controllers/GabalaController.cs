using BOOking.DAL.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class GabalaController : Controller
    {
        public readonly AppDbContext _dbContext;

        public GabalaController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var gabalaHotel = _dbContext.GabalaHotels.ToList();

            return View(gabalaHotel);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var gabalaHotel = _dbContext.GabalaHotels.Find(id);

            return View(gabalaHotel);
        }
    }
}

using BOOking.DAL.DataContext;
using BOOking.MVC.Models;
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

            var model = new GabalaViewModel
            {
                GabalaHotels = gabalaHotel,
            };

            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var gabalaHotel = _dbContext.GabalaHotels.Find(id);

            return View(gabalaHotel);
        }
    }
}

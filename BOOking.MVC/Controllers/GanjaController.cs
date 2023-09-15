using BOOking.DAL.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class GanjaController : Controller
    {
        public readonly AppDbContext _dbContext;

        public GanjaController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var ganjaHotel = _dbContext.GanjaHotels.ToList();

            return View(ganjaHotel);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var nabranHotel = _dbContext.NabranHotels.Find(id);

            return View(nabranHotel);
        }
    }
}

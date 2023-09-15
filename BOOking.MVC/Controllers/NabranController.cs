using BOOking.DAL.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class NabranController : Controller
    {
        public readonly AppDbContext _dbContext;

        public NabranController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var nabranHotel = _dbContext.NabranHotels.ToList();

            return View(nabranHotel);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var nabranHotel = _dbContext.NabranHotels.Find(id);

            return View(nabranHotel);
        }
    }
}

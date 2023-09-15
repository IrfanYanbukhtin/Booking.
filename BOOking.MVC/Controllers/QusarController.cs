using BOOking.DAL.DataContext;
using BOOking.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class QusarController : Controller
    {
        public readonly AppDbContext _dbContext;

        public QusarController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var qusarHotel = _dbContext.QusarHotels.ToList();

            var model = new QusarViewModel
            {
                QusarHotels = qusarHotel,
            };

            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var qusarHotel = _dbContext.QusarHotels.Find(id);

            return View(qusarHotel);
        }
    }
}

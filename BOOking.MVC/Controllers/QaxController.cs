using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using BOOking.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class QaxController : Controller
    {
        public readonly AppDbContext _dbContext;

        public QaxController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var qaxHotel = _dbContext.QaxHotels.ToList();

            var model = new QaxViewModel
            {
                QaxHotels = qaxHotel,
            };

            return View(model);
        }
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var qaxHotel = _dbContext.QaxHotels.Find(id);

            return View(qaxHotel);
        }
    }
}

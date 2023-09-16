using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using BOOking.MVC.Models;
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
            var header = _dbContext.Headers.ToList();

            var model = new NabranViewModel
            {
                NabranHotels = nabranHotel,
                Headers = header,
            };

            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var nabranHotel = _dbContext.NabranHotels.Find(id);

            return View(nabranHotel);
        }
    }
}

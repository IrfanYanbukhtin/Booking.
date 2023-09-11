using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using BOOking.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class StaysController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _hotelCount;

        public StaysController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _hotelCount = _dbContext.Hotels.Count();
        }
        public IActionResult Index()
        {
            ViewBag.HotelCount = _hotelCount;

            var hotel = _dbContext.Hotels.Take(4).ToList();
            var explore = _dbContext.Explores.ToList();

            var model = new StaysViewModel

            {
                Explores = explore,
                Hotels = hotel,
            };

            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var hotel = _dbContext.Hotels.Find(id);

            return View(hotel);
        }

        public IActionResult LoadHotels(int skip)
        {
            if (skip >= _hotelCount) return BadRequest();
            var teachers = _dbContext.Hotels.Skip(skip).Take(4).ToList();

            return PartialView("_StaysPartial", teachers);
        }
    }
}

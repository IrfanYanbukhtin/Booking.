using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using BOOking.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class ShahdagController : Controller
    {
        public readonly AppDbContext _dbContext;

        public ShahdagController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var shahdagHotel = _dbContext.ShahdagHotels.ToList();
            var header = _dbContext.Headers.ToList();

            var model = new ShahdagViewModel
            {
                ShahdagHotels = shahdagHotel,
                Headers = header,
            };

            return View(model);
        }
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var shahdagHotel = _dbContext.ShahdagHotels.Find(id);

            return View(shahdagHotel);
        }

        //public IActionResult LoadHotels(int skip)
        //{
        //    if (skip >= _bakuHotelCount) return BadRequest();
        //    var teachers = _dbContext.Hotels.Skip(skip).Take(4).ToList();

        //    return PartialView("_StaysPartial", teachers);
        //}
    }
}

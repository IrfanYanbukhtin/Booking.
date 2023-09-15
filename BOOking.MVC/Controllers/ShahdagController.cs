using BOOking.DAL.DataContext;
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

            return View(shahdagHotel);
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

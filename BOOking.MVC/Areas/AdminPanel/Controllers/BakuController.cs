using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BOOking.MVC.Areas.AdminPanel.Models;

namespace BOOking.MVC.Areas.AdminPanel.Controllers
{
    public class BakuController : AdminController
    {
        private readonly AppDbContext _dbContext;

        public BakuController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var bakuHotels = await _dbContext.BakuHotels.ToListAsync();

            return View(bakuHotels);
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id == null) return NotFound();

            var bakuHotel = await _dbContext.BakuHotels.FirstOrDefaultAsync(x => x.Id == id);

            if (bakuHotel == null) return NotFound();

            return View(bakuHotel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BakuHotel bakuHotel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _dbContext.BakuHotels.AnyAsync(x => x.Name.ToLower().Equals(bakuHotel.Name.ToLower()));

            if (isExist)
            {
                ModelState.AddModelError("Title", "This Hotel already exists");

                return View();
            }

            await _dbContext.BakuHotels.AddAsync(bakuHotel);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var bakuHotel = await _dbContext.BakuHotels.FindAsync(id);

            if (bakuHotel == null) return NotFound();

            _dbContext.BakuHotels.Remove(bakuHotel);

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();

            var bakuHotel = await _dbContext.BakuHotels.FindAsync(id);

            if (bakuHotel == null) return NotFound();

            return View(bakuHotel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, BakuHotel bakuHotel)
        {
            if (id == null) return NotFound();

            if (id != bakuHotel.Id) return BadRequest();

            var existBakuHotel = await _dbContext.BakuHotels.FindAsync(id);

            existBakuHotel.Name = bakuHotel.Name;

            existBakuHotel.ImageUrl = bakuHotel.ImageUrl;
            existBakuHotel.ImageUrl_2 = bakuHotel.ImageUrl_2;
            existBakuHotel.ImageUrl_3 = bakuHotel.ImageUrl_3;
            existBakuHotel.ImageUrl_4 = bakuHotel.ImageUrl_4;

            existBakuHotel.Price = bakuHotel.Price;

            existBakuHotel.Location = bakuHotel.Location;

            existBakuHotel.ShortDescription = bakuHotel.ShortDescription;

            existBakuHotel.LongDescription = bakuHotel.LongDescription;

            existBakuHotel.Rate = bakuHotel.Rate;

            existBakuHotel.Reviews = bakuHotel.Reviews;

            existBakuHotel.ExploreId = bakuHotel.ExploreId;

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
    }
}

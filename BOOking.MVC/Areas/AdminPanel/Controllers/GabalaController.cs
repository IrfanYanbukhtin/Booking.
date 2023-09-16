using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BOOking.MVC.Areas.AdminPanel.Controllers
{
    public class GabalaController : AdminController
    {
        private readonly AppDbContext _dbContext;

        public GabalaController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var gabalaHotels = await _dbContext.GabalaHotels.ToListAsync();

            return View(gabalaHotels);
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id == null) return NotFound();

            var gabalaHotel = await _dbContext.GabalaHotels.FirstOrDefaultAsync(x => x.Id == id);

            if (gabalaHotel == null) return NotFound();

            return View(gabalaHotel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GabalaHotel gabalaHotel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _dbContext.GabalaHotels.AnyAsync(x => x.Name.ToLower().Equals(gabalaHotel.Name.ToLower()));

            if (isExist)
            {
                ModelState.AddModelError("Title", "This Hotel already exists");

                return View();
            }

            await _dbContext.GabalaHotels.AddAsync(gabalaHotel);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var gabalaHotel = await _dbContext.GabalaHotels.FindAsync(id);

            if (gabalaHotel == null) return NotFound();

            _dbContext.GabalaHotels.Remove(gabalaHotel);

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();

            var gabalaHotel = await _dbContext.GabalaHotels.FindAsync(id);

            if (gabalaHotel == null) return NotFound();

            return View(gabalaHotel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, GabalaHotel gabalaHotel)
        {
            if (id == null) return NotFound();

            if (id != gabalaHotel.Id) return BadRequest();

            var existGabalaHotel = await _dbContext.GabalaHotels.FindAsync(id);

            existGabalaHotel.Name = gabalaHotel.Name;

            existGabalaHotel.ImageUrl = gabalaHotel.ImageUrl;
            existGabalaHotel.ImageUrl_2 = gabalaHotel.ImageUrl_2;
            existGabalaHotel.ImageUrl_3 = gabalaHotel.ImageUrl_3;
            existGabalaHotel.ImageUrl_4 = gabalaHotel.ImageUrl_4;

            existGabalaHotel.Price = gabalaHotel.Price;

            existGabalaHotel.Location = gabalaHotel.Location;

            existGabalaHotel.ShortDescription = gabalaHotel.ShortDescription;

            existGabalaHotel.LongDescription = gabalaHotel.LongDescription;

            existGabalaHotel.Rate = gabalaHotel.Rate;

            existGabalaHotel.Reviews = gabalaHotel.Reviews;

            existGabalaHotel.ExploreId = gabalaHotel.ExploreId;

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
    }
}

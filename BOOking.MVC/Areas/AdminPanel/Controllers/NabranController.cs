using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BOOking.MVC.Areas.AdminPanel.Controllers
{
    public class NabranController : AdminController
    {
        private readonly AppDbContext _dbContext;

        public NabranController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var nabranHotels = await _dbContext.NabranHotels.ToListAsync();

            return View(nabranHotels);
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id == null) return NotFound();

            var nabranHotel = await _dbContext.NabranHotels.FirstOrDefaultAsync(x => x.Id == id);

            if (nabranHotel == null) return NotFound();

            return View(nabranHotel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NabranHotel nabranHotel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _dbContext.NabranHotels.AnyAsync(x => x.Name.ToLower().Equals(nabranHotel.Name.ToLower()));

            if (isExist)
            {
                ModelState.AddModelError("Title", "This Hotel already exists");

                return View();
            }

            await _dbContext.NabranHotels.AddAsync(nabranHotel);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var nabranHotel = await _dbContext.NabranHotels.FindAsync(id);

            if (nabranHotel == null) return NotFound();

            _dbContext.NabranHotels.Remove(nabranHotel);

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();

            var nabranHotel = await _dbContext.NabranHotels.FindAsync(id);

            if (nabranHotel == null) return NotFound();

            return View(nabranHotel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, NabranHotel nabranHotel)
        {
            if (id == null) return NotFound();

            if (id != nabranHotel.Id) return BadRequest();

            var existNabranHotel = await _dbContext.NabranHotels.FindAsync(id);

            existNabranHotel.Name = nabranHotel.Name;

            existNabranHotel.ImageUrl = nabranHotel.ImageUrl;
            existNabranHotel.ImageUrl_2 = nabranHotel.ImageUrl_2;
            existNabranHotel.ImageUrl_3 = nabranHotel.ImageUrl_3;
            existNabranHotel.ImageUrl_4 = nabranHotel.ImageUrl_4;

            existNabranHotel.Price = nabranHotel.Price;

            existNabranHotel.Location = nabranHotel.Location;

            existNabranHotel.ShortDescription = nabranHotel.ShortDescription;

            existNabranHotel.LongDescription = nabranHotel.LongDescription;

            existNabranHotel.Rate = nabranHotel.Rate;

            existNabranHotel.Reviews = nabranHotel.Reviews;

            existNabranHotel.ExploreId = nabranHotel.ExploreId;

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
    }
}

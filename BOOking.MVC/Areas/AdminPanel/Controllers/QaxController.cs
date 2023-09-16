using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BOOking.MVC.Areas.AdminPanel.Controllers
{
    public class QaxController : AdminController
    {
        private readonly AppDbContext _dbContext;

        public QaxController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var qaxHotels = await _dbContext.QaxHotels.ToListAsync();

            return View(qaxHotels);
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id == null) return NotFound();

            var qaxHotel = await _dbContext.QaxHotels.FirstOrDefaultAsync(x => x.Id == id);

            if (qaxHotel == null) return NotFound();

            return View(qaxHotel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(QaxHotel qaxHotel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _dbContext.QaxHotels.AnyAsync(x => x.Name.ToLower().Equals(qaxHotel.Name.ToLower()));

            if (isExist)
            {
                ModelState.AddModelError("Title", "This Hotel already exists");

                return View();
            }

            await _dbContext.QaxHotels.AddAsync(qaxHotel);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var qaxHotel = await _dbContext.QaxHotels.FindAsync(id);

            if (qaxHotel == null) return NotFound();

            _dbContext.QaxHotels.Remove(qaxHotel);

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();

            var qaxHotel = await _dbContext.QaxHotels.FindAsync(id);

            if (qaxHotel == null) return NotFound();

            return View(qaxHotel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,QaxHotel qaxHotel)
        {
            if (id == null) return NotFound();

            if (id != qaxHotel.Id) return BadRequest();

            var existQaxHotel = await _dbContext.QaxHotels.FindAsync(id);

            existQaxHotel.Name = qaxHotel.Name;

            existQaxHotel.ImageUrl = qaxHotel.ImageUrl;
            existQaxHotel.ImageUrl_2 = qaxHotel.ImageUrl_2;
            existQaxHotel.ImageUrl_3 = qaxHotel.ImageUrl_3;
            existQaxHotel.ImageUrl_4 = qaxHotel.ImageUrl_4;

            existQaxHotel.Price = qaxHotel.Price;

            existQaxHotel.Location = qaxHotel.Location;

            existQaxHotel.ShortDescription = qaxHotel.ShortDescription;

            existQaxHotel.LongDescription = qaxHotel.LongDescription;

            existQaxHotel.Rate = qaxHotel.Rate;

            existQaxHotel.Reviews = qaxHotel.Reviews;

            existQaxHotel.ExploreId = qaxHotel.ExploreId;

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
    }
}

using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BOOking.MVC.Areas.AdminPanel.Controllers
{
    public class GanjaController : AdminController
    {
        private readonly AppDbContext _dbContext;

        public GanjaController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var ganjaHotels = await _dbContext.GanjaHotels.ToListAsync();

            return View(ganjaHotels);
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id == null) return NotFound();

            var ganjaHotel = await _dbContext.GanjaHotels.FirstOrDefaultAsync(x => x.Id == id);

            if (ganjaHotel == null) return NotFound();

            return View(ganjaHotel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GanjaHotel ganjaHotel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _dbContext.GanjaHotels.AnyAsync(x => x.Name.ToLower().Equals(ganjaHotel.Name.ToLower()));

            if (isExist)
            {
                ModelState.AddModelError("Title", "This Hotel already exists");

                return View();
            }

            await _dbContext.GanjaHotels.AddAsync(ganjaHotel);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var ganjaHotel = await _dbContext.GanjaHotels.FindAsync(id);

            if (ganjaHotel == null) return NotFound();

            _dbContext.GanjaHotels.Remove(ganjaHotel);

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();

            var ganjaHotel = await _dbContext.GanjaHotels.FindAsync(id);

            if (ganjaHotel == null) return NotFound();

            return View(ganjaHotel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,GanjaHotel ganjaHotel)
        {
            if (id == null) return NotFound();

            if (id != ganjaHotel.Id) return BadRequest();

            var existGanjaHotel = await _dbContext.GanjaHotels.FindAsync(id);

            existGanjaHotel.Name = ganjaHotel.Name;

            existGanjaHotel.ImageUrl = ganjaHotel.ImageUrl;
            existGanjaHotel.ImageUrl_2 = ganjaHotel.ImageUrl_2;
            existGanjaHotel.ImageUrl_3 = ganjaHotel.ImageUrl_3;
            existGanjaHotel.ImageUrl_4 = ganjaHotel.ImageUrl_4;

            existGanjaHotel.Price = ganjaHotel.Price;

            existGanjaHotel.Location = ganjaHotel.Location;

            existGanjaHotel.ShortDescription = ganjaHotel.ShortDescription;

            existGanjaHotel.LongDescription = ganjaHotel.LongDescription;

            existGanjaHotel.Rate = ganjaHotel.Rate;

            existGanjaHotel.Reviews = ganjaHotel.Reviews;

            existGanjaHotel.ExploreId = ganjaHotel.ExploreId;

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
    }
}

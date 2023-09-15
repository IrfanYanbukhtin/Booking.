using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using BOOking.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BOOking.MVC.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _dbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var staysBackImage = _dbContext.StaysBackImages.ToList();
            var explore = _dbContext.Explores.ToList();
            var trending = _dbContext.TrendingDestinations.ToList();
            var browse = _dbContext.Browses.ToList();
            var quickCity = _dbContext.QuickCities.ToList();
            var quickRomance = _dbContext.QuickRomances.ToList();
            var quickBeach = _dbContext.quickBeaches.ToList();
            var quickOutdoors = _dbContext.quickOutdoors.ToList();
            var quickRelaxes = _dbContext.QuickRelaxes.ToList();
            var bakuHotels = _dbContext.BakuHotels.Take(15).FirstOrDefault();

            var model = new HomeViewModel
            {
                StaysBackImages = staysBackImage,
                Explores = explore,
                TrendingDestinations = trending,
                Browses = browse,
                QuickCities = quickCity,
                QuickRomances = quickRomance,
                QuickBeaches = quickBeach,
                QuickOutdoors = quickOutdoors,
                QuickRelaxes = quickRelaxes,
                BakuHotels = bakuHotels,
            };

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

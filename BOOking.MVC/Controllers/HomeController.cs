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

            var model = new HomeViewModel
            {
                StaysBackImages = staysBackImage,
                Explores = explore,
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
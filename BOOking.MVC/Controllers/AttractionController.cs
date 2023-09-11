using BOOking.DAL.DataContext;
using BOOking.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class AttractionController : Controller
    {
        public readonly AppDbContext _dbContext;

        public AttractionController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {


            var model = new AttractionViewModel
            {

            };

            return View(model);
        }
    }
}

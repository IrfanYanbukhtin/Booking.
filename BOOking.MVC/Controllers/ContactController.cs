using BOOking.DAL.DataContext;
using BOOking.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class ContactController : Controller
    {
        public readonly AppDbContext _dbContext;

        public ContactController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var header = _dbContext.Headers.ToList();

            var model = new ContactViewModel
            {
                Headers = header,
            };

            return View(model);
        }
    }
}

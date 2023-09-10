using BOOking.DAL.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BOOking.MVC.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        public readonly AppDbContext _dbContext;

        public HeaderViewComponent(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var header = _dbContext.Headers.Include(x => x.HeaderNavigations).ToList();

            return View(header);
        }
    }
}

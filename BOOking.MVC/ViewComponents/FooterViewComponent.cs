using BOOking.DAL.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BOOking.MVC.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public readonly AppDbContext _dbContext;

        public FooterViewComponent(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var footer = _dbContext.Footers.Include(x => x.FooterFirstNavs)
                .Include(x => x.FooterSecondNavs)
                .Include(x => x.FooterThirdNavs)
                .Include(x => x.FooterFourthNavs)
                .Include(x => x.FooterFifthtNavs).
                Include(x => x.Partners).ToList();

            return View(footer);
        }
    }
}

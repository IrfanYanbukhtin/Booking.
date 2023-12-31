﻿using BOOking.DAL.DataContext;
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
            var moreExplore = _dbContext.MoreExplores.Take(8).ToList();
            var paris = _dbContext.Paris.Take(8).ToList();
            var asia = _dbContext.Asias.Take(8).ToList();
            var africa = _dbContext.Africas.Take(8).ToList();
            var header = _dbContext.Headers.ToList();
            var footer = _dbContext.Footers.ToList();
            var partner = _dbContext.Partners.ToList();

            var model = new AttractionViewModel
            {
                MoreExplores = moreExplore,
                Paris = paris,
                Asias = asia,
                Africas = africa,
                Headers = header,
                Footers = footer,
                Partners = partner,

            };

            return View(model);
        }
    }
}

﻿using BOOking.DAL.DataContext;
using BOOking.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class BakuController : Controller
    {
        public readonly AppDbContext _dbContext;

        public BakuController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var bakuHotel = _dbContext.BakuHotels.ToList();
            var header = _dbContext.Headers.ToList();

            var model = new BakuViewModel
            {
                BakuHotels = bakuHotel,
                Headers = header,
            };

            return View(model);
        }
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var bakuHotel = _dbContext.BakuHotels.Find(id);

            return View(bakuHotel);
        }
    }
}

using BOOking.DAL.DataContext;
using BOOking.DAL.Entities;
using BOOking.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOking.MVC.Controllers
{
    public class RentalController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _airportCount;
        private readonly int _citiesCount;

        public RentalController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _citiesCount = _dbContext.CitiesWorlwides.Count();
            _airportCount = _dbContext.AirportWorldWides.Count();
        }
        public IActionResult Index()
        {
            ViewBag.AirportCount = _airportCount;
            ViewBag.CitiesCount = _citiesCount;

            var cities = _dbContext.CitiesWorlwides.Take(4).ToList();
            var airport = _dbContext.AirportWorldWides.Take(4).ToList();

            var carhire = _dbContext.CarHires.ToList();
            var AirportInCountry = _dbContext.AirportInCountries.ToList();
            var AirportWorldWide = _dbContext.AirportWorldWides.ToList();
            var CitiesWorldwide = _dbContext.CitiesWorlwides.ToList();

            var model = new RentalViewModel
            {
                CarHires= carhire,
                AirportWorldWides = AirportWorldWide,
                AirportInCountries = AirportInCountry,
                CitiesWorlwides = CitiesWorldwide,
            };

            return View(model);
        }

        public IActionResult LoadAirports(int skip)
        {
            if (skip >= _airportCount) return BadRequest();
            var airports = _dbContext.AirportInCountries.Skip(skip).Take(4).ToList();

            return View("rental", airports);
        }

        public IActionResult LoadCities(int skip)
        {
            if (skip >= _citiesCount) return BadRequest();
            var cities = _dbContext.CitiesWorlwides.Skip(skip).Take(4).ToList();

            return View("rental", cities);
        }
    }
}

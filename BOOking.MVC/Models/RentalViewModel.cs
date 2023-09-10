using BOOking.DAL.Entities;

namespace BOOking.MVC.Models
{
    public class RentalViewModel
    {
        public List<CarHire> CarHires = new List<CarHire>();
        public List<AirportInCountry> AirportInCountries = new List<AirportInCountry>();
        public List<AirportWorldWide> AirportWorldWides = new List<AirportWorldWide>();
        public List<CitiesWorlwide> CitiesWorlwides = new List<CitiesWorlwide>();

    }
}

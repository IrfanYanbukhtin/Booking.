using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOking.DAL.Entities
{
    public class CarHire : TimeStample
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<AirportInCountry> AirportInCountries { get; set; }
        public ICollection<CitiesWorlwide> CitiesWorlwides { get; set; }
        public ICollection<AirportWorldWide> AirportWorldWides { get; set; }

    }
}

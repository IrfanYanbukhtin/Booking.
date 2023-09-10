using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOking.DAL.Entities
{
    public class TrendingDestinations : TimeStample
    {
        public string Country { get; set; }
        public string Flag { get; set; }
        public string ImageUrl { get; set; }
        public string? PageUrl { get; set; }
    }
}

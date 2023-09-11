using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOking.DAL.Entities
{
    public class Explore : TimeStample
    {
        public string Title { get; set; }
        public string PropertiesCount { get; set; }
        public string ImageUrl { get; set; }
        public string? PageUrl { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
    }
}

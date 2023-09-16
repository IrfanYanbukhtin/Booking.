using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOking.DAL.Entities
{
    public class GuestHomeLove : TimeStample
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Rate { get; set; }
        public string Reviews { get; set; }
        public string Price { get; set; }
        public string Opinion { get; set; }
    }
}

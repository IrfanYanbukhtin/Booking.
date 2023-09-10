﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOking.DAL.Entities
{
    public class AirportWorldWide : TimeStample
    {
        public string Country { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int CarHireId { get; set; }
        public CarHire CarHire { get; set; }
    }
}

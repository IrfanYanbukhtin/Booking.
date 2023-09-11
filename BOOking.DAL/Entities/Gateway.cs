using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOking.DAL.Entities
{
    public class Gateway : TimeStample
    {
        public string ImageUrl { get; set; }
        public string Price {get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOking.DAL.Entities
{
    public class QuickRelax : TimeStample
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Location { get; set; }
        public string PageUrl { get; set; }
    }
}

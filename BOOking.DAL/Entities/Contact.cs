using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOking.DAL.Entities
{
    public class Contact : TimeStample
    {
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string? PinterestUrl { get; set; }
        public string TelegramUrl { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
    }
}

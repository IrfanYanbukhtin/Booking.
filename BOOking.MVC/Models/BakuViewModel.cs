using BOOking.DAL.Entities;

namespace BOOking.MVC.Models
{
    public class BakuViewModel
    {
        public List<BakuHotel> BakuHotels  { get; set; }
        public List<Header> Headers { get; set; }
        public List<Partner> Partners { get; set; }

    }
}

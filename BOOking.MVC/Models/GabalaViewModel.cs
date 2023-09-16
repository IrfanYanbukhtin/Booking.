using BOOking.DAL.Entities;

namespace BOOking.MVC.Models
{
    public class GabalaViewModel
    {
        public List<GabalaHotel> GabalaHotels = new List<GabalaHotel>();
        public List<Header> Headers { get; set; }
    }
}

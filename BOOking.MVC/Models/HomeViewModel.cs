using BOOking.DAL.Entities;

namespace BOOking.MVC.Models
{
    public class HomeViewModel
    {
        public List<StaysBackImage> StaysBackImages = new List<StaysBackImage>();

        public List<Explore> Explores = new List<Explore>();
        public List<TrendingDestination> TrendingDestinations = new List<TrendingDestination>();
        public List<Browse> Browses = new List<Browse>();
        public List<QuickCity> QuickCities = new List<QuickCity>();
        public List<QuickRomance> QuickRomances = new List<QuickRomance>();
        public List<QuickBeach> QuickBeaches = new List<QuickBeach>();
        public List<QuickOutdoors> QuickOutdoors = new List<QuickOutdoors>();
        public List<QuickRelax> QuickRelaxes = new List<QuickRelax>();
        public List<BakuHotel> BakuHotels = new List<BakuHotel>();
        public List<GuestHomeLove> GuestHomeLoves = new List<GuestHomeLove>();
        public List<Discount> Discounts { get; set; }
        public List<Discover> Discovers { get; set; }   
       
    }
}

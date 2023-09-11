using BOOking.DAL.Entities;

namespace BOOking.MVC.Data
{
    public interface IAllHotels
    {
        IEnumerable<Hotel> Hotels { get;  }
        IEnumerable<Hotel> getTopRevHotel { get; }
        Hotel getobjectHotel (int hotelid);
    }
}

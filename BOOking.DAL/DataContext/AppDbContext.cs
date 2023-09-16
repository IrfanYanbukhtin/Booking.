using BOOking.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOking.DAL.DataContext
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Header> Headers { get; set; }
        public DbSet<HeaderNavigation> HeaderNavigations { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<FooterFirstNav> FooterFirstNavs { get; set; }
        public DbSet<FooterSecondNav> FooterSecondNavs { get; set; }
        public DbSet<FooterThirdNav> FooterThirdNavs { get; set; }
        public DbSet<FooterFourthNav> FooterFourthNavs { get; set; }
        public DbSet<FooterFifthNav> FooterFifthNavs { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<StaysBackImage> StaysBackImages { get; set; }
        public DbSet<CarHire> CarHires { get; set; }
        public DbSet<AirportInCountry> AirportInCountries { get; set; }
        public DbSet<AirportWorldWide> AirportWorldWides { get; set; }
        public DbSet<CitiesWorlwide> CitiesWorlwides { get; set; }
        public DbSet<Explore> Explores { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Gateway> Gateways { get; set; }
        public DbSet<MoreExplore> MoreExplores { get; set;}
        public DbSet<Paris> Paris { get; set; }
        public DbSet<Asia> Asias  { get; set; }
        public DbSet<Africa> Africas { get; set; }
        public DbSet<GabalaHotel> GabalaHotels { get; set; }
        public DbSet<ShekiHotel> ShekiHotels { get; set; }
        public DbSet<NabranHotel> NabranHotels { get; set; }
        public DbSet<GanjaHotel> GanjaHotels { get; set; }
        public DbSet<SamaxiHotel> SamaxiHotels { get; set; }
        public DbSet<ShahdagHotel> ShahdagHotels { get; set; }
        public DbSet<BakuHotel> BakuHotels { get; set; }
        public DbSet<QaxHotel> QaxHotels { get; set; }
        public DbSet<QusarHotel> QusarHotels { get; set; }
        public DbSet<TrendingDestination> TrendingDestinations { get; set; }
        public DbSet<Browse> Browses { get; set; }
        public DbSet<QuickCity> QuickCities { get; set; }
        public DbSet<QuickRomance> QuickRomances { get; set;}
        public DbSet<QuickBeach> quickBeaches { get; set; }
        public DbSet<QuickOutdoors> quickOutdoors { get; set;}
        public DbSet<QuickRelax> QuickRelaxes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}

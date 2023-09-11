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
    }
}

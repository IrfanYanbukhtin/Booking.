
namespace BOOking.DAL.Entities
{
    public class Footer : TimeStample
    {
        public string CreatedBy { get; set; }
        public ICollection<FooterFirstNav> FooterFirstNavs { get; set; }
        public ICollection<FooterSecondNav> FooterSecondNavs { get; set; }
        public ICollection<FooterThirdNav> FooterThirdNavs { get; set; }
        public ICollection<FooterFourthNav> FooterFourthNavs { get; set; }
        public ICollection<FooterFifthNav> FooterFifthtNavs { get; set; }
        public ICollection<Partner> Partners { get; set; }
    }
}

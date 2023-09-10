
namespace BOOking.DAL.Entities
{
    public class FooterSecondNav : TimeStample
    {
        public string PageTitle { get; set; }
        public string? PageUrl { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }
    }
}

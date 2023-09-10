
namespace BOOking.DAL.Entities
{
    public class HeaderNavigation : TimeStample
    {
        public string Title { get; set; }
        public string TitleUrl { get; set; }
        public string LogoIcon { get; set; }
        public int HeaderId { get; set; }
        public Header Header { get; set; }
    }
}

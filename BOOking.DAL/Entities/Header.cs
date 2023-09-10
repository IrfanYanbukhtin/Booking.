
namespace BOOking.DAL.Entities
{
    public class Header : TimeStample
    {
        public string Title { get; set; }
        public string Property_text { get; set; }
        public ICollection<HeaderNavigation> HeaderNavigations { get; set; }
    }
}

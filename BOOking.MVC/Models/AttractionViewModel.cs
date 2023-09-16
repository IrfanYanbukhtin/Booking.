using BOOking.DAL.Entities;

namespace BOOking.MVC.Models
{
    public class AttractionViewModel
    {
        public List<MoreExplore> MoreExplores = new List<MoreExplore>();
        public List<Paris> Paris = new List<Paris>();
        public List<Asia> Asias = new List<Asia>();
        public List<Africa> Africas = new List<Africa>();
        public List<Header> Headers = new List<Header>();
        public List<Footer> Footers = new List<Footer>();
        public List<Partner> Partners = new List<Partner>();
    }
}

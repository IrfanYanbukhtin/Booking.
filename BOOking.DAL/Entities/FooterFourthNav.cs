﻿
namespace BOOking.DAL.Entities
{
    public class FooterFourthNav : TimeStample
    {
        public string PageTitle { get; set; }
        public string? PageUrl { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }
    }
}

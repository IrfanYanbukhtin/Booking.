﻿using BOOking.DAL.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BOOking.MVC.Areas.AdminPanel.Models
{
    public class BakuHotelCreateViewModel
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }
        public string? ImageUrl_2 { get; set; }
        public string? ImageUrl_3 { get; set; }
        public string? ImageUrl_4 { get; set; }
        public string Reviews { get; set; }
        public double Rate { get; set; }
        public string Location { get; set; }
        public string Price { get; set; }
        public bool? Available { get; set; }
        public int ExploreId { get; set; }
        public Explore Explore { get; set; }
    }
}

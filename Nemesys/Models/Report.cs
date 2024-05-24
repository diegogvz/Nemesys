﻿namespace Nemesys.Models
{
    public class Report
    {
        public int ReportID { get; set; }
        public DateTime DateOfReport { get; set; }
       
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime HazardDateTime { get; set; }
        public string HazardType { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string ImageUrl { get; set; }
        public int Upvotes { get; set; }
    }
}
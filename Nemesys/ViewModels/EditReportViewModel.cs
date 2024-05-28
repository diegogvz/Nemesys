using System;
using System.ComponentModel.DataAnnotations;

namespace Nemesys.ViewModels
{
    public class EditReportViewModel
    {
        public int ReportID { get; set; }

        [Required]
        [Display(Name = "Date of Report")]
        public DateTime DateOfReport { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Location")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Hazard Date and Time")]
        public DateTime HazardDateTime { get; set; }

        [Required]
        [Display(Name = "Hazard Type")]
        public string HazardType { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }

        public string? ImageUrl { get; set; }

        [Display(Name = "Image")]
        public IFormFile? ImageToUpload { get; set; } 

        [Required]
        public int Upvotes { get; set; }
    }
}


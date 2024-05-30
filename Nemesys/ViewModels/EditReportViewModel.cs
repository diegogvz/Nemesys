using System.ComponentModel.DataAnnotations;

namespace Nemesys.ViewModels
{
    public class EditReportViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Date of Report")]
        public DateTime DateOfReport { get; set; }
        public string Title { get; set; }
        [Display(Name = "Location")]
        public string? Location { get; set; }
        [Display(Name = "Hazard Date")]
        public DateTime HazardDateTime { get; set; }
        [Display(Name = "Hazard Type")]
        public string HazardType { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } = "OPEN";
        public string? ImageUrl { get; set; }
        [Display(Name = "Photo of the issue")]
        public IFormFile? ImageToUpload { get; set; }
        public int Upvotes { get; set; } = 0;
        public bool HasVoted { get; set; }
        public string? UserEmail { get; set; }

        public InvestigationViewModel? Investigation { get; set; }
        public bool IsInvestigationOwner { get; set; }
    }
}

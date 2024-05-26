namespace Nemesys.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class InvestigationViewModel
    {
        public int InvestigationID { get; set; }

        [Required]
        public int ReportID { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 10)]
        public string Description { get; set; }

        [Required]
        public DateTime DateOfAction { get; set; }

        [Required]
        public string Status { get; set; }  

        public string InvestigatorDetails { get; set; }

        public string InvestigatorEmail { get; set; }

        [Phone]
        public string InvestigatorPhone { get; set; }
    }

}
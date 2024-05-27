namespace Nemesys.ViewModels
{
    public class ReportViewModel
    {
        public int Id { get; set; }
        public DateTime DateOfReport { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime HazardDateTime { get; set; }
        public string HazardType { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } = "OPEN";
        public string ImageUrl { get; set; }
        public int Upvotes { get; set; } = 0;
        public bool HasVoted { get; set; }
        public string UserEmail { get; set; }

        public InvestigationViewModel? Investigation { get; set; }
    }
}

namespace Nemesys.Models
{
    public class Investigation
    {
        public int InvestigationID { get; set; }
        public int ReportID { get; set; }
        public Report Report { get; set; }
        public string Description { get; set; }
        public DateTime DateOfAction { get; set; }
        public string InvestigatorEmail { get; set; }
        public string? InvestigatorPhone { get; set; }
    }

}

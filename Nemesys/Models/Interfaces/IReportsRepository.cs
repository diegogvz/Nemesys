using Nemesys.Models;

public interface IReportsRepository
{
    IEnumerable<Report> GetAllReports();
    Report GetReportById(int id);
    void CreateReport(Report report);
    void UpdateReport(Report report);
    void DeleteReport(int id);
}

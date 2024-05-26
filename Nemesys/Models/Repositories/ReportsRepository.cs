using Microsoft.EntityFrameworkCore;
using Nemesys.Data;
using Nemesys.Models;

public class ReportsRepository : IReportsRepository
{
    private readonly ApplicationDbContext _context;

    public ReportsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Report> GetAllReports()
    {
        return _context.Reports.Include(r => r.Investigation).ToList();
    }

    public Report GetReportById(int reportId)
    {
        return _context.Reports.Include(r => r.Investigation).FirstOrDefault(r => r.ReportID == reportId);
    }

    public void CreateReport(Report report)
    {
        _context.Reports.Add(report);
        _context.SaveChanges();
    }

    public void UpdateReport(Report report)
    {
        _context.Reports.Update(report);
        _context.SaveChanges();
    }

    public void DeleteReport(int reportId)
    {
        var report = _context.Reports.FirstOrDefault(r => r.ReportID == reportId);
        if (report != null)
        {
            _context.Reports.Remove(report);
            _context.SaveChanges();
        }
    }
}

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
        return _context.Reports.ToList();
    }

    public Report GetReportById(int id)
    {
        return _context.Reports.Find(id);
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

    public void DeleteReport(int id)
    {
        var report = _context.Reports.Find(id);
        if (report != null)
        {
            _context.Reports.Remove(report);
            _context.SaveChanges();
        }
    }
}

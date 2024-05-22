using Microsoft.AspNetCore.Mvc;
using Nemesys.Models;
using Nemesys.ViewModels;

public class ReportsController : Controller
{
    private readonly IReportsRepository _reportsRepository;
    private readonly ILogger<ReportsController> _logger;

    public ReportsController(
        IReportsRepository reportsRepository,
        ILogger<ReportsController> logger)
    {
        _reportsRepository = reportsRepository;
        _logger = logger;
    }

    public IActionResult Index()
    {
        try
        {
            _logger.LogInformation("Fetching all reports");

            var reports = _reportsRepository.GetAllReports().OrderByDescending(r => r.DateOfReport);
            var model = new ReportListViewModel()
            {
                TotalEntries = reports.Count(),
                Reports = reports.Select(r => new ReportViewModel
                {
                    Id = r.ReportID,
                    DateOfReport = r.DateOfReport,
                    Title = r.Title,
                    Content = r.Content,
                    ImageUrl = r.ImageUrl,
                    Upvotes = r.Upvotes
                }).ToList()
            };

            return View(model);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message, ex);
            return View("Error");
        }
    }

    public IActionResult Details(int id)
    {
        try
        {
            var report = _reportsRepository.GetReportById(id);
            if (report == null)
                return NotFound();

            var model = new ReportViewModel
            {
                Id = report.ReportID,
                DateOfReport = report.DateOfReport,
                Title = report.Title,
                Content = report.Content,
                ImageUrl = report.ImageUrl,
                Upvotes = report.Upvotes
            };

            return View(model);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message, ex);
            return View("Error");
        }
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("DateOfReport, Title, Content, ImageUrl, Upvotes")] ReportViewModel newReport)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var report = new Report
                {
                    DateOfReport = newReport.DateOfReport,
                    Title = newReport.Title,
                    Content = newReport.Content,
                    ImageUrl = newReport.ImageUrl,
                    Upvotes = newReport.Upvotes
                };

                _reportsRepository.CreateReport(report);
                return RedirectToAction("Index");
            }

            return View(newReport);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message, ex);
            return View("Error");
        }
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        try
        {
            var report = _reportsRepository.GetReportById(id);
            if (report == null)
                return NotFound();

            var model = new ReportViewModel
            {
                Id = report.ReportID,
                DateOfReport = report.DateOfReport,
                Title = report.Title,
                Content = report.Content,
                ImageUrl = report.ImageUrl,
                Upvotes = report.Upvotes
            };

            return View(model);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message, ex);
            return View("Error");
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(ReportViewModel updatedReport)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var report = _reportsRepository.GetReportById(updatedReport.Id);
                if (report == null)
                    return NotFound();

                report.DateOfReport = updatedReport.DateOfReport;
                report.Title = updatedReport.Title;
                report.Content = updatedReport.Content;
                report.ImageUrl = updatedReport.ImageUrl;
                report.Upvotes = updatedReport.Upvotes;

                _reportsRepository.UpdateReport(report);
                return RedirectToAction("Index");
            }

            return View(updatedReport);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message, ex);
            return View("Error");
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        try
        {
            var report = _reportsRepository.GetReportById(id);
            if (report == null)
            {
                return NotFound();
            }

            _reportsRepository.DeleteReport(id);
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message, ex);
            return View("Error");
        }
    }
}

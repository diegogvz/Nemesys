using Microsoft.AspNetCore.Authorization;
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
                    Location = r.Location,
                    HazardDateTime = r.HazardDateTime,
                    HazardType = r.HazardType,
                    Description = r.Description,
                    Status = "OPEN",
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
                Location = report.Location,
                HazardDateTime = report.HazardDateTime,
                HazardType = report.HazardType,
                Description = report.Description,
                Status = report.Status,
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

    [Authorize (Roles = "investigator")]
    [HttpGet]
    public IActionResult Create()
    {
        return View(new ReportViewModel());
    }

    [Authorize(Roles = "investigator")]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("DateOfReport, Title, Location, HazardDateTime, HazardType, Description, ImageUrl, Upvotes")] ReportViewModel newReport)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var report = new Report
                {
                    DateOfReport = newReport.DateOfReport,
                    Title = newReport.Title,
                    Location = newReport.Location,
                    HazardDateTime = newReport.HazardDateTime,
                    HazardType = newReport.HazardType,
                    Description = newReport.Description,
                    Status = "OPEN",
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

    [Authorize]
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
                Location = report.Location,
                HazardDateTime = report.HazardDateTime,
                HazardType = report.HazardType,
                Description = report.Description,
                Status = report.Status,
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

    [Authorize]
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
                report.Location = updatedReport.Location;
                report.HazardDateTime = updatedReport.HazardDateTime;
                report.HazardType = updatedReport.HazardType;
                report.Description = updatedReport.Description;
                report.Status = updatedReport.Status;
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

    [Authorize]
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

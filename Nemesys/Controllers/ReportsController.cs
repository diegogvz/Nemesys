using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Nemesys.Models;
using Nemesys.Models.Interfaces;
using Nemesys.Models.Services;
using Nemesys.ViewModels;
using System;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

public class ReportsController : Controller
{
    private readonly IReportsRepository _reportsRepository;
    private readonly ILogger<ReportsController> _logger;
    private readonly UserManager<Nemesys.Models.User> _userManager;
    private readonly IUserVoteRepository _userVoteRepository;
    private readonly IEmailService _emailService;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public ReportsController(
        IReportsRepository reportsRepository,
        IUserVoteRepository userVoteRepository,
        ILogger<ReportsController> logger,
        IEmailService emailService,
        UserManager<Nemesys.Models.User> userManager,
        IWebHostEnvironment webHostEnvironment)
    {
        _reportsRepository = reportsRepository;
        _userVoteRepository = userVoteRepository;
        _logger = logger;
        _emailService = emailService;
        _userManager = userManager;
        _webHostEnvironment = webHostEnvironment;
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
                    Status = r.Status,
                    ImageUrl = r.ImageUrl,
                    Upvotes = r.Upvotes,
                    HasVoted = _userVoteRepository.GetUserVote(User.FindFirstValue(ClaimTypes.NameIdentifier), r.ReportID) != null,
                    Investigation = r.Investigation == null ? null : new InvestigationViewModel
                    {
                        InvestigationID = r.Investigation.InvestigationID,
                        ReportID = r.Investigation.ReportID,
                        Description = r.Investigation.Description,
                        DateOfAction = r.Investigation.DateOfAction,
                        InvestigatorEmail = r.Investigation.InvestigatorEmail,
                        InvestigatorPhone = r.Investigation.InvestigatorPhone
                    }
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

    public async Task<IActionResult> Details(int id)
    {
        try
        {
            var report = _reportsRepository.GetReportById(id);
            if (report == null)
                return NotFound();

            var user = _userManager.FindByIdAsync(report.UserId).Result;
            if (user == null)
                return NotFound();

            var currentUser = await _userManager.GetUserAsync(User);


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
                Upvotes = report.Upvotes,
                UserEmail = user.Email,
                Investigation = report.Investigation == null ? null : new InvestigationViewModel
                {
                    InvestigationID = report.Investigation.InvestigationID,
                    ReportID = report.Investigation.ReportID,
                    Description = report.Investigation.Description,
                    DateOfAction = report.Investigation.DateOfAction,
                    InvestigatorEmail = report.Investigation.InvestigatorEmail,
                    InvestigatorPhone = report.Investigation.InvestigatorPhone,
                },
                IsInvestigationOwner = report.Investigation != null && report.Investigation.InvestigatorEmail == currentUser.Email
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
    [Authorize]
    public IActionResult Create()
    {
        return View(new ReportViewModel());
    }

    [HttpPost]
    [Authorize]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("DateOfReport,Title,Location,HazardDateTime,HazardType,Description,ImageToUpload,Upvotes")] ReportViewModel newReport)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return Unauthorized();
                }

                string uniqueFileName = null;
                if (newReport.ImageToUpload != null)
                {
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images/reports");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + newReport.ImageToUpload.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await newReport.ImageToUpload.CopyToAsync(fileStream);
                    }
                }

                var report = new Report
                {
                    DateOfReport = DateTime.Now,
                    Title = newReport.Title,
                    Location = newReport.Location,
                    HazardDateTime = newReport.HazardDateTime,
                    HazardType = newReport.HazardType,
                    Description = newReport.Description,
                    Status = "OPEN",
                    ImageUrl = uniqueFileName != null ? "/images/reports/" + uniqueFileName : null,
                    Upvotes = newReport.Upvotes,
                    UserId = user.Id,
                    Investigation = null
                };

                _reportsRepository.CreateReport(report);

                // Optional: Send email to investigators
                var investigators = await _userManager.GetUsersInRoleAsync("investigator");
                foreach (var investigator in investigators)
                {
                    var message = $"NEW REPORT \n Created:\n \n Title: {report.Title}\n Location: {report.Location}\n Description: {report.Description}";
                    await _emailService.SendEmailAsync(investigator.Email, "New Report Created", message);
                }

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

            var userId = _userManager.GetUserId(User);
            if (report.UserId != userId)
            {
                return RedirectToAction("AccessDenied", new { message = "You can only edit reports created by yourself" });

            }


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
    public async Task<IActionResult> Edit(ReportViewModel updatedReport)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var report = _reportsRepository.GetReportById(updatedReport.Id);
                if (report == null)
                    return NotFound();

                string uniqueFileName = report.ImageUrl;

                if (updatedReport.ImageToUpload != null)
                {
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images/reports");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + updatedReport.ImageToUpload.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await updatedReport.ImageToUpload.CopyToAsync(fileStream);
                    }

                    // Borrar la imagen anterior del servidor si existe y es diferente de la nueva imagen
                    if (!string.IsNullOrEmpty(report.ImageUrl))
                    {
                        string oldFilePath = Path.Combine(_webHostEnvironment.WebRootPath, report.ImageUrl.TrimStart('/'));
                        if (System.IO.File.Exists(oldFilePath))
                        {
                            System.IO.File.Delete(oldFilePath);
                        }
                    }

                    uniqueFileName = "/images/reports/" + uniqueFileName; 
                }
                string uniqueLocation = report.Location;
                if(updatedReport.Location!= null)
                {
                    uniqueLocation = updatedReport.Location;
                } 

                report.DateOfReport = updatedReport.DateOfReport;
                report.Title = updatedReport.Title;
                report.Location = uniqueLocation;
                report.HazardDateTime = updatedReport.HazardDateTime;
                report.HazardType = updatedReport.HazardType;
                report.Description = updatedReport.Description;
                report.Status = updatedReport.Status;
                report.ImageUrl = uniqueFileName; 

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

            var userId = _userManager.GetUserId(User);
            if (report.UserId != userId)
            {
                return RedirectToAction("AccessDenied", new { message = "You can only delete reports created by yourself" });
            }

            _reportsRepository.DeleteReport(id);
            return RedirectToAction("MyReports");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message, ex);
            return View("Error");
        }
    }
    public ActionResult AccessDenied(string message)
    {
        return View("AccessDenied", (object)message);
    }

    [HttpPost]
    [Authorize]
    public IActionResult Upvote(int id)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var userVote = _userVoteRepository.GetUserVote(userId, id);

        if (userVote == null)
        {
            // User has not voted yet, add vote
            var report = _reportsRepository.GetReportById(id);
            if (report != null)
            {
                report.Upvotes += 1;
                _reportsRepository.UpdateReport(report);
                _userVoteRepository.AddUserVote(new UserVote { UserId = userId, ReportID = id });
            }
        }
        else
        {
            // User has already voted, remove vote
            var report = _reportsRepository.GetReportById(id);
            if (report != null)
            {
                report.Upvotes -= 1;
                _reportsRepository.UpdateReport(report);
                _userVoteRepository.RemoveUserVote(userVote);
            }
        }

        return RedirectToAction("Index");
    }

    [Authorize(Roles = "investigator, reporter")]
    public IActionResult MyReports()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var reports = _reportsRepository.GetAllReports().Where(r => r.UserId == userId);
        var reportViewModels = reports.Select(r => new ReportViewModel
        {
            Id = r.ReportID,
            DateOfReport = r.DateOfReport,
            Title = r.Title,
            Location = r.Location,
            HazardDateTime = r.HazardDateTime,
            HazardType = r.HazardType,
            Description = r.Description,
            Status = r.Status,
            ImageUrl = r.ImageUrl,
            Upvotes = r.Upvotes,
            HasVoted = _userVoteRepository.GetUserVote(userId, r.ReportID) != null
        }).ToList();

        var model = new ReportListViewModel
        {
            Reports = reportViewModels,
            TotalEntries = reportViewModels.Count
        };

        return View(model);
    }


}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nemesys.Models;
using Nemesys.ViewModels;

namespace Nemesys.Controllers
{
    public class HallOfFameController : Controller
    {

        private readonly IReportsRepository _reportsRepository;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<HallOfFameController> _logger;


        public HallOfFameController(IReportsRepository reportsRepository, UserManager<User> userManager, ILogger<HallOfFameController> logger)
        {

            _reportsRepository = reportsRepository;
            _userManager = userManager;
            _logger = logger;

        }

        public async Task<IActionResult> Index()
        {
            try {
                var currentYear = DateTime.Now.Year;
                var reports = _reportsRepository.GetAllReports().Where(r => r.DateOfReport.Year == currentYear).ToList();

                var userReportStats = reports.GroupBy(r => r.UserId).Select(g => new UserHallOfFameViewModel
                {
                    UserName = _userManager.FindByIdAsync(g.Key).Result.UserName,
                    TotalReports = g.Count(),
                    TotalUpvotes = g.Sum(r => r.Upvotes),
                    getRatioUpvotesReport = Math.Round(g.Sum(r => r.Upvotes) / (double)g.Count(), 2),
                }).OrderByDescending(u => u.getRatioUpvotesReport).ToList();
                return View(userReportStats);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return View("Error");
            }

        }

    }
}
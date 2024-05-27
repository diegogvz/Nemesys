using Nemesys.Models;

namespace Nemesys.Controllers
{
    public class HallOfFameController : Controller{
        
        private readonly IReportsRepository _reportsRepository;
        private readonly UserManager<User> _userManager;

        public HallOfFameController(IReportsRepository reportsRepository, UserManager<User userManager){

            _reportsRepository = reportsRepository;
            _userManager = userManager;

        }

        public async Task<IActionResult> Index(){

            var currentYear = DateTime.Now.Year;
            var reports = _reportsRepository.GetAllReports().Where(r => r.DateOfReport.Year == currentYear).ToList();

            var userReportStats = reports.GroupBy(r =>r.UserID).Select(g => new UserHallOfFameViewModel{
                UserName = _userManager.FindByIdAsync(g.key).Result.Username;
                TotalReports = g.count();
                TotalUpvotes = g.Sum(r =>r.upvotes);
                getRatioUpvotesReport = g.Sum(r =>r.upvotes) / (double)g.count();
            })
            OrderByDescending(u => u.getRatioUpvotesReport).ToList();

            return View(userReportStats);
            
        }

    }
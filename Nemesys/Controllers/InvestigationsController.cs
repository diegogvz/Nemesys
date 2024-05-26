namespace Nemesys.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Nemesys.Models;
    using Nemesys.ViewModels;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    
    public class InvestigationsController : Controller
    {
        private readonly IInvestigationsRepository _investigationsRepository;
        private readonly IReportsRepository _reportsRepository;
        private readonly ILogger<InvestigationsController> _logger;
        private readonly UserManager<User> _userManager;

        public InvestigationsController(
            IInvestigationsRepository investigationsRepository,
            IReportsRepository reportsRepository,
            ILogger<InvestigationsController> logger,
            UserManager<User> userManager)
        {
            _investigationsRepository = investigationsRepository;
            _reportsRepository = reportsRepository;
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Create(int reportId)
        {
            var report = _reportsRepository.GetReportById(reportId);
            if (report == null)
            {
                return NotFound();
            }

            var model = new InvestigationViewModel
            {
                ReportID = reportId
            };

            return View(model);
        }

        [Authorize(Roles = "investigator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(InvestigationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return Unauthorized();
                }

                var investigation = new Investigation
                {
                    ReportID = model.ReportID,
                    Description = model.Description,
                    DateOfAction = model.DateOfAction,
                    InvestigatorDetails = user.UserName, // Ajuste aquí
                    InvestigatorEmail = user.Email, // Ajuste aquí
                    InvestigatorPhone = model.InvestigatorPhone
                };

                _investigationsRepository.CreateInvestigation(investigation);

                var report = _reportsRepository.GetReportById(model.ReportID);
                report.Status = model.Status;
                _reportsRepository.UpdateReport(report);

                return RedirectToAction("Details", "Reports", new { id = model.ReportID });
            }

            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
            foreach (var error in errors)
            {
                _logger.LogError(error);
            }

            return View(model);
        }

        [Authorize(Roles = "investigator")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var investigation = _investigationsRepository.GetInvestigationById(id);
            if (investigation == null)
            {
                return NotFound();
            }

            var model = new InvestigationViewModel
            {
                InvestigationID = investigation.InvestigationID,
                ReportID = investigation.ReportID,
                Description = investigation.Description,
                DateOfAction = investigation.DateOfAction,
                InvestigatorDetails = investigation.InvestigatorDetails,
                InvestigatorEmail = investigation.InvestigatorEmail,
                InvestigatorPhone = investigation.InvestigatorPhone,
                Status = investigation.Report.Status // Asegúrate de inicializar el campo Status
            };

            return View(model);
        }

        [Authorize(Roles = "investigator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(InvestigationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var investigation = _investigationsRepository.GetInvestigationById(model.InvestigationID);
                if (investigation == null)
                {
                    return NotFound();
                }

                investigation.Description = model.Description;
                investigation.DateOfAction = model.DateOfAction;
                investigation.InvestigatorPhone = model.InvestigatorPhone;
                investigation.InvestigatorDetails = model.InvestigatorDetails;
                investigation.InvestigatorEmail = model.InvestigatorEmail;

                // Actualizar el status del reporte asociado
                var report = _reportsRepository.GetReportById(model.ReportID);
                report.Status = model.Status;
                _reportsRepository.UpdateReport(report);

                _investigationsRepository.UpdateInvestigation(investigation);
                return RedirectToAction("Details", "Reports", new { id = investigation.ReportID });
            }
            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
            foreach (var error in errors)
            {
                _logger.LogError(error);
            }
            return View(model);
        }
        [Authorize(Roles = "investigator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var investigation = _investigationsRepository.GetInvestigationById(id);
            if (investigation == null)
            {
                return NotFound();
            }

            _investigationsRepository.DeleteInvestigation(id);
            return RedirectToAction("Details", "Reports", new { id = investigation.ReportID });
        }

    }

}

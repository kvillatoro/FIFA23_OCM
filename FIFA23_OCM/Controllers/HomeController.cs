using FIFA23_OCM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FIFA23_OCM.Data;
using FIFA23_OCM.Services;
using FIFA23_OCM.ViewModels;

namespace FIFA23_OCM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TeamRosterService _teamRosterService;
        private readonly ITeamBudgetService _teamBudgetService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _teamRosterService = new TeamRosterService();
            _teamBudgetService = new TeamBudgetService();
        }

        public IActionResult Index()
        {
            var teamBudgetPopulator = new TeamBudgetPopulator();
            var teamBudgets = teamBudgetPopulator.PopulateTeamBudgets();
            var viewModel = new TeamBudgetViewModel {TeamBudgets = teamBudgets }; 

            return View(viewModel);
        }

        [HttpGet]
        public JsonResult GetRoster(string teamName)
        {
            try
            {
                PlayerInfoModel[] rosterData = _teamRosterService.GetRoster(teamName);
                return Json(rosterData);
            }
            catch (ArgumentException ex)
            {
                return Json(new { error = ex.Message });
            }
        }

        [HttpGet]
        public JsonResult GetTeamBudget(string teamName) 
        {
            try
            {
                decimal budget = _teamBudgetService.GetTeamBudget(teamName);
                return Json(new { budget = budget });
            }
            catch (ArgumentException ex)
            {
                return Json(new {error = ex.Message});
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using FIFA23_OCM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FIFA23_OCM.Data;

namespace FIFA23_OCM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TeamRosterRepository _teamRosterRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _teamRosterRepository = new TeamRosterRepository();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetRoster(string teamName)
        {
            Roster[] rosterData;
            if(teamName == "FCBarcelona")
            {
                rosterData = _teamRosterRepository.GetFCBarcelonaRoster();
            }
            else if(teamName == "AstonVilla")
            {
                rosterData = _teamRosterRepository.GetAstonVillaRoster();
            }
            else
            {
                return Json(new { error = "Invalid team name" });
            }
            return Json(rosterData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
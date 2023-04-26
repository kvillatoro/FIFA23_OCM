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

        public ActionResult Index()
        {
            var astonVilla = _teamRosterRepository.GetAstonVillaRoster();
            var fcBarcelona = _teamRosterRepository.GetFCBarcelonaRoster();

            var teamRosters = new TeamRostersModel
            {
                AstonVilla = astonVilla,
                FcBarcelona = fcBarcelona
            };

            return View(teamRosters);
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
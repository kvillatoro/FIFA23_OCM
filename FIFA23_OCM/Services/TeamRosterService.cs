using FIFA23_OCM.Data;
using FIFA23_OCM.Models;

namespace FIFA23_OCM.Services
{
    public class TeamRosterService
    {
        private readonly TeamRosterPopulator _teamRosterRepository;

        public TeamRosterService()
        {
            _teamRosterRepository = new TeamRosterPopulator();
        }

        public PlayerInfoModel[] GetRoster(string teamName)
        {
            PlayerInfoModel[] rosterData;
            if(teamName == "Bournemouth") 
            {
                rosterData = _teamRosterRepository.GetBournemouthRoster();
            }
            else if(teamName == "Aston Villa") 
            {
                rosterData = _teamRosterRepository.GetAstonVillaRoster();
            }
            else
            {
                throw new ArgumentException("Invalid team name");
            }
            return rosterData;
        }
    }
}

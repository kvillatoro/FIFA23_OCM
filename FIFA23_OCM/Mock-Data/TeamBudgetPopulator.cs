using FIFA23_OCM.Models;

namespace FIFA23_OCM.Data
{
    public class TeamBudgetPopulator
    {
        public Dictionary<string, decimal> PopulateTeamBudgets()
        {
            return new Dictionary<string, decimal>
            {
                {"Aston Villa", 121000000m },
                {"Bournemouth", 95000000m }
            };
        }
    }
}

using System.Collections.Generic;
using FIFA23_OCM.Data;

namespace FIFA23_OCM.Services
{
    public interface ITeamBudgetService
    {
        decimal GetTeamBudget(string teamName);
    }

    public class TeamBudgetService : ITeamBudgetService
    {
        private readonly Dictionary<string, decimal> _teamBudgets;

        public TeamBudgetService()
        {
            var teamBudgetPopulator = new TeamBudgetPopulator();
            _teamBudgets = teamBudgetPopulator.PopulateTeamBudgets();
        }

        public decimal GetTeamBudget(string teamName)
        {
            if(_teamBudgets.TryGetValue(teamName, out decimal budget))
            {
                return budget;
            }
            else
            {
                throw new ArgumentException($"Invalid team budget: {teamName}");
            }
        }
    }
}

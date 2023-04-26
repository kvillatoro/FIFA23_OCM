using FIFA23_OCM.Models;

namespace FIFA23_OCM.Data
{
    public class TeamRosterRepository
    {
        public Roster[] GetAstonVillaRoster()
        {
            var astonVilla = new[]
            {
                new Roster { PlayerID = 1, FirstName = "Unai", LastName = "Simon" },
                new Roster { PlayerID = 2, FirstName = "Ruben", LastName = "Dias" },
                new Roster { PlayerID = 3, FirstName = "Jules", LastName = "Kounde" },
                new Roster { PlayerID = 4, FirstName = "Ivan", LastName = "Perisic" },
                new Roster { PlayerID = 5, FirstName = "Tyrell", LastName = "Malacia" },
                new Roster { PlayerID = 6, FirstName = "Pablo", LastName = "Gavi" },
                new Roster { PlayerID = 7, FirstName = "Thomas", LastName = "Lemar" },
                new Roster { PlayerID = 8, FirstName = "Kevin", LastName = "De Bruyne" },
                new Roster { PlayerID = 9, FirstName = "Leon", LastName = "Bailey" },
                new Roster { PlayerID = 10, FirstName = "Julian", LastName = "Alvarez" },
                new Roster { PlayerID = 11, FirstName = "Ousmane", LastName = "Dembele" }
            };
            return astonVilla;
        }        
        public Roster[] GetFCBarcelonaRoster()
        {
            var barcelona = new[]
            {
                new Roster { PlayerID = 1, FirstName = "Marc", LastName = "Ter Stegen" },
                new Roster { PlayerID = 2, FirstName = "Gerald", LastName = "Pique" },
                new Roster { PlayerID = 3, FirstName = "Ronald", LastName = "Araujo" },
                new Roster { PlayerID = 4, FirstName = "Jordi", LastName = "Alba" },
                new Roster { PlayerID = 5, FirstName = "Sergi", LastName = "Roberto" },
                new Roster { PlayerID = 6, FirstName = "", LastName = "Pedri" },
                new Roster { PlayerID = 7, FirstName = "Frenkie", LastName = "De Jong" },
                new Roster { PlayerID = 8, FirstName = "", LastName = "Raphinha" },
                new Roster { PlayerID = 9, FirstName = "Robert", LastName = "Lewandowski" },
                new Roster { PlayerID = 10, FirstName = "Ferran", LastName = "Torres" },
                new Roster { PlayerID = 11, FirstName = "Ansu", LastName = "Fati" }
            };
            return barcelona;
        }
    }
}

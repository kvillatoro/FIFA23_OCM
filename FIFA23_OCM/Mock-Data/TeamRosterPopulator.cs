using FIFA23_OCM.Models;

namespace FIFA23_OCM.Data
{
    public class TeamRosterPopulator
    {
        public PlayerInfoModel[] GetAstonVillaRoster()
        {
            var astonVilla = new[]
            {
                new PlayerInfoModel { PlayerID = 1, FirstName = "Unai", LastName = "Simon", SoFIFAURL = "https://sofifa.com/player/230869", Cost = 31800000m },
                new PlayerInfoModel { PlayerID = 2, FirstName = "Ruben", LastName = "Dias", SoFIFAURL = "https://sofifa.com/player/239818", Cost = 92500000m },
                new PlayerInfoModel { PlayerID = 3, FirstName = "Jules", LastName = "Kounde", SoFIFAURL = "https://sofifa.com/player/241486", Cost = 49500000m },
                new PlayerInfoModel { PlayerID = 4, FirstName = "Ivan", LastName = "Perisic", SoFIFAURL = "https://sofifa.com/player/181458", Cost = 9500000m },
                new PlayerInfoModel { PlayerID = 5, FirstName = "Tyrell", LastName = "Malacia", SoFIFAURL = "https://sofifa.com/player/238041", Cost = 20600000m },
                new PlayerInfoModel { PlayerID = 6, FirstName = "Pablo", LastName = "Gavi", SoFIFAURL = "https://sofifa.com/player/264240", Cost = 37400000m },
                new PlayerInfoModel { PlayerID = 7, FirstName = "Thomas", LastName = "Lemar", SoFIFAURL = "https://sofifa.com/player/213565", Cost = 36600000m },
                new PlayerInfoModel { PlayerID = 8, FirstName = "Kevin", LastName = "De Bruyne", SoFIFAURL = "https://sofifa.com/player/192985", Cost = 92500000m },
                new PlayerInfoModel { PlayerID = 9, FirstName = "Leon", LastName = "Bailey", SoFIFAURL = "https://sofifa.com/player/229906", Cost = 24900000m },
                new PlayerInfoModel { PlayerID = 10, FirstName = "Julian", LastName = "Alvarez", SoFIFAURL = "https://sofifa.com/player/246191", Cost = 31000000m },
                new PlayerInfoModel { PlayerID = 11, FirstName = "Ousmane", LastName = "Dembele", SoFIFAURL = "https://sofifa.com/player/231443", Cost = 48200000m }
            };
            return astonVilla;
        }        

        public PlayerInfoModel[] GetBournemouthRoster()
        {
            var bournemouth = new[]
            {
                new PlayerInfoModel { PlayerID = 12, FirstName = "Norberto", LastName = "Neto", SoFIFAURL = "https://sofifa.com/player/194404", Cost = 7300000m },
                new PlayerInfoModel { PlayerID = 13, FirstName = "Adam", LastName = "Smith", SoFIFAURL = "https://sofifa.com/player/190885", Cost = 2700000m },
                new PlayerInfoModel { PlayerID = 14, FirstName = "Chris", LastName = "Mepham", SoFIFAURL = "https://sofifa.com/player/233201", Cost = 200000m },
                new PlayerInfoModel { PlayerID = 15, FirstName = "Marcos", LastName = "Senesi", SoFIFAURL = "https://sofifa.com/player/236506", Cost = 7300000m },
                new PlayerInfoModel { PlayerID = 16, FirstName = "Lloyd", LastName = "Kelly", SoFIFAURL = "https://sofifa.com/player/231512", Cost = 4700000m },
                new PlayerInfoModel { PlayerID = 17, FirstName = "Lewis", LastName = "Cook", SoFIFAURL = "https://sofifa.com/player/224294", Cost = 4700000m },
                new PlayerInfoModel { PlayerID = 18, FirstName = "Jefferson", LastName = "Lerma", SoFIFAURL = "https://sofifa.com/player/213991", Cost = 6000000m },
                new PlayerInfoModel { PlayerID = 19, FirstName = "Ryan", LastName = "Christie", SoFIFAURL = "https://sofifa.com/player/213884", Cost = 3900000m },
                new PlayerInfoModel { PlayerID = 20, FirstName = "Hamed", LastName = "Traore", SoFIFAURL = "https://sofifa.com/player/240787", Cost = 18500000m },
                new PlayerInfoModel { PlayerID = 21, FirstName = "Jaidon", LastName = "Anthony", SoFIFAURL = "https://sofifa.com/player/243669", Cost = 4100000m },
                new PlayerInfoModel { PlayerID = 22, FirstName = "Dominic", LastName = "Solanke", SoFIFAURL = "https://sofifa.com/player/225539", Cost = 6900000m }
            };
            return bournemouth;
        }
    }
}

using FIFA23_OCM.Models;

namespace FIFA23_OCM.Data
{
    public class TeamRosterRepository
    {
        public PlayerInfoModel[] GetAstonVillaRoster()
        {
            var astonVilla = new[]
            {
                new PlayerInfoModel { PlayerID = 1, FirstName = "Unai", LastName = "Simon", SoFIFAURL = "https://sofifa.com/player/230869" },
                new PlayerInfoModel { PlayerID = 2, FirstName = "Ruben", LastName = "Dias", SoFIFAURL = "https://sofifa.com/player/239818" },
                new PlayerInfoModel { PlayerID = 3, FirstName = "Jules", LastName = "Kounde", SoFIFAURL = "https://sofifa.com/player/241486" },
                new PlayerInfoModel { PlayerID = 4, FirstName = "Ivan", LastName = "Perisic", SoFIFAURL = "https://sofifa.com/player/181458" },
                new PlayerInfoModel { PlayerID = 5, FirstName = "Tyrell", LastName = "Malacia", SoFIFAURL = "https://sofifa.com/player/238041" },
                new PlayerInfoModel { PlayerID = 6, FirstName = "Pablo", LastName = "Gavi", SoFIFAURL = "https://sofifa.com/player/264240" },
                new PlayerInfoModel { PlayerID = 7, FirstName = "Thomas", LastName = "Lemar", SoFIFAURL = "https://sofifa.com/player/213565" },
                new PlayerInfoModel { PlayerID = 8, FirstName = "Kevin", LastName = "De Bruyne", SoFIFAURL = "https://sofifa.com/player/192985" },
                new PlayerInfoModel { PlayerID = 9, FirstName = "Leon", LastName = "Bailey", SoFIFAURL = "https://sofifa.com/player/229906" },
                new PlayerInfoModel { PlayerID = 10, FirstName = "Julian", LastName = "Alvarez", SoFIFAURL = "https://sofifa.com/player/246191" },
                new PlayerInfoModel { PlayerID = 11, FirstName = "Ousmane", LastName = "Dembele", SoFIFAURL = "https://sofifa.com/player/231443" }
            };
            return astonVilla;
        }        

        public PlayerInfoModel[] GetBournemouthRoster()
        {
            var bournemouth = new[]
            {
                new PlayerInfoModel { PlayerID = 1, FirstName = "Norberto", LastName = "Neto", SoFIFAURL = "https://sofifa.com/player/194404" },
                new PlayerInfoModel { PlayerID = 2, FirstName = "Adam", LastName = "Smith", SoFIFAURL = "https://sofifa.com/player/190885" },
                new PlayerInfoModel { PlayerID = 3, FirstName = "Chris", LastName = "Mepham", SoFIFAURL = "https://sofifa.com/player/233201" },
                new PlayerInfoModel { PlayerID = 4, FirstName = "Marcos", LastName = "Senesi", SoFIFAURL = "https://sofifa.com/player/236506" },
                new PlayerInfoModel { PlayerID = 5, FirstName = "Lloyd", LastName = "Kelly", SoFIFAURL = "https://sofifa.com/player/231512" },
                new PlayerInfoModel { PlayerID = 6, FirstName = "Lewis", LastName = "Cook", SoFIFAURL = "https://sofifa.com/player/224294" },
                new PlayerInfoModel { PlayerID = 7, FirstName = "Jefferson", LastName = "Lerma", SoFIFAURL = "https://sofifa.com/player/213991" },
                new PlayerInfoModel { PlayerID = 8, FirstName = "Ryan", LastName = "Christie", SoFIFAURL = "https://sofifa.com/player/213884" },
                new PlayerInfoModel { PlayerID = 9, FirstName = "Hamed", LastName = "Traore", SoFIFAURL = "https://sofifa.com/player/240787" },
                new PlayerInfoModel { PlayerID = 10, FirstName = "Jaidon", LastName = "Anthony", SoFIFAURL = "https://sofifa.com/player/243669" },
                new PlayerInfoModel { PlayerID = 11, FirstName = "Dominic", LastName = "Solanke", SoFIFAURL = "https://sofifa.com/player/225539" }
            };
            return bournemouth;
        }
    }
}

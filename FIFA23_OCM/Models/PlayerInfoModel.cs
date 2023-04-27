using System;

namespace FIFA23_OCM.Models
{
    public class PlayerInfoModel
    {
        public int PlayerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SoFIFAURL { get; set; }
        public decimal Cost { get; set; }
    }
}

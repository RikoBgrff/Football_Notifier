using System.Collections;
using System.Collections.Generic;

namespace Football_Notifier.Entities
{
    public class Match : IEntity
    {
        public int Id { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Score Team1_Score { get; set; }
        public Score Team2_Score { get; set; }
    }
}

using System;

namespace Football_Notifier.Entities
{
    public class Score : IEntity
    {
        public int Id {get; set;}
        public Player Scorer { get; set; }
        public DateTime ScoreTime { get; set; }
    }
}

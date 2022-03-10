using System.Collections.Generic;

namespace Football_Notifier.Entities
{
    public class Team : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Player> Players { get; set; }
    }
}

using System.Collections.Generic;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Api.Models
{
    public class Draft : OwnedEntity
    {
        public Draft()
        {
            Rounds = new List<Round>(15);
        }

        public Archetype Archetype { get; set; }
        public List<Round> Rounds { get; set; }
    }
}

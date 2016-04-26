using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Api.Models
{
    public class Draft : OwnedEntity
    {
        public Draft()
        {
            Rounds = new List<Round>(15);
            Complete = false;
        }

        [Required]
        public Archetype Archetype { get; set; }
        public bool Complete { get; set; }
        [NotMapped]
        public bool DraftComplete
        {
            get
            {
                return Rounds.Count(r => r.Selected.Count() == 2) == 15;
            }
        }
        public List<Round> Rounds { get; set; }
    }
}

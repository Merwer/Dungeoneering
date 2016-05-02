using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    public class Draft : OwnedEntity
    {
        public Draft()
        {
            Complete = false;
        }

        [Required]
        public Archetype Archetype { get; set; }
        public virtual List<Round> Rounds { get; set; }

        public virtual List<Match> Matches { get; set; }
        public bool Complete { get; set; }

        [NotMapped]
        public bool DraftComplete
        {
            get
            {
                return Rounds.Count(r => r != null && r.Selected != null && r.Selected.Count() == 2) == 15;
            }
        }
    }
}

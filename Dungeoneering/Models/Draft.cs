using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    public class Draft : OwnedEntity
    {
        public Draft()
        {
            Abandoned = false;
            Rounds = new List<Round>();
            Matches = new List<Match>();
        }

        [Required]
        public Archetype Archetype { get; set; }
        public virtual List<Round> Rounds { get; set; }

        public virtual List<Match> Matches { get; set; }
        public bool Abandoned { get; set; }

        [NotMapped]
        public bool Complete
        {
            get
            {
                return FuncComplete(this);
            }
        }

        [NotMapped]
        public bool DraftComplete
        {
            get
            {
                return FuncDraftComplete(this);
            }
        }

        public static Func<Draft, bool> FuncComplete { get { return (Draft d) => d.Abandoned || d.Matches.Count(m => !m.Win) >= 3 || d.Matches.Count(m => m.Win) >= 12; } }
        public static Func<Draft, bool> FuncDraftComplete { get { return (Draft d) => d.Rounds.Count(r => r != null && r.Selected != null && r.Selected.Count() == 2) == 15; } }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    public class Round : OwnedEntity
    {
        [Required]
        public Draft Draft { get; set; }
        public int RoundId { get; set; }
        public List<int> Options { get; set; }
        public List<int> Selected { get; set; }
    }
}

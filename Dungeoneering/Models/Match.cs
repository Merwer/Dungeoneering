using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    public class Match : Entity
    {
        [Required]
        public Archetype OpponentArchetype { get; set; }

        [Required]
        public bool Win { get; set; }

        [JsonIgnore]
        [Required]
        public virtual Draft Draft { get; set; }

        public List<MatchReward> Rewards { get; set; }
        public bool First { get; set; }
    }
}
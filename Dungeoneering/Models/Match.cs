using Newtonsoft.Json;
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
        
        public MatchRewardList Rewards { get; set; }

        [Required]
        public bool First { get; set; }
    }
}
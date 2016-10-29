using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    public class Card : StaticIdEntity
    {
        [Required]
        public CardContainer Parent { get; set; }

        [Required]
        public CardRewards Rewards { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public int Health { get; set; }

        [Required]
        public int Cost { get; set; }

        public string Version { get; set; }

        public bool Active { get; set; }
        
        [JsonIgnore]
        public virtual ICollection<CardScore> Scores { get; set; }

        [NotMapped]
        public int Score { get; set; }

        [NotMapped]
        public long ChronicleId { get { return Parent.ChronicleId; } }

        [NotMapped]
        public string Name { get { return Parent.Name; } }

        [NotMapped]
        public Rarity Rarity { get { return Parent.Rarity; } }

        [NotMapped]
        public CardType Type { get { return Parent.Type; } }
    }
}
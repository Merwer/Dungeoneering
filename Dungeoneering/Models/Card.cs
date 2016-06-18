using System.ComponentModel.DataAnnotations;

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

        public string Version { get; set; }

        public bool Active { get; set; }

        public int Score { get; set; }
    }
}
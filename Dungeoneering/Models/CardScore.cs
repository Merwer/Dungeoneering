using System.ComponentModel.DataAnnotations;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    public class CardScore : StaticIdEntity
    {
        [Required]
        public virtual Card Card { get; set; }

        [Required]
        public Archetype Archetype { get; set; }

        public int Score { get; set; }
    }
}
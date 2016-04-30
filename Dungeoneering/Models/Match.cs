using System.ComponentModel.DataAnnotations;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    public class Match : Entity
    {
        [Required]
        public Archetype OpponentArchetype { get; set; }

        [Required]
        public bool Win { get; set; }

        [Required]
        public Draft Draft { get; set; }
    }
}
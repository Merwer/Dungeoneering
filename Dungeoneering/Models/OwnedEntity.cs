using System.ComponentModel.DataAnnotations;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    public abstract class OwnedEntity : Entity
    {
        [Required]
        public string OwnerName { get; set; }
    }
}

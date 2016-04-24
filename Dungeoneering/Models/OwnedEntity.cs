using System.ComponentModel.DataAnnotations;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Api.Models
{
    public abstract class OwnedEntity : Entity
    {
        [Required]
        public object OwnerId { get; set; }
    }
}

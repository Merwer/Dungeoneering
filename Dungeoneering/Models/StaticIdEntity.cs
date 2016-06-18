using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    public class StaticIdEntity : CreatableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override long Id { get; set; }
    }
}
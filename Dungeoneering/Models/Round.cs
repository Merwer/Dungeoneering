using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    public class Round : OwnedEntity
    {
        [JsonIgnore]
        [Required]
        public virtual Draft Draft { get; set; }
        public int RoundId { get; set; }
        [JsonIgnore]
        public int Option1 { get; set; }
        [JsonIgnore]
        public int Option2 { get; set; }
        [JsonIgnore]
        public int Option3 { get; set; }
        [JsonIgnore]
        public int Option4 { get; set; }
        [JsonIgnore]
        public int Option5 { get; set; }
        [JsonIgnore]
        public int Selected1 { get; set; }
        [JsonIgnore]
        public int Selected2 { get; set; }

        [NotMapped]
        public List<int> Options
        {
            get
            {
                return new List<int> { Option1, Option2, Option3, Option4, Option5 };
            }
            set
            {
                Option1 = value[0];
                Option2 = value[1];
                Option3 = value[2];
                Option4 = value[3];
                Option5 = value[4];
            }
        }

        [NotMapped]
        public List<int> Selected
        {
            get
            {
                return new List<int> { Selected1, Selected2 };
            }
            set
            {
                Selected1 = value[0];
                Selected2 = value[1];
            }
        }
    }
}

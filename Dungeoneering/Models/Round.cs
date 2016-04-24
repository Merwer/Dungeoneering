using System.Collections.Generic;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Api.Models
{
    public class Round : OwnedEntity
    {
        public int RoundId { get; set; }
        public List<int> Options { get; set; }
        public List<int> Selected { get; set; }
    }
}

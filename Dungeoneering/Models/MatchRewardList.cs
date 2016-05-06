using System.ComponentModel.DataAnnotations.Schema;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    [ComplexType]
    public class MatchRewardList
    {
        public int Copper { get; set; }

        public int Shards { get; set; }

        public int Packs { get; set; }
    }
}
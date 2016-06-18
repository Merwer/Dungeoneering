using System.ComponentModel.DataAnnotations.Schema;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    [ComplexType]
    public class CardRewards
    {
        public int Coins { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int Armour { get; set; }
        public bool Weapon { get; set; }
    }
}
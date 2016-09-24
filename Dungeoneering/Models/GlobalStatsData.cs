using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    public class GlobalStatsData : MyStatsData
    {
        public int Players { get; set; }
        public CardSelectionData CardSelections { get; set; }
    }

    public class CardSelectionData
    {
        public List<CardsPlayed> RaptorCards { get; set; }
        public List<CardsPlayed> ArianeCards { get; set; }
        public List<CardsPlayed> OzanCards { get; set; }
        public List<CardsPlayed> VanesculaCards { get; set; }
        public List<CardsPlayed> LinzaCards { get; set; }
        public List<CardsPlayed> MorvranCards { get; set; }
    }

    public class CardsPlayed
    {
        public Card Card { get; set; }
        public int Appearances { get; set; }
        public int Selections { get; set; }
        public Archetype Legend { get; set; }
        public double PickRate
        {
            get
            {
                return ((double)Selections) / Appearances;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    public class GlobalStatsData : MyStatsData
    {
        public int Players { get; set; }
        public ArchetypeSelectionData LegendSelections { get; set; } 
        public CardSelectionData CardSelections { get; set; }
        public ArchetypeMatchData LegendMatches { get; set; }
    }

    public class ArchetypeMatchData
    {
        public ArchetypeMatchList Raptor { get; set; }
        public ArchetypeMatchList Ariane { get; set; }
        public ArchetypeMatchList Ozan { get; set; }
        public ArchetypeMatchList Vanescula { get; set; }
        public ArchetypeMatchList Linza { get; set; }
        public ArchetypeMatchList Morvran { get; set; }
    }

    public class ArchetypeMatchList
    {
        public Archetype Legend { get; set; }
        public ArchetypeMatch VersusRaptor { get; set; }
        public ArchetypeMatch VersusAriane { get; set; }
        public ArchetypeMatch VersusOzan { get; set; }
        public ArchetypeMatch VersusVanescula { get; set; }
        public ArchetypeMatch VersusLinza { get; set; }
        public ArchetypeMatch VersusMorvran { get; set; }
    }

    public class ArchetypeMatch
    {
        public Archetype Opponent { get; set; }
        public int Matches { get; set; }
        public int Wins { get; set; }
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = true)]
        public double WinRate
        {
            get
            {
                return Matches == 0 ? 0 : ((double)Wins) / Matches;
            }
        }

    }

    public class ArchetypeSelectionData
    {
        public ArchetypeSelection Raptor { get; set; }
        public ArchetypeSelection Ariane { get; set; }
        public ArchetypeSelection Ozan { get; set; }
        public ArchetypeSelection Vanescula { get; set; }
        public ArchetypeSelection Linza { get; set; }
        public ArchetypeSelection Morvran { get; set; }
    }

    public class ArchetypeSelection
    {
        public Archetype Legend { get; set; }
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = true)]
        public double PickRate { get; set; }
        public int Selections { get; set; }
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
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = true)]
        public double PickRate
        {
            get
            {
                return ((double)Selections) / Appearances;
            }
        }
    }
}
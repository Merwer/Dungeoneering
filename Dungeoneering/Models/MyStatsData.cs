using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    /*
     * Stats to be calculated:

- General
 - Total Drafts
 - Total Games
 - Win Rate
 - Going First Win Rate
 - Average Dungeon Depth
 - Number of Times at each Depth
 - Average Rewards
 - Win Rate vs. Legend Y
- Stats as Legend X
 - Total Drafts
 - Total Games
 - Win Rate
 - Going First Win Rate
 - Average Dungeon Depth
 - Number of Times at each Depth (0-2, 3-6, 7-11, 12)
 - Win Rate vs. Legend Y
- Total Rewards
- Play Schedule (X times per day of the week)

*/
    public class BasicStatsData
    {
        public int Drafts { get; set; }
        public int Games { get; set; }
        public int TotalWins { get; set; }
        public int TotalLosses { get; set; }
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public double AverageWins { get; set; }
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = true)]
        public double WinRate { get; set; }
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = true)]
        public double FirstWinRate { get; set; }
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = true)]
        public double SecondWinRate { get; set; }
        public int ZeroToTwoWins { get; set; }
        public int ThreeToSixWins { get; set; }
        public int SevenToElevenWins { get; set; }
        public int TwelveWins { get; set; }
    }

    public class LegendSpecificStatsData : BasicStatsData
    {
        public Archetype Legend { get; set; }
    }

    public class MyStatsData : BasicStatsData
    {
        public MatchRewardList AverageRewards { get; set; }
        public MatchRewardList TotalRewards { get; set; }

        public List<LegendSpecificStatsData> LegendStats { get; set; }
        public LegendSpecificStatsData RaptorStats { get; set; }
        public LegendSpecificStatsData ArianeStats { get; set; }
        public LegendSpecificStatsData OzanStats { get; set; }
        public LegendSpecificStatsData VanesculaStats { get; set; }
        public LegendSpecificStatsData LinzaStats { get; set; }
        public LegendSpecificStatsData MorvranStats { get; internal set; }

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
}
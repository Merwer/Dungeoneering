using Merwer.Chronicle.Dungeoneering.Tracker.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System;
using System.Collections.Generic;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Controllers
{
    public class StatsController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Stats
        public ActionResult Global()
        {
            var drafts = db.Drafts.Include(d => d.Matches).ToList().Where(d => d.Complete).ToList();
            var data = CalculateStats<GlobalStatsData>(drafts);
            data.ArianeStats = CalculateStats<LegendSpecificStatsData>(drafts.Where(d => d.Archetype == Archetype.Ariane).ToList());
            data.ArianeStats.Legend = Archetype.Ariane;
            data.OzanStats = CalculateStats<LegendSpecificStatsData>(drafts.Where(d => d.Archetype == Archetype.Ozan).ToList());
            data.OzanStats.Legend = Archetype.Ozan;
            data.LinzaStats = CalculateStats<LegendSpecificStatsData>(drafts.Where(d => d.Archetype == Archetype.Linza).ToList());
            data.LinzaStats.Legend = Archetype.Linza;
            data.RaptorStats = CalculateStats<LegendSpecificStatsData>(drafts.Where(d => d.Archetype == Archetype.TheRaptor).ToList());
            data.RaptorStats.Legend = Archetype.TheRaptor;
            data.VanesculaStats = CalculateStats<LegendSpecificStatsData>(drafts.Where(d => d.Archetype == Archetype.Vanescula).ToList());
            data.VanesculaStats.Legend = Archetype.Vanescula;
            data.MorvranStats = CalculateStats<LegendSpecificStatsData>(drafts.Where(d => d.Archetype == Archetype.Morvran).ToList());
            data.MorvranStats.Legend = Archetype.Morvran;
            data.Players = drafts.Select(d => d.OwnerName).Distinct().Count();

            var games = drafts.SelectMany(d => d.Matches);
            data.TotalRewards = new MatchRewardList
            {
                Copper = games.Sum(g => g.Rewards.Copper),
                Packs = games.Sum(g => g.Rewards.Packs),
                Shards = games.Sum(g => g.Rewards.Shards)
            };
            data.AverageRewards = new MatchRewardList
            {
                Copper = games.Sum(g => g.Rewards.Copper) / drafts.Count(),
                Packs = games.Sum(g => g.Rewards.Packs) / drafts.Count(),
                Shards = games.Sum(g => g.Rewards.Shards) / drafts.Count()
            };

            data.CardSelections = new CardSelectionData
            {
                ArianeCards = CalculateCardSelections(drafts, Archetype.Ariane),
                LinzaCards = CalculateCardSelections(drafts, Archetype.Linza),
                MorvranCards = CalculateCardSelections(drafts, Archetype.Morvran),
                OzanCards = CalculateCardSelections(drafts, Archetype.Ozan),
                RaptorCards = CalculateCardSelections(drafts, Archetype.TheRaptor),
                VanesculaCards = CalculateCardSelections(drafts, Archetype.Vanescula)
            };

            data.LegendSelections = new ArchetypeSelectionData
            {
                Raptor = CalculateLegendSelections(drafts, Archetype.TheRaptor),
                Linza = CalculateLegendSelections(drafts, Archetype.Linza),
                Ariane = CalculateLegendSelections(drafts, Archetype.Ariane),
                Morvran = CalculateLegendSelections(drafts, Archetype.Morvran),
                Ozan = CalculateLegendSelections(drafts, Archetype.Ozan),
                Vanescula = CalculateLegendSelections(drafts, Archetype.Vanescula)
            };

            data.LegendMatches = new ArchetypeMatchData
            {
                Raptor = CalculateLegendMatchups(drafts, Archetype.TheRaptor),
                Linza = CalculateLegendMatchups(drafts, Archetype.Linza),
                Ariane = CalculateLegendMatchups(drafts, Archetype.Ariane),
                Morvran = CalculateLegendMatchups(drafts, Archetype.Morvran),
                Ozan = CalculateLegendMatchups(drafts, Archetype.Ozan),
                Vanescula = CalculateLegendMatchups(drafts, Archetype.Vanescula)
            };

            return View(data);
        }

        private ArchetypeMatchList CalculateLegendMatchups(List<Draft> drafts, Archetype archetype)
        {
            var legendDrafts = drafts.Where(d => d.Archetype == archetype);
            return new ArchetypeMatchList
            {
                Legend = archetype,
                VersusRaptor = CalculateLegendSpecificMatchups(legendDrafts, Archetype.TheRaptor),
                VersusLinza = CalculateLegendSpecificMatchups(legendDrafts, Archetype.Linza),
                VersusAriane = CalculateLegendSpecificMatchups(legendDrafts, Archetype.Ariane),
                VersusMorvran = CalculateLegendSpecificMatchups(legendDrafts, Archetype.Morvran),
                VersusOzan = CalculateLegendSpecificMatchups(legendDrafts, Archetype.Ozan),
                VersusVanescula = CalculateLegendSpecificMatchups(legendDrafts, Archetype.Vanescula)
            };
        }

        private ArchetypeMatch CalculateLegendSpecificMatchups(IEnumerable<Draft> legendDrafts, Archetype archetype)
        {
            var matches = legendDrafts.SelectMany(d => d.Matches)
                .Where(m => m.OpponentArchetype == archetype).ToList();
            return new ArchetypeMatch
            {
                Opponent = archetype,
                Matches = matches.Count(),
                Wins = matches.Count(m => m.Win)
            };
        }

        private ArchetypeSelection CalculateLegendSelections(List<Draft> drafts, Archetype archetype)
        {
            var selectionData = new ArchetypeSelection
            {
                Legend = archetype,
                Selections = drafts.Count(d => d.Archetype == archetype)
            };
            selectionData.PickRate = ((double)selectionData.Selections) / drafts.Count();
            return selectionData;
        }

        [Authorize]
        public ActionResult My()
        {
            var drafts = db.Drafts.Include(d => d.Matches).Where(d => d.OwnerName == Username).ToList().Where(d => d.Complete).ToList();
            var data = CalculateStats<MyStatsData>(drafts);
            data.ArianeStats = CalculateStats<LegendSpecificStatsData>(drafts.Where(d => d.Archetype == Archetype.Ariane).ToList());
            data.ArianeStats.Legend = Archetype.Ariane;
            data.OzanStats = CalculateStats<LegendSpecificStatsData>(drafts.Where(d => d.Archetype == Archetype.Ozan).ToList());
            data.OzanStats.Legend = Archetype.Ozan;
            data.LinzaStats = CalculateStats<LegendSpecificStatsData>(drafts.Where(d => d.Archetype == Archetype.Linza).ToList());
            data.LinzaStats.Legend = Archetype.Linza;
            data.RaptorStats = CalculateStats<LegendSpecificStatsData>(drafts.Where(d => d.Archetype == Archetype.TheRaptor).ToList());
            data.RaptorStats.Legend = Archetype.TheRaptor;
            data.VanesculaStats = CalculateStats<LegendSpecificStatsData>(drafts.Where(d => d.Archetype == Archetype.Vanescula).ToList());
            data.VanesculaStats.Legend = Archetype.Vanescula;

            if (drafts.Any())
            {
                var games = drafts.SelectMany(d => d.Matches);
                data.TotalRewards = new MatchRewardList
                {
                    Copper = games.Sum(g => g.Rewards.Copper),
                    Packs = games.Sum(g => g.Rewards.Packs),
                    Shards = games.Sum(g => g.Rewards.Shards)
                };
                data.AverageRewards = new MatchRewardList
                {
                    Copper = games.Sum(g => g.Rewards.Copper) / drafts.Count(),
                    Packs = games.Sum(g => g.Rewards.Packs) / drafts.Count(),
                    Shards = games.Sum(g => g.Rewards.Shards) / drafts.Count()
                };

                data.LegendMatches = new ArchetypeMatchData
                {
                    Raptor = CalculateLegendMatchups(drafts, Archetype.TheRaptor),
                    Linza = CalculateLegendMatchups(drafts, Archetype.Linza),
                    Ariane = CalculateLegendMatchups(drafts, Archetype.Ariane),
                    Morvran = CalculateLegendMatchups(drafts, Archetype.Morvran),
                    Ozan = CalculateLegendMatchups(drafts, Archetype.Ozan),
                    Vanescula = CalculateLegendMatchups(drafts, Archetype.Vanescula)
                };
            }

            return View(data);
        }

        private T CalculateStats<T>(List<Draft> drafts)
            where T : BasicStatsData, new()
        {
            var games = drafts.SelectMany(d => d.Matches);
            var data = new T();
            if (!(drafts.Any() && games.Any()))
            {
                return data;
            }
            data.Drafts = drafts.Count();
            data.Games = games.Count();
            data.TotalWins = games.Count(g => g.Win);
            data.TotalLosses = games.Count(g => !g.Win);
            data.WinRate = data.TotalWins / ((double)data.Games);
            data.AverageWins = drafts.Select(d => d.Matches.Count(g => g.Win)).Average();
            data.FirstWinRate = games.Count(g => g.Win && g.First) / ((double)games.Count(g => g.First));
            data.SecondWinRate = games.Count(g => g.Win && !g.First) / ((double)games.Count(g => !g.First));
            data.ZeroToTwoWins = drafts.Count(d => d.Matches.Count(g => g.Win) >= 0 && d.Matches.Count(g => g.Win) <= 2);
            data.ThreeToSixWins = drafts.Count(d => d.Matches.Count(g => g.Win) >= 3 && d.Matches.Count(g => g.Win) <= 6);
            data.SevenToElevenWins = drafts.Count(d => d.Matches.Count(g => g.Win) >= 7 && d.Matches.Count(g => g.Win) <= 11);
            data.TwelveWins = drafts.Count(d => d.Matches.Count(g => g.Win) >= 12);
            return data;
        }

        private List<CardsPlayed> CalculateCardSelections(IEnumerable<Draft> drafts, Archetype archetype)
        {
            var rounds = drafts.Where(d => d.Archetype == archetype).SelectMany(d => d.Rounds);
            var timesOffered = rounds.SelectMany(r => r.Options)
                .GroupBy(k => k)
                .Select(x => new CardsPlayed { Card = db.Cards.Include(c => c.Parent).FirstOrDefault(c => c.Id == x.Key), Appearances = x.Count(), Selections = rounds.SelectMany(q => q.Selected).Where(q => q == x.Key).Count(), Legend = archetype })
                .OrderByDescending(x => ((double)x.Selections) / x.Appearances).ThenByDescending(x => x.Selections)
                .Take(5).ToList();
            return timesOffered;
        }
    }
}
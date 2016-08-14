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
            var stats = new GlobalStatsData
            {
                Players = db.Users.Count(),
                Matches = db.Matches.Count(),
                Drafts = db.Drafts.Count()
            };
            return View(stats);
        }

        [Authorize]
        public ActionResult My()
        {
            var drafts = db.Drafts.Include(d => d.Matches).Where(d => d.OwnerName == Username).ToList();
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
    }
}
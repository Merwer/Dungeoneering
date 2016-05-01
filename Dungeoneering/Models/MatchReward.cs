﻿using System.ComponentModel.DataAnnotations;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    public class MatchReward : Entity
    {
        public enum RewardType
        {
            Copper,
            Shards,
            Deck
        }

        [Required]
        public RewardType Type { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public Match Match { get; set; }
    }
}
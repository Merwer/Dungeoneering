﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Models
{
    public class CardContainer : StaticIdEntity
    {
        public CardContainer()
        {
            Versions = new List<Card>();
        }

        public Archetype? Archetype { get; set; }

        [Required]
        public int ChronicleId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Rarity Rarity { get; set; }

        [Required]
        public CardType Type { get; set; }

        public virtual ICollection<Card> Versions { get; set; }

        //[NotMapped]
        //public Card CurrentVersion
        //{
        //    get
        //    {
        //        return Versions.Single(v => v.Active);
        //    }
        //}
    }
}
using Merwer.Chronicle.Dungeoneering.Tracker.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Migrations
{
/* This is an auto-generated file */
    public static class CardData
    {
        static readonly bool SHOULD_UPDATE = false;

        static ICollection<CardContainer> containers = new HashSet<CardContainer>();
        static ICollection<Card> cards = new HashSet<Card>();
        static ICollection<CardScore> scores = new HashSet<CardScore>();

        static CardData() {
            containers.Add(new CardContainer { Id = 1, ChronicleId = 1, Archetype = null, Name = "Customs Officer", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 1, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Customs_Officer.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 1) });
            scores.Add(new CardScore { Id = 1   , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 1) });
            scores.Add(new CardScore { Id = 2   , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 1) });
            scores.Add(new CardScore { Id = 3   , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 1) });
            scores.Add(new CardScore { Id = 4   , Archetype = Archetype.Vanescula, Score = 80, Card = cards.Single(c => c.Id == 1) });
            scores.Add(new CardScore { Id = 5   , Archetype = Archetype.Ozan     , Score = -1, Card = cards.Single(c => c.Id == 1) });
            scores.Add(new CardScore { Id = 1072, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 1) });

            containers.Add(new CardContainer { Id = 2, ChronicleId = 2, Archetype = null, Name = "Goblin Flashmob", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 2, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 4, Weapon = false }, Image = "/Content/img/cards/Goblin_Flashmob.png", Version = "X", Cost = 0, Health = 9, Active = true, Parent = containers.Single(p => p.Id == 2) });
            scores.Add(new CardScore { Id = 6   , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 2) });
            scores.Add(new CardScore { Id = 7   , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 2) });
            scores.Add(new CardScore { Id = 8   , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 2) });
            scores.Add(new CardScore { Id = 9   , Archetype = Archetype.Vanescula, Score = 60, Card = cards.Single(c => c.Id == 2) });
            scores.Add(new CardScore { Id = 10  , Archetype = Archetype.Ozan     , Score = -1, Card = cards.Single(c => c.Id == 2) });
            scores.Add(new CardScore { Id = 1073, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 2) });

            containers.Add(new CardContainer { Id = 3, ChronicleId = 3, Archetype = null, Name = "Yelps", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 3, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Yelps.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 3) });
            scores.Add(new CardScore { Id = 11  , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 3) });
            scores.Add(new CardScore { Id = 12  , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 3) });
            scores.Add(new CardScore { Id = 13  , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 3) });
            scores.Add(new CardScore { Id = 14  , Archetype = Archetype.Vanescula, Score = 80, Card = cards.Single(c => c.Id == 3) });
            scores.Add(new CardScore { Id = 15  , Archetype = Archetype.Ozan     , Score = -1, Card = cards.Single(c => c.Id == 3) });
            scores.Add(new CardScore { Id = 1074, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 3) });

            containers.Add(new CardContainer { Id = 4, ChronicleId = 4, Archetype = null, Name = "General Graardor", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 4, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/General_Graardor.png", Version = "X", Cost = 0, Health = 13, Active = true, Parent = containers.Single(p => p.Id == 4) });
            scores.Add(new CardScore { Id = 16  , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 4) });
            scores.Add(new CardScore { Id = 17  , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 4) });
            scores.Add(new CardScore { Id = 18  , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 4) });
            scores.Add(new CardScore { Id = 19  , Archetype = Archetype.Vanescula, Score = 30, Card = cards.Single(c => c.Id == 4) });
            scores.Add(new CardScore { Id = 20  , Archetype = Archetype.Ozan     , Score = -1, Card = cards.Single(c => c.Id == 4) });
            scores.Add(new CardScore { Id = 1075, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 4) });

            containers.Add(new CardContainer { Id = 5, ChronicleId = 5, Archetype = null, Name = "Ogre Brute", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 5, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ogre_Brute.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 5) });
            scores.Add(new CardScore { Id = 21  , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 5) });
            scores.Add(new CardScore { Id = 22  , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 5) });
            scores.Add(new CardScore { Id = 23  , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 5) });
            scores.Add(new CardScore { Id = 24  , Archetype = Archetype.Vanescula, Score = 30, Card = cards.Single(c => c.Id == 5) });
            scores.Add(new CardScore { Id = 25  , Archetype = Archetype.Ozan     , Score = -1, Card = cards.Single(c => c.Id == 5) });
            scores.Add(new CardScore { Id = 1076, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 5) });

            containers.Add(new CardContainer { Id = 6, ChronicleId = 6, Archetype = null, Name = "Black Arm Bandit", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 6, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Black_Arm_Bandit.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 6) });
            scores.Add(new CardScore { Id = 26  , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 6) });
            scores.Add(new CardScore { Id = 27  , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 6) });
            scores.Add(new CardScore { Id = 28  , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 6) });
            scores.Add(new CardScore { Id = 29  , Archetype = Archetype.Vanescula, Score = 60, Card = cards.Single(c => c.Id == 6) });
            scores.Add(new CardScore { Id = 30  , Archetype = Archetype.Ozan     , Score = -1, Card = cards.Single(c => c.Id == 6) });
            scores.Add(new CardScore { Id = 1077, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 6) });

            containers.Add(new CardContainer { Id = 7, ChronicleId = 8, Archetype = null, Name = "Troll Chucker", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 7, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Troll_Chucker.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 7) });
            scores.Add(new CardScore { Id = 31  , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 7) });
            scores.Add(new CardScore { Id = 32  , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 7) });
            scores.Add(new CardScore { Id = 33  , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 7) });
            scores.Add(new CardScore { Id = 34  , Archetype = Archetype.Vanescula, Score = 60, Card = cards.Single(c => c.Id == 7) });
            scores.Add(new CardScore { Id = 35  , Archetype = Archetype.Ozan     , Score = -1, Card = cards.Single(c => c.Id == 7) });
            scores.Add(new CardScore { Id = 1078, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 7) });

            containers.Add(new CardContainer { Id = 8, ChronicleId = 9, Archetype = null, Name = "Gluttonous Behemoth", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 8, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 3, Weapon = false }, Image = "/Content/img/cards/Gluttonous_Behemoth.png", Version = "X", Cost = 0, Health = 19, Active = true, Parent = containers.Single(p => p.Id == 8) });
            scores.Add(new CardScore { Id = 36  , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 8) });
            scores.Add(new CardScore { Id = 37  , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 8) });
            scores.Add(new CardScore { Id = 38  , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 8) });
            scores.Add(new CardScore { Id = 39  , Archetype = Archetype.Vanescula, Score = 40, Card = cards.Single(c => c.Id == 8) });
            scores.Add(new CardScore { Id = 40  , Archetype = Archetype.Ozan     , Score = -1, Card = cards.Single(c => c.Id == 8) });
            scores.Add(new CardScore { Id = 1079, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 8) });

            containers.Add(new CardContainer { Id = 9, ChronicleId = 10, Archetype = null, Name = "Vorago", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 9, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Vorago.png", Version = "X", Cost = 0, Health = 14, Active = true, Parent = containers.Single(p => p.Id == 9) });
            scores.Add(new CardScore { Id = 41  , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 9) });
            scores.Add(new CardScore { Id = 42  , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 9) });
            scores.Add(new CardScore { Id = 43  , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 9) });
            scores.Add(new CardScore { Id = 44  , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 9) });
            scores.Add(new CardScore { Id = 45  , Archetype = Archetype.Ozan     , Score = 30, Card = cards.Single(c => c.Id == 9) });
            scores.Add(new CardScore { Id = 1080, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 9) });

            containers.Add(new CardContainer { Id = 10, ChronicleId = 11, Archetype = null, Name = "TzTok-Jad", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 10, Rewards = new CardRewards { Attack = 1, Armour = 4, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/TzTok_Jad.png", Version = "X", Cost = 0, Health = 7, Active = true, Parent = containers.Single(p => p.Id == 10) });
            scores.Add(new CardScore { Id = 46  , Archetype = Archetype.TheRaptor, Score = 90, Card = cards.Single(c => c.Id == 10) });
            scores.Add(new CardScore { Id = 47  , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 10) });
            scores.Add(new CardScore { Id = 48  , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 10) });
            scores.Add(new CardScore { Id = 49  , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 10) });
            scores.Add(new CardScore { Id = 50  , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 10) });
            scores.Add(new CardScore { Id = 1081, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 10) });

            containers.Add(new CardContainer { Id = 11, ChronicleId = 12, Archetype = null, Name = "Penguin Sheep", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 11, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Penguin_Sheep.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 11) });
            scores.Add(new CardScore { Id = 51  , Archetype = Archetype.TheRaptor, Score = 10, Card = cards.Single(c => c.Id == 11) });
            scores.Add(new CardScore { Id = 52  , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 11) });
            scores.Add(new CardScore { Id = 53  , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 11) });
            scores.Add(new CardScore { Id = 54  , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 11) });
            scores.Add(new CardScore { Id = 55  , Archetype = Archetype.Ozan     , Score = 10, Card = cards.Single(c => c.Id == 11) });
            scores.Add(new CardScore { Id = 1082, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 11) });

            containers.Add(new CardContainer { Id = 12, ChronicleId = 13, Archetype = null, Name = "KGP Agent", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 12, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/KGP_Agent.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 12) });
            scores.Add(new CardScore { Id = 56  , Archetype = Archetype.TheRaptor, Score = 100, Card = cards.Single(c => c.Id == 12) });
            scores.Add(new CardScore { Id = 57  , Archetype = Archetype.Linza    , Score = 100, Card = cards.Single(c => c.Id == 12) });
            scores.Add(new CardScore { Id = 58  , Archetype = Archetype.Ariane   , Score = 100, Card = cards.Single(c => c.Id == 12) });
            scores.Add(new CardScore { Id = 59  , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 12) });
            scores.Add(new CardScore { Id = 60  , Archetype = Archetype.Ozan     , Score = 100, Card = cards.Single(c => c.Id == 12) });
            scores.Add(new CardScore { Id = 1083, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 12) });

            containers.Add(new CardContainer { Id = 13, ChronicleId = 14, Archetype = null, Name = "Jubbly Bird", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 13, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 3, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Jubbly_Bird.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 13) });
            scores.Add(new CardScore { Id = 61  , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 13) });
            scores.Add(new CardScore { Id = 62  , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 13) });
            scores.Add(new CardScore { Id = 63  , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 13) });
            scores.Add(new CardScore { Id = 64  , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 13) });
            scores.Add(new CardScore { Id = 65  , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 13) });
            scores.Add(new CardScore { Id = 1084, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 13) });

            containers.Add(new CardContainer { Id = 14, ChronicleId = 15, Archetype = null, Name = "Mischievous Imp", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 14, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Mischievous_Imp.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 14) });
            scores.Add(new CardScore { Id = 66  , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 14) });
            scores.Add(new CardScore { Id = 67  , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 14) });
            scores.Add(new CardScore { Id = 68  , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 14) });
            scores.Add(new CardScore { Id = 69  , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 14) });
            scores.Add(new CardScore { Id = 70  , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 14) });
            scores.Add(new CardScore { Id = 1085, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 14) });

            containers.Add(new CardContainer { Id = 15, ChronicleId = 16, Archetype = null, Name = "Combat Academy", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 15, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Combat_Academy.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 15) });
            scores.Add(new CardScore { Id = 71  , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 15) });
            scores.Add(new CardScore { Id = 72  , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 15) });
            scores.Add(new CardScore { Id = 73  , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 15) });
            scores.Add(new CardScore { Id = 74  , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 15) });
            scores.Add(new CardScore { Id = 75  , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 15) });
            scores.Add(new CardScore { Id = 1086, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 15) });

            containers.Add(new CardContainer { Id = 16, ChronicleId = 17, Archetype = null, Name = "Romily Weaklax", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 16, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 7, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Romily_Weaklax.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 16) });
            scores.Add(new CardScore { Id = 76  , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 16) });
            scores.Add(new CardScore { Id = 77  , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 16) });
            scores.Add(new CardScore { Id = 78  , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 16) });
            scores.Add(new CardScore { Id = 79  , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 16) });
            scores.Add(new CardScore { Id = 80  , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 16) });
            scores.Add(new CardScore { Id = 1087, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 16) });

            containers.Add(new CardContainer { Id = 17, ChronicleId = 20, Archetype = null, Name = "Bar Fight", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 17, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Bar_Fight.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 17) });
            scores.Add(new CardScore { Id = 81  , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 17) });
            scores.Add(new CardScore { Id = 82  , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 17) });
            scores.Add(new CardScore { Id = 83  , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 17) });
            scores.Add(new CardScore { Id = 84  , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 17) });
            scores.Add(new CardScore { Id = 85  , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 17) });
            scores.Add(new CardScore { Id = 1088, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 17) });

            containers.Add(new CardContainer { Id = 18, ChronicleId = 21, Archetype = null, Name = "Mimic", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 18, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 4, Weapon = false }, Image = "/Content/img/cards/Mimic.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 18) });
            scores.Add(new CardScore { Id = 86  , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 18) });
            scores.Add(new CardScore { Id = 87  , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 18) });
            scores.Add(new CardScore { Id = 88  , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 18) });
            scores.Add(new CardScore { Id = 89  , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 18) });
            scores.Add(new CardScore { Id = 90  , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 18) });
            scores.Add(new CardScore { Id = 1089, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 18) });

            containers.Add(new CardContainer { Id = 19, ChronicleId = 23, Archetype = null, Name = "Death", Rarity = Rarity.Diamond, Type = CardType.Support });
            cards.Add(new Card { Id = 19, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Death.png", Version = "X", Cost = 9, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 19) });
            scores.Add(new CardScore { Id = 91  , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 19) });
            scores.Add(new CardScore { Id = 92  , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 19) });
            scores.Add(new CardScore { Id = 93  , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 19) });
            scores.Add(new CardScore { Id = 94  , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 19) });
            scores.Add(new CardScore { Id = 95  , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 19) });
            scores.Add(new CardScore { Id = 1090, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 19) });

            containers.Add(new CardContainer { Id = 20, ChronicleId = 24, Archetype = null, Name = "Cabbage", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 20, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 4, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Cabbage.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 20) });
            scores.Add(new CardScore { Id = 96  , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 20) });
            scores.Add(new CardScore { Id = 97  , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 20) });
            scores.Add(new CardScore { Id = 98  , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 20) });
            scores.Add(new CardScore { Id = 99  , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 20) });
            scores.Add(new CardScore { Id = 100 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 20) });
            scores.Add(new CardScore { Id = 1091, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 20) });

            containers.Add(new CardContainer { Id = 21, ChronicleId = 25, Archetype = null, Name = "Partyhat", Rarity = Rarity.Diamond, Type = CardType.Support });
            cards.Add(new Card { Id = 21, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Partyhat.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 21) });
            scores.Add(new CardScore { Id = 101 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 21) });
            scores.Add(new CardScore { Id = 102 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 21) });
            scores.Add(new CardScore { Id = 103 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 21) });
            scores.Add(new CardScore { Id = 104 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 21) });
            scores.Add(new CardScore { Id = 105 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 21) });
            scores.Add(new CardScore { Id = 1092, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 21) });

            containers.Add(new CardContainer { Id = 22, ChronicleId = 26, Archetype = null, Name = "Solomon Madini", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 22, Rewards = new CardRewards { Attack = 0, Armour = 4, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Solomon_Madini.png", Version = "X", Cost = 4, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 22) });
            scores.Add(new CardScore { Id = 106 , Archetype = Archetype.TheRaptor, Score = 90, Card = cards.Single(c => c.Id == 22) });
            scores.Add(new CardScore { Id = 107 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 22) });
            scores.Add(new CardScore { Id = 108 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 22) });
            scores.Add(new CardScore { Id = 109 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 22) });
            scores.Add(new CardScore { Id = 110 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 22) });
            scores.Add(new CardScore { Id = 1093, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 22) });

            containers.Add(new CardContainer { Id = 23, ChronicleId = 27, Archetype = null, Name = "Gorajo Hoardstalker", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 23, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 6, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Gorajo_Hoardstalker.png", Version = "X", Cost = 6, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 23) });
            scores.Add(new CardScore { Id = 111 , Archetype = Archetype.TheRaptor, Score = 90, Card = cards.Single(c => c.Id == 23) });
            scores.Add(new CardScore { Id = 112 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 23) });
            scores.Add(new CardScore { Id = 113 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 23) });
            scores.Add(new CardScore { Id = 114 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 23) });
            scores.Add(new CardScore { Id = 115 , Archetype = Archetype.Ozan     , Score = 90, Card = cards.Single(c => c.Id == 23) });
            scores.Add(new CardScore { Id = 1094, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 23) });

            containers.Add(new CardContainer { Id = 24, ChronicleId = 28, Archetype = Archetype.Ozan, Name = "Highwayman", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 24, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Highwayman.png", Version = "X", Cost = 8, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 24) });
            scores.Add(new CardScore { Id = 116 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 24) });

            containers.Add(new CardContainer { Id = 25, ChronicleId = 29, Archetype = null, Name = "Ali Morrisane", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 25, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 3, Weapon = false }, Image = "/Content/img/cards/Ali_Morrisane.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 25) });
            scores.Add(new CardScore { Id = 117 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 25) });
            scores.Add(new CardScore { Id = 118 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 25) });
            scores.Add(new CardScore { Id = 119 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 25) });
            scores.Add(new CardScore { Id = 120 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 25) });
            scores.Add(new CardScore { Id = 121 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 25) });
            scores.Add(new CardScore { Id = 1095, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 25) });

            containers.Add(new CardContainer { Id = 26, ChronicleId = 30, Archetype = null, Name = "Nastroth", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 26, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Nastroth.png", Version = "X", Cost = 4, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 26) });
            scores.Add(new CardScore { Id = 122 , Archetype = Archetype.TheRaptor, Score = 90, Card = cards.Single(c => c.Id == 26) });
            scores.Add(new CardScore { Id = 123 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 26) });
            scores.Add(new CardScore { Id = 124 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 26) });
            scores.Add(new CardScore { Id = 125 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 26) });
            scores.Add(new CardScore { Id = 126 , Archetype = Archetype.Ozan     , Score = 90, Card = cards.Single(c => c.Id == 26) });
            scores.Add(new CardScore { Id = 1096, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 26) });

            containers.Add(new CardContainer { Id = 27, ChronicleId = 31, Archetype = Archetype.Linza, Name = "Artisan's Workshop", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 27, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Artisans_Workshop.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 27) });
            scores.Add(new CardScore { Id = 127 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 27) });

            containers.Add(new CardContainer { Id = 28, ChronicleId = 32, Archetype = Archetype.Linza, Name = "Dragon Forge", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 28, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Dragon_Forge.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 28) });
            scores.Add(new CardScore { Id = 128 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 28) });

            containers.Add(new CardContainer { Id = 29, ChronicleId = 33, Archetype = Archetype.Linza, Name = "Bartak's Anvil", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 29, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Bartaks_Anvil.png", Version = "X", Cost = 4, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 29) });
            scores.Add(new CardScore { Id = 129 , Archetype = Archetype.Linza    , Score = 10, Card = cards.Single(c => c.Id == 29) });

            containers.Add(new CardContainer { Id = 30, ChronicleId = 34, Archetype = Archetype.Linza, Name = "Miner Ancestor", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 30, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Miner_Ancestor.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 30) });
            scores.Add(new CardScore { Id = 130 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 30) });

            containers.Add(new CardContainer { Id = 31, ChronicleId = 35, Archetype = null, Name = "Golden Hammer", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 31, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Golden_Hammer.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 31) });
            scores.Add(new CardScore { Id = 131 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 31) });
            scores.Add(new CardScore { Id = 132 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 31) });
            scores.Add(new CardScore { Id = 133 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 31) });
            scores.Add(new CardScore { Id = 134 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 31) });
            scores.Add(new CardScore { Id = 135 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 31) });
            scores.Add(new CardScore { Id = 1097, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 31) });

            containers.Add(new CardContainer { Id = 32, ChronicleId = 36, Archetype = Archetype.TheRaptor, Name = "Defence Potion", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 32, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Defence_Potion.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 32) });
            scores.Add(new CardScore { Id = 136 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 32) });

            containers.Add(new CardContainer { Id = 33, ChronicleId = 37, Archetype = null, Name = "Full Tetsu", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 33, Rewards = new CardRewards { Attack = 0, Armour = 7, Health = 7, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Full_Tetsu.png", Version = "X", Cost = 5, Health = 0, Active = false, Parent = containers.Single(p => p.Id == 33) });
            scores.Add(new CardScore { Id = 137 , Archetype = Archetype.TheRaptor, Score = 100, Card = cards.Single(c => c.Id == 33) });
            scores.Add(new CardScore { Id = 138 , Archetype = Archetype.Linza    , Score = 90, Card = cards.Single(c => c.Id == 33) });
            scores.Add(new CardScore { Id = 139 , Archetype = Archetype.Ariane   , Score = 90, Card = cards.Single(c => c.Id == 33) });
            scores.Add(new CardScore { Id = 140 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 33) });
            scores.Add(new CardScore { Id = 141 , Archetype = Archetype.Ozan     , Score = 90, Card = cards.Single(c => c.Id == 33) });
            scores.Add(new CardScore { Id = 1098, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 33) });

            containers.Add(new CardContainer { Id = 34, ChronicleId = 38, Archetype = null, Name = "Stack o' Sharks", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 34, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Stack_o_Sharks.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 34) });
            scores.Add(new CardScore { Id = 142 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 34) });
            scores.Add(new CardScore { Id = 143 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 34) });
            scores.Add(new CardScore { Id = 144 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 34) });
            scores.Add(new CardScore { Id = 145 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 34) });
            scores.Add(new CardScore { Id = 146 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 34) });
            scores.Add(new CardScore { Id = 1099, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 34) });

            containers.Add(new CardContainer { Id = 35, ChronicleId = 39, Archetype = Archetype.TheRaptor, Name = "Dondakan's Cannon", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 35, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Dondakans_Cannon.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 35) });
            scores.Add(new CardScore { Id = 147 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 35) });

            containers.Add(new CardContainer { Id = 36, ChronicleId = 40, Archetype = null, Name = "Rock Cake", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 36, Rewards = new CardRewards { Attack = 0, Armour = 6, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Rock_Cake.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 36) });
            scores.Add(new CardScore { Id = 148 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 36) });
            scores.Add(new CardScore { Id = 149 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 36) });
            scores.Add(new CardScore { Id = 150 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 36) });
            scores.Add(new CardScore { Id = 151 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 36) });
            scores.Add(new CardScore { Id = 152 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 36) });
            scores.Add(new CardScore { Id = 1100, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 36) });

            containers.Add(new CardContainer { Id = 37, ChronicleId = 41, Archetype = Archetype.Linza, Name = "Raging Kalphite", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 37, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Raging_Kalphite.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 37) });
            scores.Add(new CardScore { Id = 153 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 37) });

            containers.Add(new CardContainer { Id = 38, ChronicleId = 42, Archetype = null, Name = "Burntmeat", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 38, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Burntmeat.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 38) });
            scores.Add(new CardScore { Id = 154 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 38) });
            scores.Add(new CardScore { Id = 155 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 38) });
            scores.Add(new CardScore { Id = 156 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 38) });
            scores.Add(new CardScore { Id = 157 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 38) });
            scores.Add(new CardScore { Id = 158 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 38) });
            scores.Add(new CardScore { Id = 1101, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 38) });

            containers.Add(new CardContainer { Id = 39, ChronicleId = 43, Archetype = Archetype.TheRaptor, Name = "Steel Titan", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 39, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Steel_Titan.png", Version = "X", Cost = 6, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 39) });
            scores.Add(new CardScore { Id = 159 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 39) });

            containers.Add(new CardContainer { Id = 40, ChronicleId = 44, Archetype = null, Name = "Restore Potion", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 40, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 5, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Restore_Potion.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 40) });
            scores.Add(new CardScore { Id = 160 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 40) });
            scores.Add(new CardScore { Id = 161 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 40) });
            scores.Add(new CardScore { Id = 162 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 40) });
            scores.Add(new CardScore { Id = 163 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 40) });
            scores.Add(new CardScore { Id = 164 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 40) });
            scores.Add(new CardScore { Id = 1102, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 40) });

            containers.Add(new CardContainer { Id = 41, ChronicleId = 45, Archetype = null, Name = "Doric", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 41, Rewards = new CardRewards { Attack = 0, Armour = 4, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Doric.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 41) });
            scores.Add(new CardScore { Id = 165 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 41) });
            scores.Add(new CardScore { Id = 166 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 41) });
            scores.Add(new CardScore { Id = 167 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 41) });
            scores.Add(new CardScore { Id = 168 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 41) });
            scores.Add(new CardScore { Id = 169 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 41) });
            scores.Add(new CardScore { Id = 1103, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 41) });

            containers.Add(new CardContainer { Id = 42, ChronicleId = 46, Archetype = null, Name = "Skeleton Warrior", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 42, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 3, Weapon = false }, Image = "/Content/img/cards/Skeleton_Warrior.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 42) });
            scores.Add(new CardScore { Id = 170 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 42) });
            scores.Add(new CardScore { Id = 171 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 42) });
            scores.Add(new CardScore { Id = 172 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 42) });
            scores.Add(new CardScore { Id = 173 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 42) });
            scores.Add(new CardScore { Id = 174 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 42) });
            scores.Add(new CardScore { Id = 1104, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 42) });

            containers.Add(new CardContainer { Id = 43, ChronicleId = 47, Archetype = null, Name = "Giant Rat", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 43, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Giant_Rat.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 43) });
            scores.Add(new CardScore { Id = 175 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 43) });
            scores.Add(new CardScore { Id = 176 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 43) });
            scores.Add(new CardScore { Id = 177 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 43) });
            scores.Add(new CardScore { Id = 178 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 43) });
            scores.Add(new CardScore { Id = 179 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 43) });
            scores.Add(new CardScore { Id = 1105, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 43) });

            containers.Add(new CardContainer { Id = 44, ChronicleId = 48, Archetype = null, Name = "White Wolf", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 44, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/White_Wolf.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 44) });
            scores.Add(new CardScore { Id = 180 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 44) });
            scores.Add(new CardScore { Id = 181 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 44) });
            scores.Add(new CardScore { Id = 182 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 44) });
            scores.Add(new CardScore { Id = 183 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 44) });
            scores.Add(new CardScore { Id = 184 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 44) });
            scores.Add(new CardScore { Id = 1106, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 44) });

            containers.Add(new CardContainer { Id = 45, ChronicleId = 49, Archetype = Archetype.Ozan, Name = "Al Kharid Warrior", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 45, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Al_Kharid_Warrior.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 45) });
            scores.Add(new CardScore { Id = 185 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 45) });

            containers.Add(new CardContainer { Id = 46, ChronicleId = 51, Archetype = null, Name = "Barbarian Warrior", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 46, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = true }, Image = "/Content/img/cards/Barbarian_Warrior.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 46) });
            scores.Add(new CardScore { Id = 186 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 46) });
            scores.Add(new CardScore { Id = 187 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 46) });
            scores.Add(new CardScore { Id = 188 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 46) });
            scores.Add(new CardScore { Id = 189 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 46) });
            scores.Add(new CardScore { Id = 190 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 46) });
            scores.Add(new CardScore { Id = 1107, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 46) });

            containers.Add(new CardContainer { Id = 47, ChronicleId = 52, Archetype = null, Name = "Crassian Warrior", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 47, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Crassian_Warrior.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 47) });
            scores.Add(new CardScore { Id = 191 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 47) });
            scores.Add(new CardScore { Id = 192 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 47) });
            scores.Add(new CardScore { Id = 193 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 47) });
            scores.Add(new CardScore { Id = 194 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 47) });
            scores.Add(new CardScore { Id = 195 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 47) });
            scores.Add(new CardScore { Id = 1108, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 47) });

            containers.Add(new CardContainer { Id = 48, ChronicleId = 53, Archetype = null, Name = "Grotworm", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 48, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 7, Weapon = false }, Image = "/Content/img/cards/Grotworm.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 48) });
            scores.Add(new CardScore { Id = 196 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 48) });
            scores.Add(new CardScore { Id = 197 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 48) });
            scores.Add(new CardScore { Id = 198 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 48) });
            scores.Add(new CardScore { Id = 199 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 48) });
            scores.Add(new CardScore { Id = 200 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 48) });
            scores.Add(new CardScore { Id = 1109, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 48) });

            containers.Add(new CardContainer { Id = 49, ChronicleId = 54, Archetype = Archetype.TheRaptor, Name = "Ice Nihil", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 49, Rewards = new CardRewards { Attack = 0, Armour = 4, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Ice_Nihil.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 49) });
            scores.Add(new CardScore { Id = 201 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 49) });

            containers.Add(new CardContainer { Id = 50, ChronicleId = 55, Archetype = null, Name = "Automaton Guardian", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 50, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Automaton_Guardian.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 50) });
            scores.Add(new CardScore { Id = 202 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 50) });
            scores.Add(new CardScore { Id = 203 , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 50) });
            scores.Add(new CardScore { Id = 204 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 50) });
            scores.Add(new CardScore { Id = 205 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 50) });
            scores.Add(new CardScore { Id = 206 , Archetype = Archetype.Ozan     , Score = 30, Card = cards.Single(c => c.Id == 50) });
            scores.Add(new CardScore { Id = 1110, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 50) });

            containers.Add(new CardContainer { Id = 51, ChronicleId = 56, Archetype = Archetype.TheRaptor, Name = "Corporeal Beast", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 51, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Corporeal_Beast.png", Version = "X", Cost = 0, Health = 14, Active = true, Parent = containers.Single(p => p.Id == 51) });
            scores.Add(new CardScore { Id = 207 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 51) });

            containers.Add(new CardContainer { Id = 52, ChronicleId = 57, Archetype = null, Name = "Tormented Demon", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 52, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Tormented_Demon.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 52) });
            scores.Add(new CardScore { Id = 208 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 52) });
            scores.Add(new CardScore { Id = 209 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 52) });
            scores.Add(new CardScore { Id = 210 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 52) });
            scores.Add(new CardScore { Id = 211 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 52) });
            scores.Add(new CardScore { Id = 212 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 52) });
            scores.Add(new CardScore { Id = 1111, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 52) });

            containers.Add(new CardContainer { Id = 53, ChronicleId = 58, Archetype = Archetype.Linza, Name = "Thurgo", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 53, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Thurgo.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 53) });
            scores.Add(new CardScore { Id = 213 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 53) });

            containers.Add(new CardContainer { Id = 54, ChronicleId = 59, Archetype = Archetype.TheRaptor, Name = "Varrock Guard", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 54, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Varrock_Guard.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 54) });
            scores.Add(new CardScore { Id = 214 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 54) });

            containers.Add(new CardContainer { Id = 55, ChronicleId = 60, Archetype = Archetype.TheRaptor, Name = "Amulet of Fury", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 55, Rewards = new CardRewards { Attack = 2, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Amulet_of_Fury.png", Version = "X", Cost = 8, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 55) });
            scores.Add(new CardScore { Id = 215 , Archetype = Archetype.TheRaptor, Score = 100, Card = cards.Single(c => c.Id == 55) });

            containers.Add(new CardContainer { Id = 56, ChronicleId = 61, Archetype = Archetype.Ozan, Name = "Bandit Camp", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 56, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Bandit_Camp.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 56) });
            scores.Add(new CardScore { Id = 216 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 56) });

            containers.Add(new CardContainer { Id = 57, ChronicleId = 62, Archetype = Archetype.Linza, Name = "Barrelchest", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 57, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Barrelchest.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 57) });
            scores.Add(new CardScore { Id = 217 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 57) });

            containers.Add(new CardContainer { Id = 58, ChronicleId = 63, Archetype = Archetype.TheRaptor, Name = "Bash", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 58, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Bash.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 58) });
            scores.Add(new CardScore { Id = 218 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 58) });

            containers.Add(new CardContainer { Id = 59, ChronicleId = 64, Archetype = null, Name = "Bounty Hunt", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 59, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Bounty_Hunt.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 59) });
            scores.Add(new CardScore { Id = 219 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 59) });
            scores.Add(new CardScore { Id = 220 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 59) });
            scores.Add(new CardScore { Id = 221 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 59) });
            scores.Add(new CardScore { Id = 222 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 59) });
            scores.Add(new CardScore { Id = 223 , Archetype = Archetype.Ozan     , Score = 30, Card = cards.Single(c => c.Id == 59) });
            scores.Add(new CardScore { Id = 1112, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 59) });

            containers.Add(new CardContainer { Id = 60, ChronicleId = 65, Archetype = Archetype.Ozan, Name = "Deadshot", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 60, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Deadshot.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 60) });
            scores.Add(new CardScore { Id = 224 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 60) });

            containers.Add(new CardContainer { Id = 61, ChronicleId = 66, Archetype = Archetype.TheRaptor, Name = "Assault", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 61, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Assault.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 61) });
            scores.Add(new CardScore { Id = 225 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 61) });

            containers.Add(new CardContainer { Id = 62, ChronicleId = 67, Archetype = Archetype.TheRaptor, Name = "Preparation", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 62, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Preparation.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 62) });
            scores.Add(new CardScore { Id = 226 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 62) });

            containers.Add(new CardContainer { Id = 63, ChronicleId = 68, Archetype = null, Name = "Brugsen Bursen", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 63, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Brugsen_Bursen.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 63) });
            scores.Add(new CardScore { Id = 227 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 63) });
            scores.Add(new CardScore { Id = 228 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 63) });
            scores.Add(new CardScore { Id = 229 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 63) });
            scores.Add(new CardScore { Id = 230 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 63) });
            scores.Add(new CardScore { Id = 231 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 63) });
            scores.Add(new CardScore { Id = 1113, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 63) });

            containers.Add(new CardContainer { Id = 64, ChronicleId = 69, Archetype = null, Name = "Bunyip", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 64, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Bunyip.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 64) });
            scores.Add(new CardScore { Id = 232 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 64) });
            scores.Add(new CardScore { Id = 233 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 64) });
            scores.Add(new CardScore { Id = 234 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 64) });
            scores.Add(new CardScore { Id = 235 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 64) });
            scores.Add(new CardScore { Id = 236 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 64) });
            scores.Add(new CardScore { Id = 1114, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 64) });

            containers.Add(new CardContainer { Id = 65, ChronicleId = 70, Archetype = Archetype.Ozan, Name = "Captain Rovin", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 65, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Captain_Rovin.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 65) });
            scores.Add(new CardScore { Id = 237 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 65) });

            containers.Add(new CardContainer { Id = 66, ChronicleId = 71, Archetype = Archetype.Ozan, Name = "Darren Lightfinger", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 66, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Darren_Lightfinger.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 66) });
            scores.Add(new CardScore { Id = 238 , Archetype = Archetype.Ozan     , Score = 90, Card = cards.Single(c => c.Id == 66) });

            containers.Add(new CardContainer { Id = 67, ChronicleId = 72, Archetype = null, Name = "Death Lotus Assassin", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 67, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Death_Lotus_Assassin.png", Version = "X", Cost = 5, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 67) });
            scores.Add(new CardScore { Id = 239 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 67) });
            scores.Add(new CardScore { Id = 240 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 67) });
            scores.Add(new CardScore { Id = 241 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 67) });
            scores.Add(new CardScore { Id = 242 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 67) });
            scores.Add(new CardScore { Id = 243 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 67) });
            scores.Add(new CardScore { Id = 1115, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 67) });

            containers.Add(new CardContainer { Id = 68, ChronicleId = 73, Archetype = null, Name = "Dragon Longsword", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 68, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Dragon_Longsword.png", Version = "X", Cost = 5, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 68) });
            scores.Add(new CardScore { Id = 244 , Archetype = Archetype.TheRaptor, Score = 90, Card = cards.Single(c => c.Id == 68) });
            scores.Add(new CardScore { Id = 245 , Archetype = Archetype.Linza    , Score = 90, Card = cards.Single(c => c.Id == 68) });
            scores.Add(new CardScore { Id = 246 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 68) });
            scores.Add(new CardScore { Id = 247 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 68) });
            scores.Add(new CardScore { Id = 248 , Archetype = Archetype.Ozan     , Score = 90, Card = cards.Single(c => c.Id == 68) });
            scores.Add(new CardScore { Id = 1116, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 68) });

            containers.Add(new CardContainer { Id = 69, ChronicleId = 74, Archetype = Archetype.Linza, Name = "Dragonbone Upgrade", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 69, Rewards = new CardRewards { Attack = 0, Armour = 5, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Dragonbone_Upgrade.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 69) });
            scores.Add(new CardScore { Id = 249 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 69) });

            containers.Add(new CardContainer { Id = 70, ChronicleId = 75, Archetype = null, Name = "Duel Tournament", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 70, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Duel_Tournament.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 70) });
            scores.Add(new CardScore { Id = 250 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 70) });
            scores.Add(new CardScore { Id = 251 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 70) });
            scores.Add(new CardScore { Id = 252 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 70) });
            scores.Add(new CardScore { Id = 253 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 70) });
            scores.Add(new CardScore { Id = 254 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 70) });
            scores.Add(new CardScore { Id = 1117, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 70) });

            containers.Add(new CardContainer { Id = 71, ChronicleId = 76, Archetype = Archetype.TheRaptor, Name = "Fight Cauldron", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 71, Rewards = new CardRewards { Attack = 0, Armour = 7, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Fight_Cauldron.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 71) });
            scores.Add(new CardScore { Id = 255 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 71) });

            containers.Add(new CardContainer { Id = 72, ChronicleId = 77, Archetype = Archetype.TheRaptor, Name = "Fight Pit", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 72, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Fight_Pit.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 72) });
            scores.Add(new CardScore { Id = 256 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 72) });

            containers.Add(new CardContainer { Id = 73, ChronicleId = 78, Archetype = Archetype.TheRaptor, Name = "Frenzy", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 73, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Frenzy.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 73) });
            scores.Add(new CardScore { Id = 257 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 73) });

            containers.Add(new CardContainer { Id = 74, ChronicleId = 79, Archetype = Archetype.TheRaptor, Name = "Armoured Zombie", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 74, Rewards = new CardRewards { Attack = 0, Armour = 4, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Armoured_Zombie.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 74) });
            scores.Add(new CardScore { Id = 258 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 74) });

            containers.Add(new CardContainer { Id = 75, ChronicleId = 80, Archetype = null, Name = "Wilderness", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 75, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Wilderness.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 75) });
            scores.Add(new CardScore { Id = 259 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 75) });
            scores.Add(new CardScore { Id = 260 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 75) });
            scores.Add(new CardScore { Id = 261 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 75) });
            scores.Add(new CardScore { Id = 262 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 75) });
            scores.Add(new CardScore { Id = 263 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 75) });
            scores.Add(new CardScore { Id = 1119, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 75) });

            containers.Add(new CardContainer { Id = 76, ChronicleId = 81, Archetype = null, Name = "Watchtower Guard", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 76, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Watchtower_Guard.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 76) });
            scores.Add(new CardScore { Id = 264 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 76) });
            scores.Add(new CardScore { Id = 265 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 76) });
            scores.Add(new CardScore { Id = 266 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 76) });
            scores.Add(new CardScore { Id = 267 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 76) });
            scores.Add(new CardScore { Id = 268 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 76) });
            scores.Add(new CardScore { Id = 1120, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 76) });

            containers.Add(new CardContainer { Id = 77, ChronicleId = 82, Archetype = Archetype.TheRaptor, Name = "Void Brawler", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 77, Rewards = new CardRewards { Attack = 0, Armour = 8, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Void_Brawler.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 77) });
            scores.Add(new CardScore { Id = 269 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 77) });

            containers.Add(new CardContainer { Id = 78, ChronicleId = 83, Archetype = Archetype.Linza, Name = "Varrock Museum", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 78, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Varrock_Museum.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 78) });
            scores.Add(new CardScore { Id = 270 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 78) });

            containers.Add(new CardContainer { Id = 79, ChronicleId = 84, Archetype = null, Name = "Mej-Kah", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 79, Rewards = new CardRewards { Attack = 0, Armour = 5, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Mej_Kah.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 79) });
            scores.Add(new CardScore { Id = 271 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 79) });
            scores.Add(new CardScore { Id = 272 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 79) });
            scores.Add(new CardScore { Id = 273 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 79) });
            scores.Add(new CardScore { Id = 274 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 79) });
            scores.Add(new CardScore { Id = 275 , Archetype = Archetype.Ozan     , Score = 30, Card = cards.Single(c => c.Id == 79) });
            scores.Add(new CardScore { Id = 1121, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 79) });

            containers.Add(new CardContainer { Id = 80, ChronicleId = 85, Archetype = Archetype.Linza, Name = "Toolbelt", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 80, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Toolbelt.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 80) });
            scores.Add(new CardScore { Id = 276 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 80) });

            containers.Add(new CardContainer { Id = 81, ChronicleId = 86, Archetype = Archetype.Linza, Name = "Tetsu Katana", Rarity = Rarity.Diamond, Type = CardType.Support });
            cards.Add(new Card { Id = 81, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Tetsu_Katana.png", Version = "X", Cost = 6, Health = 0, Active = false, Parent = containers.Single(p => p.Id == 81) });
            scores.Add(new CardScore { Id = 277 , Archetype = Archetype.Linza    , Score = 100, Card = cards.Single(c => c.Id == 81) });

            containers.Add(new CardContainer { Id = 82, ChronicleId = 87, Archetype = Archetype.Ozan, Name = "Snap Shot", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 82, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Snap_Shot.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 82) });
            scores.Add(new CardScore { Id = 278 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 82) });

            containers.Add(new CardContainer { Id = 83, ChronicleId = 88, Archetype = Archetype.Linza, Name = "Pulverise", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 83, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Pulverise.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 83) });
            scores.Add(new CardScore { Id = 279 , Archetype = Archetype.Linza    , Score = 100, Card = cards.Single(c => c.Id == 83) });

            containers.Add(new CardContainer { Id = 84, ChronicleId = 89, Archetype = Archetype.Ozan, Name = "Skeleton Champion", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 84, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Skeleton_Champion.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 84) });
            scores.Add(new CardScore { Id = 280 , Archetype = Archetype.Ozan     , Score = 90, Card = cards.Single(c => c.Id == 84) });

            containers.Add(new CardContainer { Id = 85, ChronicleId = 90, Archetype = null, Name = "Scorpion", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 85, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Scorpion.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 85) });
            scores.Add(new CardScore { Id = 281 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 85) });
            scores.Add(new CardScore { Id = 282 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 85) });
            scores.Add(new CardScore { Id = 283 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 85) });
            scores.Add(new CardScore { Id = 284 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 85) });
            scores.Add(new CardScore { Id = 285 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 85) });
            scores.Add(new CardScore { Id = 1122, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 85) });

            containers.Add(new CardContainer { Id = 86, ChronicleId = 91, Archetype = Archetype.TheRaptor, Name = "Saradomin Brew", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 86, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 2, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Saradomin_Brew.png", Version = "X", Cost = 4, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 86) });
            scores.Add(new CardScore { Id = 286 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 86) });

            containers.Add(new CardContainer { Id = 87, ChronicleId = 92, Archetype = Archetype.Ozan, Name = "Safe Spot", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 87, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Safe_Spot.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 87) });
            scores.Add(new CardScore { Id = 287 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 87) });

            containers.Add(new CardContainer { Id = 88, ChronicleId = 93, Archetype = Archetype.Ozan, Name = "Rogues' Den", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 88, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 4, Weapon = false }, Image = "/Content/img/cards/Rogues_Den.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 88) });
            scores.Add(new CardScore { Id = 288 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 88) });

            containers.Add(new CardContainer { Id = 89, ChronicleId = 94, Archetype = null, Name = "Ring of Charos", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 89, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ring_of_Charos.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 89) });
            scores.Add(new CardScore { Id = 289 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 89) });
            scores.Add(new CardScore { Id = 290 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 89) });
            scores.Add(new CardScore { Id = 291 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 89) });
            scores.Add(new CardScore { Id = 292 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 89) });
            scores.Add(new CardScore { Id = 293 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 89) });
            scores.Add(new CardScore { Id = 1123, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 89) });

            containers.Add(new CardContainer { Id = 90, ChronicleId = 95, Archetype = null, Name = "Revenant Demon", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 90, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Revenant_Demon.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 90) });
            scores.Add(new CardScore { Id = 294 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 90) });
            scores.Add(new CardScore { Id = 295 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 90) });
            scores.Add(new CardScore { Id = 296 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 90) });
            scores.Add(new CardScore { Id = 297 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 90) });
            scores.Add(new CardScore { Id = 298 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 90) });
            scores.Add(new CardScore { Id = 1124, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 90) });

            containers.Add(new CardContainer { Id = 91, ChronicleId = 96, Archetype = Archetype.Linza, Name = "Repurpose", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 91, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Repurpose.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 91) });
            scores.Add(new CardScore { Id = 299 , Archetype = Archetype.Linza    , Score = 90, Card = cards.Single(c => c.Id == 91) });

            containers.Add(new CardContainer { Id = 92, ChronicleId = 97, Archetype = Archetype.Ozan, Name = "Pyramid Plunder", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 92, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 4, Weapon = false }, Image = "/Content/img/cards/Pyramid_Plunder.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 92) });
            scores.Add(new CardScore { Id = 300 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 92) });

            containers.Add(new CardContainer { Id = 93, ChronicleId = 98, Archetype = null, Name = "Fern", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 93, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Fern.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 93) });
            scores.Add(new CardScore { Id = 301 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 93) });
            scores.Add(new CardScore { Id = 302 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 93) });
            scores.Add(new CardScore { Id = 303 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 93) });
            scores.Add(new CardScore { Id = 304 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 93) });
            scores.Add(new CardScore { Id = 305 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 93) });
            scores.Add(new CardScore { Id = 1125, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 93) });

            containers.Add(new CardContainer { Id = 94, ChronicleId = 99, Archetype = null, Name = "Ogre Chieftain", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 94, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Ogre_Chieftain.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 94) });
            scores.Add(new CardScore { Id = 306 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 94) });
            scores.Add(new CardScore { Id = 307 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 94) });
            scores.Add(new CardScore { Id = 308 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 94) });
            scores.Add(new CardScore { Id = 309 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 94) });
            scores.Add(new CardScore { Id = 310 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 94) });
            scores.Add(new CardScore { Id = 1126, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 94) });

            containers.Add(new CardContainer { Id = 95, ChronicleId = 100, Archetype = Archetype.TheRaptor, Name = "Monolith Chamber", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 95, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Monolith_Chamber.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 95) });
            scores.Add(new CardScore { Id = 311 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 95) });

            containers.Add(new CardContainer { Id = 96, ChronicleId = 101, Archetype = Archetype.Linza, Name = "Rune Dragon", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 96, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 4, Weapon = false }, Image = "/Content/img/cards/Rune_Dragon.png", Version = "X", Cost = 0, Health = 14, Active = true, Parent = containers.Single(p => p.Id == 96) });
            scores.Add(new CardScore { Id = 312 , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 96) });

            containers.Add(new CardContainer { Id = 97, ChronicleId = 102, Archetype = Archetype.Linza, Name = "Major Mary Rancour", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 97, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Major_Mary_Rancour.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 97) });
            scores.Add(new CardScore { Id = 313 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 97) });

            containers.Add(new CardContainer { Id = 98, ChronicleId = 103, Archetype = null, Name = "Mage of Zamorak", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 98, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Mage_of_Zamorak.png", Version = "X", Cost = 4, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 98) });
            scores.Add(new CardScore { Id = 314 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 98) });
            scores.Add(new CardScore { Id = 315 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 98) });
            scores.Add(new CardScore { Id = 316 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 98) });
            scores.Add(new CardScore { Id = 317 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 98) });
            scores.Add(new CardScore { Id = 318 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 98) });
            scores.Add(new CardScore { Id = 1127, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 98) });

            containers.Add(new CardContainer { Id = 99, ChronicleId = 104, Archetype = Archetype.Linza, Name = "Karam", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 99, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Karam.png", Version = "X", Cost = 7, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 99) });
            scores.Add(new CardScore { Id = 319 , Archetype = Archetype.Linza    , Score = 100, Card = cards.Single(c => c.Id == 99) });

            containers.Add(new CardContainer { Id = 100, ChronicleId = 105, Archetype = Archetype.Linza, Name = "Ice Warrior", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 100, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = true }, Image = "/Content/img/cards/Ice_Warrior.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 100) });
            scores.Add(new CardScore { Id = 320 , Archetype = Archetype.Linza    , Score = 90, Card = cards.Single(c => c.Id == 100) });

            containers.Add(new CardContainer { Id = 101, ChronicleId = 106, Archetype = Archetype.Linza, Name = "Hurl Weapon", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 101, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Hurl_Weapon.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 101) });
            scores.Add(new CardScore { Id = 321 , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 101) });

            containers.Add(new CardContainer { Id = 102, ChronicleId = 107, Archetype = null, Name = "Hobgoblin", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 102, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Hobgoblin.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 102) });
            scores.Add(new CardScore { Id = 322 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 102) });
            scores.Add(new CardScore { Id = 323 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 102) });
            scores.Add(new CardScore { Id = 324 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 102) });
            scores.Add(new CardScore { Id = 325 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 102) });
            scores.Add(new CardScore { Id = 326 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 102) });
            scores.Add(new CardScore { Id = 1128, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 102) });

            containers.Add(new CardContainer { Id = 103, ChronicleId = 108, Archetype = Archetype.Linza, Name = "Goblin Raider", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 103, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Goblin_Raider.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 103) });
            scores.Add(new CardScore { Id = 327 , Archetype = Archetype.Linza    , Score = 90, Card = cards.Single(c => c.Id == 103) });

            containers.Add(new CardContainer { Id = 104, ChronicleId = 109, Archetype = Archetype.Ozan, Name = "Gnome Guard", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 104, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 3, Weapon = false }, Image = "/Content/img/cards/Gnome_Guard.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 104) });
            scores.Add(new CardScore { Id = 328 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 104) });

            containers.Add(new CardContainer { Id = 105, ChronicleId = 110, Archetype = null, Name = "Full Dharok", Rarity = Rarity.Diamond, Type = CardType.Support });
            cards.Add(new Card { Id = 105, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Full_Dharok.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 105) });
            scores.Add(new CardScore { Id = 329 , Archetype = Archetype.TheRaptor, Score = 90, Card = cards.Single(c => c.Id == 105) });
            scores.Add(new CardScore { Id = 330 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 105) });
            scores.Add(new CardScore { Id = 331 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 105) });
            scores.Add(new CardScore { Id = 332 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 105) });
            scores.Add(new CardScore { Id = 333 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 105) });
            scores.Add(new CardScore { Id = 1129, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 105) });

            containers.Add(new CardContainer { Id = 106, ChronicleId = 111, Archetype = Archetype.Ozan, Name = "Eruni, Ayuni & Leeuni", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 106, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 6, Weapon = false }, Image = "/Content/img/cards/Eruni_Ayuni_Leeuni.png", Version = "X", Cost = 0, Health = 13, Active = true, Parent = containers.Single(p => p.Id == 106) });
            scores.Add(new CardScore { Id = 334 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 106) });

            containers.Add(new CardContainer { Id = 107, ChronicleId = 112, Archetype = Archetype.Ozan, Name = "Bob the Cat", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 107, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Bob_the_Cat.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 107) });
            scores.Add(new CardScore { Id = 335 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 107) });

            containers.Add(new CardContainer { Id = 108, ChronicleId = 113, Archetype = Archetype.Ozan, Name = "Deathtouched Darts", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 108, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Deathtouched_Darts.png", Version = "X", Cost = 10, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 108) });
            scores.Add(new CardScore { Id = 336 , Archetype = Archetype.Ozan     , Score = 90, Card = cards.Single(c => c.Id == 108) });

            containers.Add(new CardContainer { Id = 109, ChronicleId = 114, Archetype = Archetype.Linza, Name = "Work Order", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 109, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Work_Order.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 109) });
            scores.Add(new CardScore { Id = 337 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 109) });

            containers.Add(new CardContainer { Id = 110, ChronicleId = 115, Archetype = null, Name = "Wizard Traiborn", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 110, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Wizard_Traiborn.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 110) });
            scores.Add(new CardScore { Id = 338 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 110) });
            scores.Add(new CardScore { Id = 339 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 110) });
            scores.Add(new CardScore { Id = 340 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 110) });
            scores.Add(new CardScore { Id = 341 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 110) });
            scores.Add(new CardScore { Id = 342 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 110) });
            scores.Add(new CardScore { Id = 1130, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 110) });

            containers.Add(new CardContainer { Id = 111, ChronicleId = 116, Archetype = null, Name = "Undead Dragon", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 111, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Undead_Dragon.png", Version = "X", Cost = 0, Health = 13, Active = true, Parent = containers.Single(p => p.Id == 111) });
            scores.Add(new CardScore { Id = 343 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 111) });
            scores.Add(new CardScore { Id = 344 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 111) });
            scores.Add(new CardScore { Id = 345 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 111) });
            scores.Add(new CardScore { Id = 346 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 111) });
            scores.Add(new CardScore { Id = 347 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 111) });
            scores.Add(new CardScore { Id = 1131, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 111) });

            containers.Add(new CardContainer { Id = 112, ChronicleId = 117, Archetype = null, Name = "King Black Dragon", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 112, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 11, Weapon = false }, Image = "/Content/img/cards/King_Black_Dragon.png", Version = "X", Cost = 0, Health = 14, Active = true, Parent = containers.Single(p => p.Id == 112) });
            scores.Add(new CardScore { Id = 348 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 112) });
            scores.Add(new CardScore { Id = 349 , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 112) });
            scores.Add(new CardScore { Id = 350 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 112) });
            scores.Add(new CardScore { Id = 351 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 112) });
            scores.Add(new CardScore { Id = 352 , Archetype = Archetype.Ozan     , Score = 20, Card = cards.Single(c => c.Id == 112) });
            scores.Add(new CardScore { Id = 1132, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 112) });

            containers.Add(new CardContainer { Id = 113, ChronicleId = 118, Archetype = null, Name = "Giant Spider", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 113, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Giant_Spider.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 113) });
            scores.Add(new CardScore { Id = 353 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 113) });
            scores.Add(new CardScore { Id = 354 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 113) });
            scores.Add(new CardScore { Id = 355 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 113) });
            scores.Add(new CardScore { Id = 356 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 113) });
            scores.Add(new CardScore { Id = 357 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 113) });
            scores.Add(new CardScore { Id = 1133, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 113) });

            containers.Add(new CardContainer { Id = 114, ChronicleId = 119, Archetype = null, Name = "Ring of Recoil", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 114, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ring_of_Recoil.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 114) });
            scores.Add(new CardScore { Id = 358 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 114) });
            scores.Add(new CardScore { Id = 359 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 114) });
            scores.Add(new CardScore { Id = 360 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 114) });
            scores.Add(new CardScore { Id = 361 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 114) });
            scores.Add(new CardScore { Id = 362 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 114) });
            scores.Add(new CardScore { Id = 1134, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 114) });

            containers.Add(new CardContainer { Id = 115, ChronicleId = 120, Archetype = Archetype.Linza, Name = "Gravite Longsword", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 115, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Gravite_Longsword.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 115) });
            scores.Add(new CardScore { Id = 363 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 115) });

            containers.Add(new CardContainer { Id = 116, ChronicleId = 121, Archetype = Archetype.Linza, Name = "Chaotic Longsword", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 116, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Chaotic_Longsword.png", Version = "X", Cost = 4, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 116) });
            scores.Add(new CardScore { Id = 364 , Archetype = Archetype.Linza    , Score = 100, Card = cards.Single(c => c.Id == 116) });

            containers.Add(new CardContainer { Id = 117, ChronicleId = 122, Archetype = Archetype.Ozan, Name = "Heist", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 117, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Heist.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 117) });
            scores.Add(new CardScore { Id = 365 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 117) });

            containers.Add(new CardContainer { Id = 118, ChronicleId = 123, Archetype = null, Name = "Rolo the Stout", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 118, Rewards = new CardRewards { Attack = 0, Armour = 3, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Rolo_the_Stout.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 118) });
            scores.Add(new CardScore { Id = 366 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 118) });
            scores.Add(new CardScore { Id = 367 , Archetype = Archetype.Linza    , Score = 90, Card = cards.Single(c => c.Id == 118) });
            scores.Add(new CardScore { Id = 368 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 118) });
            scores.Add(new CardScore { Id = 369 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 118) });
            scores.Add(new CardScore { Id = 370 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 118) });
            scores.Add(new CardScore { Id = 1135, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 118) });

            containers.Add(new CardContainer { Id = 119, ChronicleId = 124, Archetype = null, Name = "Kayle", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 119, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Kayle.png", Version = "X", Cost = 0, Health = 2, Active = false, Parent = containers.Single(p => p.Id == 119) });
            scores.Add(new CardScore { Id = 371 , Archetype = Archetype.TheRaptor, Score = 90, Card = cards.Single(c => c.Id == 119) });
            scores.Add(new CardScore { Id = 372 , Archetype = Archetype.Linza    , Score = 90, Card = cards.Single(c => c.Id == 119) });
            scores.Add(new CardScore { Id = 373 , Archetype = Archetype.Ariane   , Score = 90, Card = cards.Single(c => c.Id == 119) });
            scores.Add(new CardScore { Id = 374 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 119) });
            scores.Add(new CardScore { Id = 375 , Archetype = Archetype.Ozan     , Score = 90, Card = cards.Single(c => c.Id == 119) });
            scores.Add(new CardScore { Id = 1136, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 119) });

            containers.Add(new CardContainer { Id = 120, ChronicleId = 125, Archetype = null, Name = "Morwenna", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 120, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Morwenna.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 120) });
            scores.Add(new CardScore { Id = 376 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 120) });
            scores.Add(new CardScore { Id = 377 , Archetype = Archetype.Linza    , Score = 90, Card = cards.Single(c => c.Id == 120) });
            scores.Add(new CardScore { Id = 378 , Archetype = Archetype.Ariane   , Score = 90, Card = cards.Single(c => c.Id == 120) });
            scores.Add(new CardScore { Id = 379 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 120) });
            scores.Add(new CardScore { Id = 380 , Archetype = Archetype.Ozan     , Score = 90, Card = cards.Single(c => c.Id == 120) });
            scores.Add(new CardScore { Id = 1137, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 120) });

            containers.Add(new CardContainer { Id = 121, ChronicleId = 126, Archetype = Archetype.Ozan, Name = "Ling, the Assassin", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 121, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ling_the_Assassin.png", Version = "X", Cost = 0, Health = 0, Active = false, Parent = containers.Single(p => p.Id == 121) });
            scores.Add(new CardScore { Id = 381 , Archetype = Archetype.Ozan     , Score = 30, Card = cards.Single(c => c.Id == 121) });

            containers.Add(new CardContainer { Id = 122, ChronicleId = 127, Archetype = Archetype.Ozan, Name = "Amascut Templeguard", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 122, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Amascut_Templeguard.png", Version = "X", Cost = 0, Health = 5, Active = false, Parent = containers.Single(p => p.Id == 122) });
            scores.Add(new CardScore { Id = 382 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 122) });

            containers.Add(new CardContainer { Id = 123, ChronicleId = 128, Archetype = null, Name = "Culinaromancer", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 123, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 10, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Culinaromancer.png", Version = "X", Cost = 0, Health = 6, Active = false, Parent = containers.Single(p => p.Id == 123) });
            scores.Add(new CardScore { Id = 383 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 123) });
            scores.Add(new CardScore { Id = 384 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 123) });
            scores.Add(new CardScore { Id = 385 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 123) });
            scores.Add(new CardScore { Id = 386 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 123) });
            scores.Add(new CardScore { Id = 387 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 123) });
            scores.Add(new CardScore { Id = 1138, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 123) });

            containers.Add(new CardContainer { Id = 124, ChronicleId = 129, Archetype = null, Name = "Exiled Kalphite Paragon", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 124, Rewards = new CardRewards { Attack = 0, Armour = 5, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Exiled_Kalphite_Paragon.png", Version = "X", Cost = 0, Health = 9, Active = true, Parent = containers.Single(p => p.Id == 124) });
            scores.Add(new CardScore { Id = 388 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 124) });
            scores.Add(new CardScore { Id = 389 , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 124) });
            scores.Add(new CardScore { Id = 390 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 124) });
            scores.Add(new CardScore { Id = 391 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 124) });
            scores.Add(new CardScore { Id = 392 , Archetype = Archetype.Ozan     , Score = 20, Card = cards.Single(c => c.Id == 124) });
            scores.Add(new CardScore { Id = 1139, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 124) });

            containers.Add(new CardContainer { Id = 125, ChronicleId = 130, Archetype = null, Name = "Oozing Kalphite", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 125, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Oozing_Kalphite.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 125) });
            scores.Add(new CardScore { Id = 393 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 125) });
            scores.Add(new CardScore { Id = 394 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 125) });
            scores.Add(new CardScore { Id = 395 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 125) });
            scores.Add(new CardScore { Id = 396 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 125) });
            scores.Add(new CardScore { Id = 397 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 125) });
            scores.Add(new CardScore { Id = 1140, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 125) });

            containers.Add(new CardContainer { Id = 126, ChronicleId = 131, Archetype = null, Name = "Kalphite Soldier", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 126, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 3, Weapon = false }, Image = "/Content/img/cards/Kalphite_Soldier.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 126) });
            scores.Add(new CardScore { Id = 398 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 126) });
            scores.Add(new CardScore { Id = 399 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 126) });
            scores.Add(new CardScore { Id = 400 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 126) });
            scores.Add(new CardScore { Id = 401 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 126) });
            scores.Add(new CardScore { Id = 402 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 126) });
            scores.Add(new CardScore { Id = 1141, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 126) });

            containers.Add(new CardContainer { Id = 127, ChronicleId = 132, Archetype = null, Name = "Kalphite Worker", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 127, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = true }, Image = "/Content/img/cards/Kalphite_Worker.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 127) });
            scores.Add(new CardScore { Id = 403 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 127) });
            scores.Add(new CardScore { Id = 404 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 127) });
            scores.Add(new CardScore { Id = 405 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 127) });
            scores.Add(new CardScore { Id = 406 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 127) });
            scores.Add(new CardScore { Id = 407 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 127) });
            scores.Add(new CardScore { Id = 1142, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 127) });

            containers.Add(new CardContainer { Id = 128, ChronicleId = 133, Archetype = null, Name = "Dagannoth Fledgling", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 128, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 6, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Dagannoth_Fledgling.png", Version = "X", Cost = 0, Health = 3, Active = false, Parent = containers.Single(p => p.Id == 128) });
            scores.Add(new CardScore { Id = 408 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 128) });
            scores.Add(new CardScore { Id = 409 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 128) });
            scores.Add(new CardScore { Id = 410 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 128) });
            scores.Add(new CardScore { Id = 411 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 128) });
            scores.Add(new CardScore { Id = 412 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 128) });
            scores.Add(new CardScore { Id = 1143, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 128) });

            containers.Add(new CardContainer { Id = 129, ChronicleId = 134, Archetype = Archetype.TheRaptor, Name = "Slam", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 129, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Slam.png", Version = "X", Cost = 4, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 129) });
            scores.Add(new CardScore { Id = 413 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 129) });

            containers.Add(new CardContainer { Id = 130, ChronicleId = 135, Archetype = null, Name = "Obsidian Golem", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 130, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 3, Weapon = false }, Image = "/Content/img/cards/Obsidian_Golem.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 130) });
            scores.Add(new CardScore { Id = 414 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 130) });
            scores.Add(new CardScore { Id = 415 , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 130) });
            scores.Add(new CardScore { Id = 416 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 130) });
            scores.Add(new CardScore { Id = 417 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 130) });
            scores.Add(new CardScore { Id = 418 , Archetype = Archetype.Ozan     , Score = 10, Card = cards.Single(c => c.Id == 130) });
            scores.Add(new CardScore { Id = 1144, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 130) });

            containers.Add(new CardContainer { Id = 131, ChronicleId = 136, Archetype = null, Name = "Rock Golem", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 131, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Rock_Golem.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 131) });
            scores.Add(new CardScore { Id = 419 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 131) });
            scores.Add(new CardScore { Id = 420 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 131) });
            scores.Add(new CardScore { Id = 421 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 131) });
            scores.Add(new CardScore { Id = 422 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 131) });
            scores.Add(new CardScore { Id = 423 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 131) });
            scores.Add(new CardScore { Id = 1145, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 131) });

            containers.Add(new CardContainer { Id = 132, ChronicleId = 137, Archetype = null, Name = "Sergeant Grimspike", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 132, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Sergeant_Grimspike.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 132) });
            scores.Add(new CardScore { Id = 424 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 132) });
            scores.Add(new CardScore { Id = 425 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 132) });
            scores.Add(new CardScore { Id = 426 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 132) });
            scores.Add(new CardScore { Id = 427 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 132) });
            scores.Add(new CardScore { Id = 428 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 132) });
            scores.Add(new CardScore { Id = 1146, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 132) });

            containers.Add(new CardContainer { Id = 133, ChronicleId = 138, Archetype = null, Name = "Sergeant Slimetoes", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 133, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Sergeant_Slimetoes.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 133) });
            scores.Add(new CardScore { Id = 429 , Archetype = Archetype.TheRaptor, Score = 90, Card = cards.Single(c => c.Id == 133) });
            scores.Add(new CardScore { Id = 430 , Archetype = Archetype.Linza    , Score = 90, Card = cards.Single(c => c.Id == 133) });
            scores.Add(new CardScore { Id = 431 , Archetype = Archetype.Ariane   , Score = 90, Card = cards.Single(c => c.Id == 133) });
            scores.Add(new CardScore { Id = 432 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 133) });
            scores.Add(new CardScore { Id = 433 , Archetype = Archetype.Ozan     , Score = 90, Card = cards.Single(c => c.Id == 133) });
            scores.Add(new CardScore { Id = 1118, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 133) });

            containers.Add(new CardContainer { Id = 134, ChronicleId = 139, Archetype = null, Name = "South Sea Pillager", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 134, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/South_Sea_Pillager.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 134) });
            scores.Add(new CardScore { Id = 434 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 134) });
            scores.Add(new CardScore { Id = 435 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 134) });
            scores.Add(new CardScore { Id = 436 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 134) });
            scores.Add(new CardScore { Id = 437 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 134) });
            scores.Add(new CardScore { Id = 438 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 134) });
            scores.Add(new CardScore { Id = 1147, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 134) });

            containers.Add(new CardContainer { Id = 135, ChronicleId = 140, Archetype = Archetype.Linza, Name = "Armadylean Golem", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 135, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 4, Weapon = false }, Image = "/Content/img/cards/Armadylean_Golem.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 135) });
            scores.Add(new CardScore { Id = 439 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 135) });

            containers.Add(new CardContainer { Id = 136, ChronicleId = 141, Archetype = Archetype.Linza, Name = "Living Rock Brawler", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 136, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Living_Rock_Brawler.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 136) });
            scores.Add(new CardScore { Id = 440 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 136) });

            containers.Add(new CardContainer { Id = 137, ChronicleId = 142, Archetype = Archetype.Linza, Name = "Dust Devil", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 137, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Dust_Devil.png", Version = "X", Cost = 0, Health = 5, Active = false, Parent = containers.Single(p => p.Id == 137) });
            scores.Add(new CardScore { Id = 441 , Archetype = Archetype.Linza    , Score = 100, Card = cards.Single(c => c.Id == 137) });

            containers.Add(new CardContainer { Id = 138, ChronicleId = 143, Archetype = Archetype.Linza, Name = "Drunken Dwarf", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 138, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 2, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Drunken_Dwarf.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 138) });
            scores.Add(new CardScore { Id = 442 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 138) });

            containers.Add(new CardContainer { Id = 139, ChronicleId = 144, Archetype = Archetype.Ozan, Name = "Bandit King", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 139, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Bandit_King.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 139) });
            scores.Add(new CardScore { Id = 443 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 139) });

            containers.Add(new CardContainer { Id = 140, ChronicleId = 145, Archetype = Archetype.Ozan, Name = "Desert Snake", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 140, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Desert_Snake.png", Version = "X", Cost = 0, Health = 1, Active = true, Parent = containers.Single(p => p.Id == 140) });
            scores.Add(new CardScore { Id = 444 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 140) });

            containers.Add(new CardContainer { Id = 141, ChronicleId = 146, Archetype = Archetype.Ozan, Name = "Desert Strykewyrm", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 141, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 5, Weapon = false }, Image = "/Content/img/cards/Desert_Strykewyrm.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 141) });
            scores.Add(new CardScore { Id = 445 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 141) });

            containers.Add(new CardContainer { Id = 142, ChronicleId = 147, Archetype = Archetype.Ozan, Name = "Dazing Shot", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 142, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Dazing_Shot.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 142) });
            scores.Add(new CardScore { Id = 446 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 142) });

            containers.Add(new CardContainer { Id = 143, ChronicleId = 148, Archetype = Archetype.TheRaptor, Name = "Chaos Dwarf", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 143, Rewards = new CardRewards { Attack = 0, Armour = 3, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Chaos_Dwarf.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 143) });
            scores.Add(new CardScore { Id = 447 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 143) });

            containers.Add(new CardContainer { Id = 144, ChronicleId = 149, Archetype = Archetype.TheRaptor, Name = "Goblin Brute", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 144, Rewards = new CardRewards { Attack = 0, Armour = 1, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Goblin_Brute.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 144) });
            scores.Add(new CardScore { Id = 448 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 144) });

            containers.Add(new CardContainer { Id = 145, ChronicleId = 150, Archetype = Archetype.TheRaptor, Name = "Revenant Dark Beast", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 145, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Revenant_Dark_Beast.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 145) });
            scores.Add(new CardScore { Id = 449 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 145) });

            containers.Add(new CardContainer { Id = 146, ChronicleId = 151, Archetype = Archetype.TheRaptor, Name = "Troll General", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 146, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 3, Weapon = false }, Image = "/Content/img/cards/Troll_General.png", Version = "X", Cost = 0, Health = 9, Active = true, Parent = containers.Single(p => p.Id == 146) });
            scores.Add(new CardScore { Id = 450 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 146) });

            containers.Add(new CardContainer { Id = 147, ChronicleId = 152, Archetype = Archetype.TheRaptor, Name = "Anticipation", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 147, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 2, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Anticipation.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 147) });
            scores.Add(new CardScore { Id = 451 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 147) });

            containers.Add(new CardContainer { Id = 148, ChronicleId = 153, Archetype = Archetype.TheRaptor, Name = "Berserker Shield", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 148, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Berserker_Shield.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 148) });
            scores.Add(new CardScore { Id = 452 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 148) });

            containers.Add(new CardContainer { Id = 149, ChronicleId = 154, Archetype = Archetype.Linza, Name = "Revenant Ork", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 149, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Revenant_Ork.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 149) });
            scores.Add(new CardScore { Id = 453 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 149) });

            containers.Add(new CardContainer { Id = 150, ChronicleId = 155, Archetype = null, Name = "Beer", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 150, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Beer.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 150) });
            scores.Add(new CardScore { Id = 454 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 150) });
            scores.Add(new CardScore { Id = 455 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 150) });
            scores.Add(new CardScore { Id = 456 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 150) });
            scores.Add(new CardScore { Id = 457 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 150) });
            scores.Add(new CardScore { Id = 458 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 150) });
            scores.Add(new CardScore { Id = 1148, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 150) });

            containers.Add(new CardContainer { Id = 151, ChronicleId = 156, Archetype = null, Name = "Strength Potion", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 151, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Strength_Potion.png", Version = "X", Cost = 4, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 151) });
            scores.Add(new CardScore { Id = 459 , Archetype = Archetype.TheRaptor, Score = 90, Card = cards.Single(c => c.Id == 151) });
            scores.Add(new CardScore { Id = 460 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 151) });
            scores.Add(new CardScore { Id = 461 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 151) });
            scores.Add(new CardScore { Id = 462 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 151) });
            scores.Add(new CardScore { Id = 463 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 151) });
            scores.Add(new CardScore { Id = 1149, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 151) });

            containers.Add(new CardContainer { Id = 152, ChronicleId = 157, Archetype = Archetype.Linza, Name = "Prototype", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 152, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Prototype.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 152) });
            scores.Add(new CardScore { Id = 464 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 152) });

            containers.Add(new CardContainer { Id = 153, ChronicleId = 158, Archetype = Archetype.Ozan, Name = "Khnum", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 153, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Khnum.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 153) });
            scores.Add(new CardScore { Id = 465 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 153) });

            containers.Add(new CardContainer { Id = 154, ChronicleId = 159, Archetype = Archetype.Ozan, Name = "Mithril Arrows", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 154, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Mithril_Arrows.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 154) });
            scores.Add(new CardScore { Id = 466 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 154) });

            containers.Add(new CardContainer { Id = 155, ChronicleId = 160, Archetype = Archetype.Ozan, Name = "Ranging Guild", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 155, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ranging_Guild.png", Version = "X", Cost = 7, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 155) });
            scores.Add(new CardScore { Id = 467 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 155) });

            containers.Add(new CardContainer { Id = 156, ChronicleId = 161, Archetype = Archetype.TheRaptor, Name = "Giant Champion", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 156, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Giant_Champion.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 156) });
            scores.Add(new CardScore { Id = 468 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 156) });

            containers.Add(new CardContainer { Id = 157, ChronicleId = 162, Archetype = Archetype.TheRaptor, Name = "Zamorak Brew", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 157, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Zamorak_Brew.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 157) });
            scores.Add(new CardScore { Id = 469 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 157) });

            containers.Add(new CardContainer { Id = 158, ChronicleId = 163, Archetype = null, Name = "Adamant Armour", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 158, Rewards = new CardRewards { Attack = 0, Armour = 5, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Adamant_Armour.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 158) });
            scores.Add(new CardScore { Id = 470 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 158) });
            scores.Add(new CardScore { Id = 471 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 158) });
            scores.Add(new CardScore { Id = 472 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 158) });
            scores.Add(new CardScore { Id = 473 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 158) });
            scores.Add(new CardScore { Id = 474 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 158) });
            scores.Add(new CardScore { Id = 1150, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 158) });

            containers.Add(new CardContainer { Id = 159, ChronicleId = 164, Archetype = null, Name = "Dagannoth Sentinel", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 159, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 5, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Dagannoth_Sentinel.png", Version = "X", Cost = 0, Health = 9, Active = false, Parent = containers.Single(p => p.Id == 159) });
            scores.Add(new CardScore { Id = 475 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 159) });
            scores.Add(new CardScore { Id = 476 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 159) });
            scores.Add(new CardScore { Id = 477 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 159) });
            scores.Add(new CardScore { Id = 478 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 159) });
            scores.Add(new CardScore { Id = 479 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 159) });
            scores.Add(new CardScore { Id = 1151, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 159) });

            containers.Add(new CardContainer { Id = 160, ChronicleId = 165, Archetype = null, Name = "Gee'ka", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 160, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Geeka.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 160) });
            scores.Add(new CardScore { Id = 480 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 160) });
            scores.Add(new CardScore { Id = 481 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 160) });
            scores.Add(new CardScore { Id = 482 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 160) });
            scores.Add(new CardScore { Id = 483 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 160) });
            scores.Add(new CardScore { Id = 484 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 160) });
            scores.Add(new CardScore { Id = 1152, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 160) });

            containers.Add(new CardContainer { Id = 161, ChronicleId = 166, Archetype = Archetype.Ariane, Name = "Infernal Mage", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 161, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Infernal_Mage.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 161) });
            scores.Add(new CardScore { Id = 485 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 161) });

            containers.Add(new CardContainer { Id = 162, ChronicleId = 167, Archetype = Archetype.Ariane, Name = "Haunted Soul", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 162, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Haunted_Soul.png", Version = "X", Cost = 0, Health = 5, Active = false, Parent = containers.Single(p => p.Id == 162) });
            scores.Add(new CardScore { Id = 486 , Archetype = Archetype.Ariane   , Score = 100, Card = cards.Single(c => c.Id == 162) });

            containers.Add(new CardContainer { Id = 163, ChronicleId = 168, Archetype = Archetype.Ariane, Name = "Crawling Hand", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 163, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Crawling_Hand.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 163) });
            scores.Add(new CardScore { Id = 487 , Archetype = Archetype.Ariane   , Score = 90, Card = cards.Single(c => c.Id == 163) });

            containers.Add(new CardContainer { Id = 164, ChronicleId = 169, Archetype = Archetype.Ariane, Name = "Wizard Mindbomb", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 164, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Wizard_Mindbomb.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 164) });
            scores.Add(new CardScore { Id = 488 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 164) });

            containers.Add(new CardContainer { Id = 165, ChronicleId = 170, Archetype = Archetype.Ariane, Name = "Earth Blast", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 165, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Earth_Blast.png", Version = "X", Cost = 8, Health = 0, Active = false, Parent = containers.Single(p => p.Id == 165) });
            scores.Add(new CardScore { Id = 489 , Archetype = Archetype.Ariane   , Score = 100, Card = cards.Single(c => c.Id == 165) });

            containers.Add(new CardContainer { Id = 166, ChronicleId = 171, Archetype = Archetype.Ariane, Name = "Wind Strike", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 166, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Wind_Strike.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 166) });
            scores.Add(new CardScore { Id = 490 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 166) });

            containers.Add(new CardContainer { Id = 167, ChronicleId = 172, Archetype = null, Name = "Balance Elemental", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 167, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Balance_Elemental.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 167) });
            scores.Add(new CardScore { Id = 491 , Archetype = Archetype.TheRaptor, Score = 10, Card = cards.Single(c => c.Id == 167) });
            scores.Add(new CardScore { Id = 492 , Archetype = Archetype.Linza    , Score = 10, Card = cards.Single(c => c.Id == 167) });
            scores.Add(new CardScore { Id = 493 , Archetype = Archetype.Ariane   , Score = 10, Card = cards.Single(c => c.Id == 167) });
            scores.Add(new CardScore { Id = 494 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 167) });
            scores.Add(new CardScore { Id = 495 , Archetype = Archetype.Ozan     , Score = 10, Card = cards.Single(c => c.Id == 167) });
            scores.Add(new CardScore { Id = 1153, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 167) });

            containers.Add(new CardContainer { Id = 168, ChronicleId = 173, Archetype = null, Name = "Black Demon", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 168, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Black_Demon.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 168) });
            scores.Add(new CardScore { Id = 496 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 168) });
            scores.Add(new CardScore { Id = 497 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 168) });
            scores.Add(new CardScore { Id = 498 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 168) });
            scores.Add(new CardScore { Id = 499 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 168) });
            scores.Add(new CardScore { Id = 500 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 168) });
            scores.Add(new CardScore { Id = 1154, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 168) });

            containers.Add(new CardContainer { Id = 169, ChronicleId = 174, Archetype = null, Name = "Cave Slime", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 169, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Cave_Slime.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 169) });
            scores.Add(new CardScore { Id = 501 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 169) });
            scores.Add(new CardScore { Id = 502 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 169) });
            scores.Add(new CardScore { Id = 503 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 169) });
            scores.Add(new CardScore { Id = 504 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 169) });
            scores.Add(new CardScore { Id = 505 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 169) });
            scores.Add(new CardScore { Id = 1155, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 169) });

            containers.Add(new CardContainer { Id = 170, ChronicleId = 175, Archetype = null, Name = "Commander Zilyana", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 170, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 12, Coins = 7, Weapon = false }, Image = "/Content/img/cards/Commander_Zilyana.png", Version = "X", Cost = 0, Health = 13, Active = true, Parent = containers.Single(p => p.Id == 170) });
            scores.Add(new CardScore { Id = 506 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 170) });
            scores.Add(new CardScore { Id = 507 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 170) });
            scores.Add(new CardScore { Id = 508 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 170) });
            scores.Add(new CardScore { Id = 509 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 170) });
            scores.Add(new CardScore { Id = 510 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 170) });
            scores.Add(new CardScore { Id = 1156, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 170) });

            containers.Add(new CardContainer { Id = 171, ChronicleId = 176, Archetype = null, Name = "Greater Demon", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 171, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Greater_Demon.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 171) });
            scores.Add(new CardScore { Id = 511 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 171) });
            scores.Add(new CardScore { Id = 512 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 171) });
            scores.Add(new CardScore { Id = 513 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 171) });
            scores.Add(new CardScore { Id = 514 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 171) });
            scores.Add(new CardScore { Id = 515 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 171) });
            scores.Add(new CardScore { Id = 1157, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 171) });

            containers.Add(new CardContainer { Id = 172, ChronicleId = 177, Archetype = null, Name = "Green Dragon", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 172, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Green_Dragon.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 172) });
            scores.Add(new CardScore { Id = 516 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 172) });
            scores.Add(new CardScore { Id = 517 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 172) });
            scores.Add(new CardScore { Id = 518 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 172) });
            scores.Add(new CardScore { Id = 519 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 172) });
            scores.Add(new CardScore { Id = 520 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 172) });
            scores.Add(new CardScore { Id = 1158, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 172) });

            containers.Add(new CardContainer { Id = 173, ChronicleId = 178, Archetype = null, Name = "Jogre Shaman", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 173, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Jogre_Shaman.png", Version = "X", Cost = 0, Health = 9, Active = true, Parent = containers.Single(p => p.Id == 173) });
            scores.Add(new CardScore { Id = 521 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 173) });
            scores.Add(new CardScore { Id = 522 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 173) });
            scores.Add(new CardScore { Id = 523 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 173) });
            scores.Add(new CardScore { Id = 524 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 173) });
            scores.Add(new CardScore { Id = 525 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 173) });
            scores.Add(new CardScore { Id = 1159, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 173) });

            containers.Add(new CardContainer { Id = 174, ChronicleId = 179, Archetype = null, Name = "Lesser Demon", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 174, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Lesser_Demon.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 174) });
            scores.Add(new CardScore { Id = 526 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 174) });
            scores.Add(new CardScore { Id = 527 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 174) });
            scores.Add(new CardScore { Id = 528 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 174) });
            scores.Add(new CardScore { Id = 529 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 174) });
            scores.Add(new CardScore { Id = 530 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 174) });
            scores.Add(new CardScore { Id = 1160, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 174) });

            containers.Add(new CardContainer { Id = 175, ChronicleId = 180, Archetype = null, Name = "Mutineer", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 175, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Mutineer.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 175) });
            scores.Add(new CardScore { Id = 531 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 175) });
            scores.Add(new CardScore { Id = 532 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 175) });
            scores.Add(new CardScore { Id = 533 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 175) });
            scores.Add(new CardScore { Id = 534 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 175) });
            scores.Add(new CardScore { Id = 535 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 175) });
            scores.Add(new CardScore { Id = 1161, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 175) });

            containers.Add(new CardContainer { Id = 176, ChronicleId = 181, Archetype = null, Name = "Ogre Warlord", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 176, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ogre_Warlord.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 176) });
            scores.Add(new CardScore { Id = 536 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 176) });
            scores.Add(new CardScore { Id = 537 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 176) });
            scores.Add(new CardScore { Id = 538 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 176) });
            scores.Add(new CardScore { Id = 539 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 176) });
            scores.Add(new CardScore { Id = 540 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 176) });
            scores.Add(new CardScore { Id = 1162, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 176) });

            containers.Add(new CardContainer { Id = 177, ChronicleId = 182, Archetype = null, Name = "Redbeard Frank", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 177, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Redbeard_Frank.png", Version = "X", Cost = 0, Health = 9, Active = false, Parent = containers.Single(p => p.Id == 177) });
            scores.Add(new CardScore { Id = 541 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 177) });
            scores.Add(new CardScore { Id = 542 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 177) });
            scores.Add(new CardScore { Id = 543 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 177) });
            scores.Add(new CardScore { Id = 544 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 177) });
            scores.Add(new CardScore { Id = 545 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 177) });
            scores.Add(new CardScore { Id = 1163, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 177) });

            containers.Add(new CardContainer { Id = 178, ChronicleId = 183, Archetype = null, Name = "Scarface Pete", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 178, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Scarface_Pete.png", Version = "X", Cost = 0, Health = 9, Active = true, Parent = containers.Single(p => p.Id == 178) });
            scores.Add(new CardScore { Id = 546 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 178) });
            scores.Add(new CardScore { Id = 547 , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 178) });
            scores.Add(new CardScore { Id = 548 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 178) });
            scores.Add(new CardScore { Id = 549 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 178) });
            scores.Add(new CardScore { Id = 550 , Archetype = Archetype.Ozan     , Score = 30, Card = cards.Single(c => c.Id == 178) });
            scores.Add(new CardScore { Id = 1164, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 178) });

            containers.Add(new CardContainer { Id = 179, ChronicleId = 184, Archetype = null, Name = "To'Kash", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 179, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/To_Kash.png", Version = "X", Cost = 0, Health = 14, Active = false, Parent = containers.Single(p => p.Id == 179) });
            scores.Add(new CardScore { Id = 551 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 179) });
            scores.Add(new CardScore { Id = 552 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 179) });
            scores.Add(new CardScore { Id = 553 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 179) });
            scores.Add(new CardScore { Id = 554 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 179) });
            scores.Add(new CardScore { Id = 555 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 179) });
            scores.Add(new CardScore { Id = 1165, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 179) });

            containers.Add(new CardContainer { Id = 180, ChronicleId = 185, Archetype = null, Name = "Wounded Kalphite", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 180, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Wounded_Kalphite.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 180) });
            scores.Add(new CardScore { Id = 556 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 180) });
            scores.Add(new CardScore { Id = 557 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 180) });
            scores.Add(new CardScore { Id = 558 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 180) });
            scores.Add(new CardScore { Id = 559 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 180) });
            scores.Add(new CardScore { Id = 560 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 180) });
            scores.Add(new CardScore { Id = 1166, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 180) });

            containers.Add(new CardContainer { Id = 181, ChronicleId = 186, Archetype = null, Name = "Shug", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 181, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Shug.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 181) });
            scores.Add(new CardScore { Id = 561 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 181) });
            scores.Add(new CardScore { Id = 562 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 181) });
            scores.Add(new CardScore { Id = 563 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 181) });
            scores.Add(new CardScore { Id = 564 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 181) });
            scores.Add(new CardScore { Id = 565 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 181) });
            scores.Add(new CardScore { Id = 1167, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 181) });

            containers.Add(new CardContainer { Id = 182, ChronicleId = 187, Archetype = null, Name = "Ghostship", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 182, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ghostship.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 182) });
            scores.Add(new CardScore { Id = 566 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 182) });
            scores.Add(new CardScore { Id = 567 , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 182) });
            scores.Add(new CardScore { Id = 568 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 182) });
            scores.Add(new CardScore { Id = 569 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 182) });
            scores.Add(new CardScore { Id = 570 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 182) });
            scores.Add(new CardScore { Id = 1168, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 182) });

            containers.Add(new CardContainer { Id = 183, ChronicleId = 188, Archetype = null, Name = "Weapon Poison", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 183, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Weapon_Poison.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 183) });
            scores.Add(new CardScore { Id = 571 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 183) });
            scores.Add(new CardScore { Id = 572 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 183) });
            scores.Add(new CardScore { Id = 573 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 183) });
            scores.Add(new CardScore { Id = 574 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 183) });
            scores.Add(new CardScore { Id = 575 , Archetype = Archetype.Ozan     , Score = 30, Card = cards.Single(c => c.Id == 183) });
            scores.Add(new CardScore { Id = 1169, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 183) });

            containers.Add(new CardContainer { Id = 184, ChronicleId = 189, Archetype = Archetype.Ariane, Name = "Ankou", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 184, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = true }, Image = "/Content/img/cards/Ankou.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 184) });
            scores.Add(new CardScore { Id = 576 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 184) });

            containers.Add(new CardContainer { Id = 185, ChronicleId = 190, Archetype = Archetype.Ariane, Name = "Chaos Elemental", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 185, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 4, Weapon = false }, Image = "/Content/img/cards/Chaos_Elemental.png", Version = "X", Cost = 0, Health = 16, Active = true, Parent = containers.Single(p => p.Id == 185) });
            scores.Add(new CardScore { Id = 577 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 185) });

            containers.Add(new CardContainer { Id = 186, ChronicleId = 191, Archetype = Archetype.Ariane, Name = "Unholy Cursebearer", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 186, Rewards = new CardRewards { Attack = 3, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Unholy_Cursebearer.png", Version = "X", Cost = 0, Health = 13, Active = true, Parent = containers.Single(p => p.Id == 186) });
            scores.Add(new CardScore { Id = 578 , Archetype = Archetype.Ariane   , Score = 10, Card = cards.Single(c => c.Id == 186) });

            containers.Add(new CardContainer { Id = 187, ChronicleId = 192, Archetype = Archetype.Ariane, Name = "Gnome Healer", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 187, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 4, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Gnome_Healer.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 187) });
            scores.Add(new CardScore { Id = 579 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 187) });

            containers.Add(new CardContainer { Id = 188, ChronicleId = 193, Archetype = Archetype.Ariane, Name = "Alchemy", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 188, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Alchemy.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 188) });
            scores.Add(new CardScore { Id = 580 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 188) });

            containers.Add(new CardContainer { Id = 189, ChronicleId = 194, Archetype = Archetype.Ariane, Name = "Bind", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 189, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Bind.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 189) });
            scores.Add(new CardScore { Id = 581 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 189) });

            containers.Add(new CardContainer { Id = 190, ChronicleId = 195, Archetype = Archetype.Ariane, Name = "Divine Storm", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 190, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Divine_Storm.png", Version = "X", Cost = 4, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 190) });
            scores.Add(new CardScore { Id = 582 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 190) });

            containers.Add(new CardContainer { Id = 191, ChronicleId = 196, Archetype = Archetype.Ariane, Name = "Earth Wave", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 191, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Earth_Wave.png", Version = "X", Cost = 5, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 191) });
            scores.Add(new CardScore { Id = 583 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 191) });

            containers.Add(new CardContainer { Id = 192, ChronicleId = 197, Archetype = Archetype.Ariane, Name = "Archmage Sedridor", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 192, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Archmage_Sedridor.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 192) });
            scores.Add(new CardScore { Id = 584 , Archetype = Archetype.Ariane   , Score = 100, Card = cards.Single(c => c.Id == 192) });

            containers.Add(new CardContainer { Id = 193, ChronicleId = 198, Archetype = Archetype.Ariane, Name = "Enfeeble", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 193, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Enfeeble.png", Version = "X", Cost = 0, Health = 0, Active = false, Parent = containers.Single(p => p.Id == 193) });
            scores.Add(new CardScore { Id = 585 , Archetype = Archetype.Ariane   , Score = 90, Card = cards.Single(c => c.Id == 193) });

            containers.Add(new CardContainer { Id = 194, ChronicleId = 199, Archetype = Archetype.Ariane, Name = "Fire Surge", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 194, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Fire_Surge.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 194) });
            scores.Add(new CardScore { Id = 586 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 194) });

            containers.Add(new CardContainer { Id = 195, ChronicleId = 200, Archetype = Archetype.Ariane, Name = "Lady Hefin", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 195, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Lady_Hefin.png", Version = "X", Cost = 3, Health = 0, Active = false, Parent = containers.Single(p => p.Id == 195) });
            scores.Add(new CardScore { Id = 587 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 195) });

            containers.Add(new CardContainer { Id = 196, ChronicleId = 201, Archetype = Archetype.Ariane, Name = "Ring of Kinship", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 196, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Ring_of_Kinship.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 196) });
            scores.Add(new CardScore { Id = 588 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 196) });

            containers.Add(new CardContainer { Id = 197, ChronicleId = 202, Archetype = Archetype.Ariane, Name = "Stagger", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 197, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Stagger.png", Version = "X", Cost = 4, Health = 0, Active = false, Parent = containers.Single(p => p.Id == 197) });
            scores.Add(new CardScore { Id = 589 , Archetype = Archetype.Ariane   , Score = 100, Card = cards.Single(c => c.Id == 197) });

            containers.Add(new CardContainer { Id = 198, ChronicleId = 203, Archetype = Archetype.Ariane, Name = "Wind Surge", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 198, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Wind_Surge.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 198) });
            scores.Add(new CardScore { Id = 590 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 198) });

            containers.Add(new CardContainer { Id = 199, ChronicleId = 204, Archetype = Archetype.Linza, Name = "Adamant Dragon", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 199, Rewards = new CardRewards { Attack = 0, Armour = 3, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Adamant_Dragon.png", Version = "X", Cost = 0, Health = 13, Active = true, Parent = containers.Single(p => p.Id == 199) });
            scores.Add(new CardScore { Id = 591 , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 199) });

            containers.Add(new CardContainer { Id = 200, ChronicleId = 205, Archetype = Archetype.Linza, Name = "Kal'Ger", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 200, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Kal_Ger.png", Version = "X", Cost = 0, Health = 8, Active = true, Parent = containers.Single(p => p.Id == 200) });
            scores.Add(new CardScore { Id = 592 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 200) });

            containers.Add(new CardContainer { Id = 201, ChronicleId = 206, Archetype = Archetype.Linza, Name = "TzHaar-Hur", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 201, Rewards = new CardRewards { Attack = 0, Armour = 4, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/TzHaar_Hur.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 201) });
            scores.Add(new CardScore { Id = 593 , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 201) });

            containers.Add(new CardContainer { Id = 202, ChronicleId = 207, Archetype = Archetype.Linza, Name = "Chaotic Rapier", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 202, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Chaotic_Rapier.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 202) });
            scores.Add(new CardScore { Id = 594 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 202) });

            containers.Add(new CardContainer { Id = 203, ChronicleId = 208, Archetype = Archetype.Linza, Name = "Flurry", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 203, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Flurry.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 203) });
            scores.Add(new CardScore { Id = 595 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 203) });

            containers.Add(new CardContainer { Id = 204, ChronicleId = 209, Archetype = Archetype.Ozan, Name = "Hope Devourer", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 204, Rewards = new CardRewards { Attack = 0, Armour = 7, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Hope_Devourer.png", Version = "X", Cost = 0, Health = 14, Active = true, Parent = containers.Single(p => p.Id == 204) });
            scores.Add(new CardScore { Id = 596 , Archetype = Archetype.Ozan     , Score = 100, Card = cards.Single(c => c.Id == 204) });

            containers.Add(new CardContainer { Id = 205, ChronicleId = 210, Archetype = Archetype.Ozan, Name = "Scabarite Assassin", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 205, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Scabarite_Assassin.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 205) });
            scores.Add(new CardScore { Id = 597 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 205) });

            containers.Add(new CardContainer { Id = 206, ChronicleId = 211, Archetype = Archetype.Ozan, Name = "Ullek Mummy", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 206, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Ullek_Mummy.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 206) });
            scores.Add(new CardScore { Id = 598 , Archetype = Archetype.Ozan     , Score = 30, Card = cards.Single(c => c.Id == 206) });

            containers.Add(new CardContainer { Id = 207, ChronicleId = 212, Archetype = Archetype.Ozan, Name = "Osman", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 207, Rewards = new CardRewards { Attack = 0, Armour = 3, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Osman.png", Version = "X", Cost = 0, Health = 13, Active = true, Parent = containers.Single(p => p.Id == 207) });
            scores.Add(new CardScore { Id = 599 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 207) });

            containers.Add(new CardContainer { Id = 208, ChronicleId = 213, Archetype = Archetype.Ozan, Name = "Ugthanki", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 208, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 4, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Ugthanki.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 208) });
            scores.Add(new CardScore { Id = 600 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 208) });

            containers.Add(new CardContainer { Id = 209, ChronicleId = 214, Archetype = Archetype.Ozan, Name = "Donation", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 209, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Donation.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 209) });
            scores.Add(new CardScore { Id = 601 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 209) });

            containers.Add(new CardContainer { Id = 210, ChronicleId = 215, Archetype = Archetype.Ozan, Name = "Smuggler", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 210, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Smuggler.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 210) });
            scores.Add(new CardScore { Id = 602 , Archetype = Archetype.Ozan     , Score = 20, Card = cards.Single(c => c.Id == 210) });

            containers.Add(new CardContainer { Id = 211, ChronicleId = 216, Archetype = Archetype.TheRaptor, Name = "Crazed Whaler", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 211, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Crazed_Whaler.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 211) });
            scores.Add(new CardScore { Id = 603 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 211) });

            containers.Add(new CardContainer { Id = 212, ChronicleId = 217, Archetype = Archetype.TheRaptor, Name = "Rock Crab", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 212, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 4, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Rock_Crab.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 212) });
            scores.Add(new CardScore { Id = 604 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 212) });

            containers.Add(new CardContainer { Id = 213, ChronicleId = 218, Archetype = Archetype.TheRaptor, Name = "TokHaar-Ket", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 213, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/TokHaar_Ket.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 213) });
            scores.Add(new CardScore { Id = 605 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 213) });

            containers.Add(new CardContainer { Id = 214, ChronicleId = 219, Archetype = Archetype.TheRaptor, Name = "Yk'Lagor", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 214, Rewards = new CardRewards { Attack = 2, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Yk_Lagor.png", Version = "X", Cost = 0, Health = 13, Active = true, Parent = containers.Single(p => p.Id == 214) });
            scores.Add(new CardScore { Id = 606 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 214) });

            containers.Add(new CardContainer { Id = 215, ChronicleId = 220, Archetype = Archetype.TheRaptor, Name = "Destroy", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 215, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Destroy.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 215) });
            scores.Add(new CardScore { Id = 607 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 215) });

            containers.Add(new CardContainer { Id = 216, ChronicleId = 221, Archetype = Archetype.TheRaptor, Name = "Reflect", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 216, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Reflect.png", Version = "X", Cost = 5, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 216) });
            scores.Add(new CardScore { Id = 608 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 216) });

            containers.Add(new CardContainer { Id = 217, ChronicleId = 222, Archetype = Archetype.TheRaptor, Name = "Ogre Trader", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 217, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ogre_Trader.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 217) });
            scores.Add(new CardScore { Id = 609 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 217) });

            containers.Add(new CardContainer { Id = 218, ChronicleId = 223, Archetype = Archetype.TheRaptor, Name = "TokTz-Ket-Em", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 218, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/TokTz_Ket_Em.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 218) });
            scores.Add(new CardScore { Id = 610 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 218) });

            containers.Add(new CardContainer { Id = 219, ChronicleId = 224, Archetype = Archetype.TheRaptor, Name = "War Tortoise", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 219, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/War_Tortoise.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 219) });
            scores.Add(new CardScore { Id = 611 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 219) });

            containers.Add(new CardContainer { Id = 220, ChronicleId = 232, Archetype = null, Name = "Bilrach", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 220, Rewards = new CardRewards { Attack = 2, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Bilrach.png", Version = "X", Cost = 0, Health = 17, Active = true, Parent = containers.Single(p => p.Id == 220) });
            scores.Add(new CardScore { Id = 612 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 220) });
            scores.Add(new CardScore { Id = 613 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 220) });
            scores.Add(new CardScore { Id = 614 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 220) });
            scores.Add(new CardScore { Id = 615 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 220) });
            scores.Add(new CardScore { Id = 616 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 220) });
            scores.Add(new CardScore { Id = 1170, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 220) });

            containers.Add(new CardContainer { Id = 221, ChronicleId = 233, Archetype = null, Name = "Ket-Zek", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 221, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ket_Zek.png", Version = "X", Cost = 0, Health = 7, Active = true, Parent = containers.Single(p => p.Id == 221) });
            scores.Add(new CardScore { Id = 617 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 221) });
            scores.Add(new CardScore { Id = 618 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 221) });
            scores.Add(new CardScore { Id = 619 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 221) });
            scores.Add(new CardScore { Id = 620 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 221) });
            scores.Add(new CardScore { Id = 621 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 221) });
            scores.Add(new CardScore { Id = 1171, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 221) });

            containers.Add(new CardContainer { Id = 222, ChronicleId = 234, Archetype = null, Name = "Kree'arra", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 222, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Kree_arra.png", Version = "X", Cost = 0, Health = 13, Active = true, Parent = containers.Single(p => p.Id == 222) });
            scores.Add(new CardScore { Id = 622 , Archetype = Archetype.TheRaptor, Score = 10, Card = cards.Single(c => c.Id == 222) });
            scores.Add(new CardScore { Id = 623 , Archetype = Archetype.Linza    , Score = 10, Card = cards.Single(c => c.Id == 222) });
            scores.Add(new CardScore { Id = 624 , Archetype = Archetype.Ariane   , Score = 10, Card = cards.Single(c => c.Id == 222) });
            scores.Add(new CardScore { Id = 625 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 222) });
            scores.Add(new CardScore { Id = 626 , Archetype = Archetype.Ozan     , Score = 10, Card = cards.Single(c => c.Id == 222) });
            scores.Add(new CardScore { Id = 1172, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 222) });

            containers.Add(new CardContainer { Id = 223, ChronicleId = 235, Archetype = null, Name = "Tenebra", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 223, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Tenebra.png", Version = "X", Cost = 0, Health = 13, Active = true, Parent = containers.Single(p => p.Id == 223) });
            scores.Add(new CardScore { Id = 627 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 223) });
            scores.Add(new CardScore { Id = 628 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 223) });
            scores.Add(new CardScore { Id = 629 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 223) });
            scores.Add(new CardScore { Id = 630 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 223) });
            scores.Add(new CardScore { Id = 631 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 223) });
            scores.Add(new CardScore { Id = 1173, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 223) });

            containers.Add(new CardContainer { Id = 224, ChronicleId = 237, Archetype = null, Name = "Kyzaj Tournament", Rarity = Rarity.Diamond, Type = CardType.Support });
            cards.Add(new Card { Id = 224, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Kyzaj_Tournament.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 224) });
            scores.Add(new CardScore { Id = 632 , Archetype = Archetype.TheRaptor, Score = 90, Card = cards.Single(c => c.Id == 224) });
            scores.Add(new CardScore { Id = 633 , Archetype = Archetype.Linza    , Score = 90, Card = cards.Single(c => c.Id == 224) });
            scores.Add(new CardScore { Id = 634 , Archetype = Archetype.Ariane   , Score = 90, Card = cards.Single(c => c.Id == 224) });
            scores.Add(new CardScore { Id = 635 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 224) });
            scores.Add(new CardScore { Id = 636 , Archetype = Archetype.Ozan     , Score = 90, Card = cards.Single(c => c.Id == 224) });
            scores.Add(new CardScore { Id = 1174, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 224) });

            containers.Add(new CardContainer { Id = 225, ChronicleId = 239, Archetype = Archetype.Ariane, Name = "Zamorakian Occultist", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 225, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Zamorakian_Occultist.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 225) });
            scores.Add(new CardScore { Id = 637 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 225) });

            containers.Add(new CardContainer { Id = 226, ChronicleId = 240, Archetype = Archetype.Ozan, Name = "Amascut Mystic", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 226, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Amascut_Mystic.png", Version = "X", Cost = 0, Health = 5, Active = false, Parent = containers.Single(p => p.Id == 226) });
            scores.Add(new CardScore { Id = 638 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 226) });

            containers.Add(new CardContainer { Id = 227, ChronicleId = 241, Archetype = Archetype.TheRaptor, Name = "TzHaar-Ket", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 227, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 3, Weapon = false }, Image = "/Content/img/cards/TzHaar_Ket.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 227) });
            scores.Add(new CardScore { Id = 639 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 227) });

            containers.Add(new CardContainer { Id = 228, ChronicleId = 242, Archetype = null, Name = "Black Knight Titan", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 228, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Black_Knight_Titan.png", Version = "X", Cost = 0, Health = 8, Active = true, Parent = containers.Single(p => p.Id == 228) });
            scores.Add(new CardScore { Id = 640 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 228) });
            scores.Add(new CardScore { Id = 641 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 228) });
            scores.Add(new CardScore { Id = 642 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 228) });
            scores.Add(new CardScore { Id = 643 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 228) });
            scores.Add(new CardScore { Id = 644 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 228) });
            scores.Add(new CardScore { Id = 1175, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 228) });

            containers.Add(new CardContainer { Id = 229, ChronicleId = 243, Archetype = null, Name = "Count Draynor", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 229, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Count_Draynor.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 229) });
            scores.Add(new CardScore { Id = 645 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 229) });
            scores.Add(new CardScore { Id = 646 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 229) });
            scores.Add(new CardScore { Id = 647 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 229) });
            scores.Add(new CardScore { Id = 648 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 229) });
            scores.Add(new CardScore { Id = 649 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 229) });
            scores.Add(new CardScore { Id = 1176, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 229) });

            containers.Add(new CardContainer { Id = 230, ChronicleId = 244, Archetype = null, Name = "Dr. Fenkenstrain", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 230, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 3, Weapon = false }, Image = "/Content/img/cards/Dr_Fenkenstrain.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 230) });
            scores.Add(new CardScore { Id = 650 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 230) });
            scores.Add(new CardScore { Id = 651 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 230) });
            scores.Add(new CardScore { Id = 652 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 230) });
            scores.Add(new CardScore { Id = 653 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 230) });
            scores.Add(new CardScore { Id = 654 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 230) });
            scores.Add(new CardScore { Id = 1177, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 230) });

            containers.Add(new CardContainer { Id = 231, ChronicleId = 245, Archetype = null, Name = "Grizzly Bear", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 231, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Grizzly_Bear.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 231) });
            scores.Add(new CardScore { Id = 655 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 231) });
            scores.Add(new CardScore { Id = 656 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 231) });
            scores.Add(new CardScore { Id = 657 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 231) });
            scores.Add(new CardScore { Id = 658 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 231) });
            scores.Add(new CardScore { Id = 659 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 231) });
            scores.Add(new CardScore { Id = 1178, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 231) });

            containers.Add(new CardContainer { Id = 232, ChronicleId = 246, Archetype = null, Name = "Kalphite Emissary", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 232, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Kalphite_Emissary.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 232) });
            scores.Add(new CardScore { Id = 660 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 232) });
            scores.Add(new CardScore { Id = 661 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 232) });
            scores.Add(new CardScore { Id = 662 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 232) });
            scores.Add(new CardScore { Id = 663 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 232) });
            scores.Add(new CardScore { Id = 664 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 232) });
            scores.Add(new CardScore { Id = 1179, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 232) });

            containers.Add(new CardContainer { Id = 233, ChronicleId = 248, Archetype = null, Name = "Melzar the Mad", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 233, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Melzar_the_Mad.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 233) });
            scores.Add(new CardScore { Id = 665 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 233) });
            scores.Add(new CardScore { Id = 666 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 233) });
            scores.Add(new CardScore { Id = 667 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 233) });
            scores.Add(new CardScore { Id = 668 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 233) });
            scores.Add(new CardScore { Id = 669 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 233) });
            scores.Add(new CardScore { Id = 1180, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 233) });

            containers.Add(new CardContainer { Id = 234, ChronicleId = 249, Archetype = null, Name = "Tok-Xil", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 234, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Tok_Xil.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 234) });
            scores.Add(new CardScore { Id = 670 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 234) });
            scores.Add(new CardScore { Id = 671 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 234) });
            scores.Add(new CardScore { Id = 672 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 234) });
            scores.Add(new CardScore { Id = 673 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 234) });
            scores.Add(new CardScore { Id = 674 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 234) });
            scores.Add(new CardScore { Id = 1181, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 234) });

            containers.Add(new CardContainer { Id = 235, ChronicleId = 250, Archetype = Archetype.Ariane, Name = "Skeletal Mage", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 235, Rewards = new CardRewards { Attack = 0, Armour = 3, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Skeletal_Mage.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 235) });
            scores.Add(new CardScore { Id = 675 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 235) });

            containers.Add(new CardContainer { Id = 236, ChronicleId = 251, Archetype = Archetype.Linza, Name = "Fremennik Crafter", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 236, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Fremennik_Crafter.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 236) });
            scores.Add(new CardScore { Id = 676 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 236) });

            containers.Add(new CardContainer { Id = 237, ChronicleId = 252, Archetype = Archetype.Ozan, Name = "Leela", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 237, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Leela.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 237) });
            scores.Add(new CardScore { Id = 677 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 237) });

            containers.Add(new CardContainer { Id = 238, ChronicleId = 253, Archetype = Archetype.TheRaptor, Name = "Animated Armour", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 238, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Animated_Armour.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 238) });
            scores.Add(new CardScore { Id = 678 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 238) });

            containers.Add(new CardContainer { Id = 239, ChronicleId = 254, Archetype = null, Name = "Wormbrain", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 239, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Wormbrain.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 239) });
            scores.Add(new CardScore { Id = 679 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 239) });
            scores.Add(new CardScore { Id = 680 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 239) });
            scores.Add(new CardScore { Id = 681 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 239) });
            scores.Add(new CardScore { Id = 682 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 239) });
            scores.Add(new CardScore { Id = 683 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 239) });
            scores.Add(new CardScore { Id = 1182, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 239) });

            containers.Add(new CardContainer { Id = 240, ChronicleId = 255, Archetype = Archetype.Ariane, Name = "Skeletal Peon", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 240, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Skeletal_Peon.png", Version = "X", Cost = 0, Health = 2, Active = false, Parent = containers.Single(p => p.Id == 240) });
            scores.Add(new CardScore { Id = 684 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 240) });

            containers.Add(new CardContainer { Id = 241, ChronicleId = 256, Archetype = null, Name = "Fishing Trawler", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 241, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Fishing_Trawler.png", Version = "X", Cost = 4, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 241) });
            scores.Add(new CardScore { Id = 685 , Archetype = Archetype.TheRaptor, Score = 90, Card = cards.Single(c => c.Id == 241) });
            scores.Add(new CardScore { Id = 686 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 241) });
            scores.Add(new CardScore { Id = 687 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 241) });
            scores.Add(new CardScore { Id = 688 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 241) });
            scores.Add(new CardScore { Id = 689 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 241) });
            scores.Add(new CardScore { Id = 1183, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 241) });

            containers.Add(new CardContainer { Id = 242, ChronicleId = 257, Archetype = null, Name = "Relicym's Balm", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 242, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Relicyms_Balm.png", Version = "X", Cost = 4, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 242) });
            scores.Add(new CardScore { Id = 690 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 242) });
            scores.Add(new CardScore { Id = 691 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 242) });
            scores.Add(new CardScore { Id = 692 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 242) });
            scores.Add(new CardScore { Id = 693 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 242) });
            scores.Add(new CardScore { Id = 694 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 242) });
            scores.Add(new CardScore { Id = 1184, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 242) });

            containers.Add(new CardContainer { Id = 243, ChronicleId = 262, Archetype = Archetype.Ariane, Name = "Ancient Spellbook", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 243, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ancient_Spellbook.png", Version = "X", Cost = 8, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 243) });
            scores.Add(new CardScore { Id = 695 , Archetype = Archetype.Ariane   , Score = 100, Card = cards.Single(c => c.Id == 243) });

            containers.Add(new CardContainer { Id = 244, ChronicleId = 267, Archetype = Archetype.Ariane, Name = "Lunar Spellbook", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 244, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Lunar_Spellbook.png", Version = "X", Cost = 8, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 244) });
            scores.Add(new CardScore { Id = 696 , Archetype = Archetype.Ariane   , Score = 100, Card = cards.Single(c => c.Id == 244) });

            containers.Add(new CardContainer { Id = 245, ChronicleId = 275, Archetype = null, Name = "K'ril Tsutsaroth", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 245, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Kril_Tsutsaroth.png", Version = "X", Cost = 0, Health = 7, Active = true, Parent = containers.Single(p => p.Id == 245) });
            scores.Add(new CardScore { Id = 697 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 245) });
            scores.Add(new CardScore { Id = 698 , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 245) });
            scores.Add(new CardScore { Id = 699 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 245) });
            scores.Add(new CardScore { Id = 700 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 245) });
            scores.Add(new CardScore { Id = 701 , Archetype = Archetype.Ozan     , Score = 20, Card = cards.Single(c => c.Id == 245) });
            scores.Add(new CardScore { Id = 1185, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 245) });

            containers.Add(new CardContainer { Id = 246, ChronicleId = 276, Archetype = null, Name = "Zemouregal", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 246, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Zemouregal.png", Version = "X", Cost = 0, Health = 7, Active = true, Parent = containers.Single(p => p.Id == 246) });
            scores.Add(new CardScore { Id = 702 , Archetype = Archetype.TheRaptor, Score = 10, Card = cards.Single(c => c.Id == 246) });
            scores.Add(new CardScore { Id = 703 , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 246) });
            scores.Add(new CardScore { Id = 704 , Archetype = Archetype.Ariane   , Score = 10, Card = cards.Single(c => c.Id == 246) });
            scores.Add(new CardScore { Id = 705 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 246) });
            scores.Add(new CardScore { Id = 706 , Archetype = Archetype.Ozan     , Score = 20, Card = cards.Single(c => c.Id == 246) });
            scores.Add(new CardScore { Id = 1186, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 246) });

            containers.Add(new CardContainer { Id = 247, ChronicleId = 277, Archetype = Archetype.Ariane, Name = "Revenant Knight", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 247, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Revenant_Knight.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 247) });
            scores.Add(new CardScore { Id = 707 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 247) });

            containers.Add(new CardContainer { Id = 248, ChronicleId = 278, Archetype = Archetype.Ariane, Name = "Troll Shaman", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 248, Rewards = new CardRewards { Attack = 0, Armour = 4, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Troll_Shaman.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 248) });
            scores.Add(new CardScore { Id = 708 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 248) });

            containers.Add(new CardContainer { Id = 249, ChronicleId = 279, Archetype = Archetype.Linza, Name = "Weaponmaster", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 249, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Weaponmaster.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 249) });
            scores.Add(new CardScore { Id = 709 , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 249) });

            containers.Add(new CardContainer { Id = 250, ChronicleId = 280, Archetype = null, Name = "Goblin Trickster", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 250, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Goblin_Trickster.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 250) });
            scores.Add(new CardScore { Id = 710 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 250) });
            scores.Add(new CardScore { Id = 711 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 250) });
            scores.Add(new CardScore { Id = 712 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 250) });
            scores.Add(new CardScore { Id = 713 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 250) });
            scores.Add(new CardScore { Id = 714 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 250) });
            scores.Add(new CardScore { Id = 1187, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 250) });

            containers.Add(new CardContainer { Id = 251, ChronicleId = 281, Archetype = Archetype.Ariane, Name = "Animated Book", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 251, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Animated_Book.png", Version = "X", Cost = 0, Health = 1, Active = true, Parent = containers.Single(p => p.Id == 251) });
            scores.Add(new CardScore { Id = 715 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 251) });

            containers.Add(new CardContainer { Id = 252, ChronicleId = 282, Archetype = Archetype.Linza, Name = "Dwarven Miner", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 252, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Dwarven_Miner.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 252) });
            scores.Add(new CardScore { Id = 716 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 252) });

            containers.Add(new CardContainer { Id = 253, ChronicleId = 283, Archetype = Archetype.Ariane, Name = "Crumble Undead", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 253, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Crumble_Undead.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 253) });
            scores.Add(new CardScore { Id = 717 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 253) });

            containers.Add(new CardContainer { Id = 254, ChronicleId = 285, Archetype = Archetype.Linza, Name = "Ramokee Hoarder", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 254, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ramokee_Hoarder.png", Version = "X", Cost = 0, Health = 7, Active = true, Parent = containers.Single(p => p.Id == 254) });
            scores.Add(new CardScore { Id = 718 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 254) });

            containers.Add(new CardContainer { Id = 255, ChronicleId = 286, Archetype = Archetype.Ozan, Name = "Lady Keli", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 255, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 5, Weapon = false }, Image = "/Content/img/cards/Lady_Keli.png", Version = "X", Cost = 0, Health = 7, Active = true, Parent = containers.Single(p => p.Id == 255) });
            scores.Add(new CardScore { Id = 719 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 255) });

            containers.Add(new CardContainer { Id = 256, ChronicleId = 287, Archetype = null, Name = "Stinkears", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 256, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Stinkears.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 256) });
            scores.Add(new CardScore { Id = 720 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 256) });
            scores.Add(new CardScore { Id = 721 , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 256) });
            scores.Add(new CardScore { Id = 722 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 256) });
            scores.Add(new CardScore { Id = 723 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 256) });
            scores.Add(new CardScore { Id = 724 , Archetype = Archetype.Ozan     , Score = 30, Card = cards.Single(c => c.Id == 256) });
            scores.Add(new CardScore { Id = 1188, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 256) });

            containers.Add(new CardContainer { Id = 257, ChronicleId = 288, Archetype = null, Name = "Drunken Pirate", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 257, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Drunken_Pirate.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 257) });
            scores.Add(new CardScore { Id = 725 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 257) });
            scores.Add(new CardScore { Id = 726 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 257) });
            scores.Add(new CardScore { Id = 727 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 257) });
            scores.Add(new CardScore { Id = 728 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 257) });
            scores.Add(new CardScore { Id = 729 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 257) });
            scores.Add(new CardScore { Id = 1189, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 257) });

            containers.Add(new CardContainer { Id = 258, ChronicleId = 295, Archetype = null, Name = "Saradomin Godsword", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 258, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 4, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Saradomin_Godsword.png", Version = "X", Cost = 7, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 258) });
            scores.Add(new CardScore { Id = 730 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 258) });
            scores.Add(new CardScore { Id = 731 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 258) });
            scores.Add(new CardScore { Id = 732 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 258) });
            scores.Add(new CardScore { Id = 733 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 258) });
            scores.Add(new CardScore { Id = 734 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 258) });
            scores.Add(new CardScore { Id = 1190, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 258) });

            containers.Add(new CardContainer { Id = 259, ChronicleId = 296, Archetype = Archetype.Ariane, Name = "Lexicus Runewright", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 259, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 4, Weapon = false }, Image = "/Content/img/cards/Lexicus_Runewright.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 259) });
            scores.Add(new CardScore { Id = 735 , Archetype = Archetype.Ariane   , Score = 90, Card = cards.Single(c => c.Id == 259) });

            containers.Add(new CardContainer { Id = 260, ChronicleId = 297, Archetype = Archetype.TheRaptor, Name = "Barricade", Rarity = Rarity.Diamond, Type = CardType.Support });
            cards.Add(new Card { Id = 260, Rewards = new CardRewards { Attack = 0, Armour = 10, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Barricade.png", Version = "X", Cost = 4, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 260) });
            scores.Add(new CardScore { Id = 736 , Archetype = Archetype.TheRaptor, Score = 90, Card = cards.Single(c => c.Id == 260) });

            containers.Add(new CardContainer { Id = 261, ChronicleId = 298, Archetype = Archetype.Linza, Name = "Char", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 261, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Char.png", Version = "X", Cost = 0, Health = 11, Active = false, Parent = containers.Single(p => p.Id == 261) });
            scores.Add(new CardScore { Id = 737 , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 261) });

            containers.Add(new CardContainer { Id = 262, ChronicleId = 299, Archetype = Archetype.Ariane, Name = "Ellaron", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 262, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ellaron.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 262) });
            scores.Add(new CardScore { Id = 738 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 262) });

            containers.Add(new CardContainer { Id = 263, ChronicleId = 300, Archetype = Archetype.Ariane, Name = "Lord Iban", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 263, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Lord_Iban.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 263) });
            scores.Add(new CardScore { Id = 739 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 263) });

            containers.Add(new CardContainer { Id = 264, ChronicleId = 301, Archetype = null, Name = "Silverlight", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 264, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Silverlight.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 264) });
            scores.Add(new CardScore { Id = 740 , Archetype = Archetype.TheRaptor, Score = 10, Card = cards.Single(c => c.Id == 264) });
            scores.Add(new CardScore { Id = 741 , Archetype = Archetype.Linza    , Score = 10, Card = cards.Single(c => c.Id == 264) });
            scores.Add(new CardScore { Id = 742 , Archetype = Archetype.Ariane   , Score = 10, Card = cards.Single(c => c.Id == 264) });
            scores.Add(new CardScore { Id = 743 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 264) });
            scores.Add(new CardScore { Id = 744 , Archetype = Archetype.Ozan     , Score = 10, Card = cards.Single(c => c.Id == 264) });
            scores.Add(new CardScore { Id = 1191, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 264) });

            containers.Add(new CardContainer { Id = 265, ChronicleId = 302, Archetype = null, Name = "Lumpnose", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 265, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Lumpnose.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 265) });
            scores.Add(new CardScore { Id = 745 , Archetype = Archetype.TheRaptor, Score = 10, Card = cards.Single(c => c.Id == 265) });
            scores.Add(new CardScore { Id = 746 , Archetype = Archetype.Linza    , Score = 10, Card = cards.Single(c => c.Id == 265) });
            scores.Add(new CardScore { Id = 747 , Archetype = Archetype.Ariane   , Score = 10, Card = cards.Single(c => c.Id == 265) });
            scores.Add(new CardScore { Id = 748 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 265) });
            scores.Add(new CardScore { Id = 749 , Archetype = Archetype.Ozan     , Score = 10, Card = cards.Single(c => c.Id == 265) });
            scores.Add(new CardScore { Id = 1192, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 265) });

            containers.Add(new CardContainer { Id = 266, ChronicleId = 303, Archetype = null, Name = "Keris", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 266, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Keris.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 266) });
            scores.Add(new CardScore { Id = 750 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 266) });
            scores.Add(new CardScore { Id = 751 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 266) });
            scores.Add(new CardScore { Id = 752 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 266) });
            scores.Add(new CardScore { Id = 753 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 266) });
            scores.Add(new CardScore { Id = 754 , Archetype = Archetype.Ozan     , Score = 20, Card = cards.Single(c => c.Id == 266) });
            scores.Add(new CardScore { Id = 1193, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 266) });

            containers.Add(new CardContainer { Id = 267, ChronicleId = 304, Archetype = Archetype.Ariane, Name = "Banshee", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 267, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Banshee.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 267) });
            scores.Add(new CardScore { Id = 755 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 267) });

            containers.Add(new CardContainer { Id = 268, ChronicleId = 306, Archetype = null, Name = "Antifire Potion", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 268, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 2, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Antifire_Potion.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 268) });
            scores.Add(new CardScore { Id = 756 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 268) });
            scores.Add(new CardScore { Id = 757 , Archetype = Archetype.Linza    , Score = 10, Card = cards.Single(c => c.Id == 268) });
            scores.Add(new CardScore { Id = 758 , Archetype = Archetype.Ariane   , Score = 10, Card = cards.Single(c => c.Id == 268) });
            scores.Add(new CardScore { Id = 759 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 268) });
            scores.Add(new CardScore { Id = 760 , Archetype = Archetype.Ozan     , Score = 10, Card = cards.Single(c => c.Id == 268) });
            scores.Add(new CardScore { Id = 1194, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 268) });

            containers.Add(new CardContainer { Id = 269, ChronicleId = 307, Archetype = Archetype.Ozan, Name = "Black Marketeer", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 269, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Black_Marketeer.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 269) });
            scores.Add(new CardScore { Id = 761 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 269) });

            containers.Add(new CardContainer { Id = 270, ChronicleId = 308, Archetype = null, Name = "Chaos Druid", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 270, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Chaos_Druid.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 270) });
            scores.Add(new CardScore { Id = 762 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 270) });
            scores.Add(new CardScore { Id = 763 , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 270) });
            scores.Add(new CardScore { Id = 764 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 270) });
            scores.Add(new CardScore { Id = 765 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 270) });
            scores.Add(new CardScore { Id = 766 , Archetype = Archetype.Ozan     , Score = 20, Card = cards.Single(c => c.Id == 270) });
            scores.Add(new CardScore { Id = 1195, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 270) });

            containers.Add(new CardContainer { Id = 271, ChronicleId = 309, Archetype = null, Name = "Crystal Flask", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 271, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Crystal_Flask.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 271) });
            scores.Add(new CardScore { Id = 767 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 271) });
            scores.Add(new CardScore { Id = 768 , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 271) });
            scores.Add(new CardScore { Id = 769 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 271) });
            scores.Add(new CardScore { Id = 770 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 271) });
            scores.Add(new CardScore { Id = 771 , Archetype = Archetype.Ozan     , Score = 20, Card = cards.Single(c => c.Id == 271) });
            scores.Add(new CardScore { Id = 1196, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 271) });

            containers.Add(new CardContainer { Id = 272, ChronicleId = 310, Archetype = null, Name = "Corpse Archer", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 272, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Corpse_Archer.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 272) });
            scores.Add(new CardScore { Id = 772 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 272) });
            scores.Add(new CardScore { Id = 773 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 272) });
            scores.Add(new CardScore { Id = 774 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 272) });
            scores.Add(new CardScore { Id = 775 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 272) });
            scores.Add(new CardScore { Id = 776 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 272) });
            scores.Add(new CardScore { Id = 1197, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 272) });

            containers.Add(new CardContainer { Id = 273, ChronicleId = 311, Archetype = null, Name = "Kaqemeex", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 273, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Kaqemeex.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 273) });
            scores.Add(new CardScore { Id = 777 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 273) });
            scores.Add(new CardScore { Id = 778 , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 273) });
            scores.Add(new CardScore { Id = 779 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 273) });
            scores.Add(new CardScore { Id = 780 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 273) });
            scores.Add(new CardScore { Id = 781 , Archetype = Archetype.Ozan     , Score = 30, Card = cards.Single(c => c.Id == 273) });
            scores.Add(new CardScore { Id = 1198, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 273) });

            containers.Add(new CardContainer { Id = 274, ChronicleId = 312, Archetype = null, Name = "Dragith Nurn", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 274, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Dragith_Nurn.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 274) });
            scores.Add(new CardScore { Id = 782 , Archetype = Archetype.TheRaptor, Score = 10, Card = cards.Single(c => c.Id == 274) });
            scores.Add(new CardScore { Id = 783 , Archetype = Archetype.Linza    , Score = 10, Card = cards.Single(c => c.Id == 274) });
            scores.Add(new CardScore { Id = 784 , Archetype = Archetype.Ariane   , Score = 10, Card = cards.Single(c => c.Id == 274) });
            scores.Add(new CardScore { Id = 785 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 274) });
            scores.Add(new CardScore { Id = 786 , Archetype = Archetype.Ozan     , Score = 10, Card = cards.Single(c => c.Id == 274) });
            scores.Add(new CardScore { Id = 1199, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 274) });

            containers.Add(new CardContainer { Id = 275, ChronicleId = 313, Archetype = null, Name = "Falador Party Room", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 275, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Falador_Party_Room.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 275) });
            scores.Add(new CardScore { Id = 787 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 275) });
            scores.Add(new CardScore { Id = 788 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 275) });
            scores.Add(new CardScore { Id = 789 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 275) });
            scores.Add(new CardScore { Id = 790 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 275) });
            scores.Add(new CardScore { Id = 791 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 275) });
            scores.Add(new CardScore { Id = 1200, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 275) });

            containers.Add(new CardContainer { Id = 276, ChronicleId = 314, Archetype = null, Name = "Papa Mambo", Rarity = Rarity.Diamond, Type = CardType.Support });
            cards.Add(new Card { Id = 276, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Papa_Mambo.png", Version = "X", Cost = 3, Health = 0, Active = false, Parent = containers.Single(p => p.Id == 276) });
            scores.Add(new CardScore { Id = 792 , Archetype = Archetype.TheRaptor, Score = 10, Card = cards.Single(c => c.Id == 276) });
            scores.Add(new CardScore { Id = 793 , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 276) });
            scores.Add(new CardScore { Id = 794 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 276) });
            scores.Add(new CardScore { Id = 795 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 276) });
            scores.Add(new CardScore { Id = 796 , Archetype = Archetype.Ozan     , Score = 20, Card = cards.Single(c => c.Id == 276) });
            scores.Add(new CardScore { Id = 1201, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 276) });

            containers.Add(new CardContainer { Id = 277, ChronicleId = 315, Archetype = null, Name = "Ice Troll", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 277, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Ice_Troll.png", Version = "X", Cost = 0, Health = 9, Active = true, Parent = containers.Single(p => p.Id == 277) });
            scores.Add(new CardScore { Id = 797 , Archetype = Archetype.TheRaptor, Score = 10, Card = cards.Single(c => c.Id == 277) });
            scores.Add(new CardScore { Id = 798 , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 277) });
            scores.Add(new CardScore { Id = 799 , Archetype = Archetype.Ariane   , Score = 10, Card = cards.Single(c => c.Id == 277) });
            scores.Add(new CardScore { Id = 800 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 277) });
            scores.Add(new CardScore { Id = 801 , Archetype = Archetype.Ozan     , Score = 10, Card = cards.Single(c => c.Id == 277) });
            scores.Add(new CardScore { Id = 1202, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 277) });

            containers.Add(new CardContainer { Id = 278, ChronicleId = 316, Archetype = null, Name = "Kalphite Egg Chamber", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 278, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Kalphite_Egg_Chamber.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 278) });
            scores.Add(new CardScore { Id = 802 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 278) });
            scores.Add(new CardScore { Id = 803 , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 278) });
            scores.Add(new CardScore { Id = 804 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 278) });
            scores.Add(new CardScore { Id = 805 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 278) });
            scores.Add(new CardScore { Id = 806 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 278) });
            scores.Add(new CardScore { Id = 1203, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 278) });

            containers.Add(new CardContainer { Id = 279, ChronicleId = 317, Archetype = null, Name = "Unstable Concoction", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 279, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Unstable_Concoction.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 279) });
            scores.Add(new CardScore { Id = 807 , Archetype = Archetype.TheRaptor, Score = 10, Card = cards.Single(c => c.Id == 279) });
            scores.Add(new CardScore { Id = 808 , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 279) });
            scores.Add(new CardScore { Id = 809 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 279) });
            scores.Add(new CardScore { Id = 810 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 279) });
            scores.Add(new CardScore { Id = 811 , Archetype = Archetype.Ozan     , Score = 20, Card = cards.Single(c => c.Id == 279) });
            scores.Add(new CardScore { Id = 1204, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 279) });

            containers.Add(new CardContainer { Id = 280, ChronicleId = 318, Archetype = null, Name = "50 Ships Mufassah", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 280, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/50_Ships_Mufassah.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 280) });
            scores.Add(new CardScore { Id = 812 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 280) });
            scores.Add(new CardScore { Id = 813 , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 280) });
            scores.Add(new CardScore { Id = 814 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 280) });
            scores.Add(new CardScore { Id = 815 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 280) });
            scores.Add(new CardScore { Id = 816 , Archetype = Archetype.Ozan     , Score = 30, Card = cards.Single(c => c.Id == 280) });
            scores.Add(new CardScore { Id = 1205, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 280) });

            containers.Add(new CardContainer { Id = 281, ChronicleId = 319, Archetype = null, Name = "Barker Toad", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 281, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Barker_Toad.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 281) });
            scores.Add(new CardScore { Id = 817 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 281) });
            scores.Add(new CardScore { Id = 818 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 281) });
            scores.Add(new CardScore { Id = 819 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 281) });
            scores.Add(new CardScore { Id = 820 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 281) });
            scores.Add(new CardScore { Id = 821 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 281) });
            scores.Add(new CardScore { Id = 1206, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 281) });

            containers.Add(new CardContainer { Id = 282, ChronicleId = 321, Archetype = null, Name = "Cabin Boy", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 282, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Cabin_Boy.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 282) });
            scores.Add(new CardScore { Id = 822 , Archetype = Archetype.TheRaptor, Score = 10, Card = cards.Single(c => c.Id == 282) });
            scores.Add(new CardScore { Id = 823 , Archetype = Archetype.Linza    , Score = 10, Card = cards.Single(c => c.Id == 282) });
            scores.Add(new CardScore { Id = 824 , Archetype = Archetype.Ariane   , Score = 10, Card = cards.Single(c => c.Id == 282) });
            scores.Add(new CardScore { Id = 825 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 282) });
            scores.Add(new CardScore { Id = 826 , Archetype = Archetype.Ozan     , Score = 10, Card = cards.Single(c => c.Id == 282) });
            scores.Add(new CardScore { Id = 1207, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 282) });

            containers.Add(new CardContainer { Id = 283, ChronicleId = 322, Archetype = null, Name = "Chain Shot Cannon", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 283, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Chain_Shot_Cannon.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 283) });
            scores.Add(new CardScore { Id = 827 , Archetype = Archetype.TheRaptor, Score = 10, Card = cards.Single(c => c.Id == 283) });
            scores.Add(new CardScore { Id = 828 , Archetype = Archetype.Linza    , Score = 10, Card = cards.Single(c => c.Id == 283) });
            scores.Add(new CardScore { Id = 829 , Archetype = Archetype.Ariane   , Score = 10, Card = cards.Single(c => c.Id == 283) });
            scores.Add(new CardScore { Id = 830 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 283) });
            scores.Add(new CardScore { Id = 831 , Archetype = Archetype.Ozan     , Score = 10, Card = cards.Single(c => c.Id == 283) });
            scores.Add(new CardScore { Id = 1208, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 283) });

            containers.Add(new CardContainer { Id = 284, ChronicleId = 323, Archetype = null, Name = "Lady Zay", Rarity = Rarity.Diamond, Type = CardType.Support });
            cards.Add(new Card { Id = 284, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Lady_Zay.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 284) });
            scores.Add(new CardScore { Id = 832 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 284) });
            scores.Add(new CardScore { Id = 833 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 284) });
            scores.Add(new CardScore { Id = 834 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 284) });
            scores.Add(new CardScore { Id = 835 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 284) });
            scores.Add(new CardScore { Id = 836 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 284) });
            scores.Add(new CardScore { Id = 1209, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 284) });

            containers.Add(new CardContainer { Id = 285, ChronicleId = 324, Archetype = null, Name = "Meg", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 285, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Meg.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 285) });
            scores.Add(new CardScore { Id = 837 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 285) });
            scores.Add(new CardScore { Id = 838 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 285) });
            scores.Add(new CardScore { Id = 839 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 285) });
            scores.Add(new CardScore { Id = 840 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 285) });
            scores.Add(new CardScore { Id = 841 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 285) });
            scores.Add(new CardScore { Id = 1210, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 285) });

            containers.Add(new CardContainer { Id = 286, ChronicleId = 325, Archetype = null, Name = "Pirates' Hideout", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 286, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Pirates_Hideout.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 286) });
            scores.Add(new CardScore { Id = 842 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 286) });
            scores.Add(new CardScore { Id = 843 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 286) });
            scores.Add(new CardScore { Id = 844 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 286) });
            scores.Add(new CardScore { Id = 845 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 286) });
            scores.Add(new CardScore { Id = 846 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 286) });
            scores.Add(new CardScore { Id = 1211, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 286) });

            containers.Add(new CardContainer { Id = 287, ChronicleId = 326, Archetype = null, Name = "Rowdy Cannoneer", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 287, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Rowdy_Cannoneer.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 287) });
            scores.Add(new CardScore { Id = 847 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 287) });
            scores.Add(new CardScore { Id = 848 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 287) });
            scores.Add(new CardScore { Id = 849 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 287) });
            scores.Add(new CardScore { Id = 850 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 287) });
            scores.Add(new CardScore { Id = 851 , Archetype = Archetype.Ozan     , Score = 70, Card = cards.Single(c => c.Id == 287) });
            scores.Add(new CardScore { Id = 1212, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 287) });

            containers.Add(new CardContainer { Id = 288, ChronicleId = 327, Archetype = null, Name = "Saucy Wench Deckhand", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 288, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Saucy_Wench_Deckhand.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 288) });
            scores.Add(new CardScore { Id = 852 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 288) });
            scores.Add(new CardScore { Id = 853 , Archetype = Archetype.Linza    , Score = 50, Card = cards.Single(c => c.Id == 288) });
            scores.Add(new CardScore { Id = 854 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 288) });
            scores.Add(new CardScore { Id = 855 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 288) });
            scores.Add(new CardScore { Id = 856 , Archetype = Archetype.Ozan     , Score = 50, Card = cards.Single(c => c.Id == 288) });
            scores.Add(new CardScore { Id = 1213, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 288) });

            containers.Add(new CardContainer { Id = 289, ChronicleId = 328, Archetype = null, Name = "The Adventurous", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 289, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/The_Adventurous.png", Version = "X", Cost = 4, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 289) });
            scores.Add(new CardScore { Id = 857 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 289) });
            scores.Add(new CardScore { Id = 858 , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 289) });
            scores.Add(new CardScore { Id = 859 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 289) });
            scores.Add(new CardScore { Id = 860 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 289) });
            scores.Add(new CardScore { Id = 861 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 289) });
            scores.Add(new CardScore { Id = 1214, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 289) });

            containers.Add(new CardContainer { Id = 290, ChronicleId = 329, Archetype = null, Name = "Sticky Sanders", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 290, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Sticky_Sanders.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 290) });
            scores.Add(new CardScore { Id = 862 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 290) });
            scores.Add(new CardScore { Id = 863 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 290) });
            scores.Add(new CardScore { Id = 864 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 290) });
            scores.Add(new CardScore { Id = 865 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 290) });
            scores.Add(new CardScore { Id = 866 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 290) });
            scores.Add(new CardScore { Id = 1215, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 290) });

            containers.Add(new CardContainer { Id = 291, ChronicleId = 330, Archetype = Archetype.Vanescula, Name = "Flying Leech", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 291, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Flying_Leech.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 291) });
            scores.Add(new CardScore { Id = 867 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 291) });

            containers.Add(new CardContainer { Id = 292, ChronicleId = 331, Archetype = Archetype.Vanescula, Name = "Treus Dayth", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 292, Rewards = new CardRewards { Attack = 0, Armour = 3, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Treus_Dayth.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 292) });
            scores.Add(new CardScore { Id = 868 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 292) });

            containers.Add(new CardContainer { Id = 293, ChronicleId = 332, Archetype = Archetype.Vanescula, Name = "Blood Share", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 293, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Blood_Share.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 293) });
            scores.Add(new CardScore { Id = 869 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 293) });

            containers.Add(new CardContainer { Id = 294, ChronicleId = 333, Archetype = Archetype.Vanescula, Name = "Crypt", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 294, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Crypt.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 294) });
            scores.Add(new CardScore { Id = 870 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 294) });

            containers.Add(new CardContainer { Id = 295, ChronicleId = 334, Archetype = Archetype.Vanescula, Name = "Fiyr Shade", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 295, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Fiyr_Shade.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 295) });
            scores.Add(new CardScore { Id = 871 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 295) });

            containers.Add(new CardContainer { Id = 296, ChronicleId = 335, Archetype = Archetype.Vanescula, Name = "Gadderanks", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 296, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 5, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Gadderanks.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 296) });
            scores.Add(new CardScore { Id = 872 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 296) });

            containers.Add(new CardContainer { Id = 297, ChronicleId = 336, Archetype = Archetype.Vanescula, Name = "Haemalchemist", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 297, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Haemalchemist.png", Version = "X", Cost = 10, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 297) });
            scores.Add(new CardScore { Id = 873 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 297) });

            containers.Add(new CardContainer { Id = 298, ChronicleId = 337, Archetype = Archetype.Vanescula, Name = "Haunted Leech", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 298, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Haunted_Leech.png", Version = "X", Cost = 0, Health = 7, Active = true, Parent = containers.Single(p => p.Id == 298) });
            scores.Add(new CardScore { Id = 874 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 298) });

            containers.Add(new CardContainer { Id = 299, ChronicleId = 338, Archetype = Archetype.Vanescula, Name = "Hunger", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 299, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Hunger.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 299) });
            scores.Add(new CardScore { Id = 875 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 299) });

            containers.Add(new CardContainer { Id = 300, ChronicleId = 339, Archetype = Archetype.Vanescula, Name = "Malak", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 300, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Malak.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 300) });
            scores.Add(new CardScore { Id = 876 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 300) });

            containers.Add(new CardContainer { Id = 301, ChronicleId = 340, Archetype = Archetype.Vanescula, Name = "Meiyerditch Prisoner", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 301, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 3, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Meiyerditch_Prisoner.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 301) });
            scores.Add(new CardScore { Id = 877 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 301) });

            containers.Add(new CardContainer { Id = 302, ChronicleId = 341, Archetype = Archetype.Vanescula, Name = "Ranis Drakan", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 302, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Ranis_Drakan.png", Version = "X", Cost = 0, Health = 14, Active = false, Parent = containers.Single(p => p.Id == 302) });
            scores.Add(new CardScore { Id = 878 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 302) });

            containers.Add(new CardContainer { Id = 303, ChronicleId = 343, Archetype = Archetype.Vanescula, Name = "Dreadnaut", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 303, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Dreadnaut.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 303) });
            scores.Add(new CardScore { Id = 879 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 303) });

            containers.Add(new CardContainer { Id = 304, ChronicleId = 344, Archetype = Archetype.Vanescula, Name = "Vampyre Power", Rarity = Rarity.Diamond, Type = CardType.Support });
            cards.Add(new Card { Id = 304, Rewards = new CardRewards { Attack = 3, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Vampyre_Power.png", Version = "X", Cost = 13, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 304) });
            scores.Add(new CardScore { Id = 880 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 304) });

            containers.Add(new CardContainer { Id = 305, ChronicleId = 345, Archetype = Archetype.Vanescula, Name = "Vampyre Trader", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 305, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Vampyre_Trader.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 305) });
            scores.Add(new CardScore { Id = 881 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 305) });

            containers.Add(new CardContainer { Id = 306, ChronicleId = 346, Archetype = Archetype.Vanescula, Name = "Vyrewatch", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 306, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Vyrewatch.png", Version = "X", Cost = 5, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 306) });
            scores.Add(new CardScore { Id = 882 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 306) });

            containers.Add(new CardContainer { Id = 307, ChronicleId = 347, Archetype = Archetype.Vanescula, Name = "Werewolf Rebel", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 307, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Werewolf_Rebel.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 307) });
            scores.Add(new CardScore { Id = 883 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 307) });

            containers.Add(new CardContainer { Id = 308, ChronicleId = 348, Archetype = Archetype.Vanescula, Name = "Worthy Opponent", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 308, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Worthy_Opponent.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 308) });
            scores.Add(new CardScore { Id = 884 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 308) });

            containers.Add(new CardContainer { Id = 309, ChronicleId = 349, Archetype = Archetype.Vanescula, Name = "Wyrd", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 309, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Wyrd.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 309) });
            scores.Add(new CardScore { Id = 885 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 309) });

            containers.Add(new CardContainer { Id = 310, ChronicleId = 350, Archetype = Archetype.Vanescula, Name = "Sap Life Force", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 310, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Sap_Life_Force.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 310) });
            scores.Add(new CardScore { Id = 886 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 310) });

            containers.Add(new CardContainer { Id = 311, ChronicleId = 351, Archetype = Archetype.Vanescula, Name = "Rush of Strength", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 311, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Rush_of_Strength.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 311) });
            scores.Add(new CardScore { Id = 887 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 311) });

            containers.Add(new CardContainer { Id = 312, ChronicleId = 352, Archetype = Archetype.Vanescula, Name = "Safalaan Hallow", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 312, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Safalaan_Hallow.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 312) });
            scores.Add(new CardScore { Id = 888 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 312) });

            containers.Add(new CardContainer { Id = 313, ChronicleId = 353, Archetype = Archetype.Vanescula, Name = "Mass Drain", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 313, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Mass_Drain.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 313) });
            scores.Add(new CardScore { Id = 889 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 313) });

            containers.Add(new CardContainer { Id = 314, ChronicleId = 354, Archetype = Archetype.Vanescula, Name = "Alpha Werewolf", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 314, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Alpha_Werewolf.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 314) });
            scores.Add(new CardScore { Id = 890 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 314) });

            containers.Add(new CardContainer { Id = 315, ChronicleId = 355, Archetype = Archetype.Vanescula, Name = "Gorge", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 315, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Gorge.png", Version = "X", Cost = 4, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 315) });
            scores.Add(new CardScore { Id = 891 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 315) });

            containers.Add(new CardContainer { Id = 316, ChronicleId = 356, Archetype = Archetype.Vanescula, Name = "Gravecreeper", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 316, Rewards = new CardRewards { Attack = 0, Armour = 4, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Gravecreeper.png", Version = "X", Cost = 0, Health = 13, Active = true, Parent = containers.Single(p => p.Id == 316) });
            scores.Add(new CardScore { Id = 892 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 316) });

            containers.Add(new CardContainer { Id = 317, ChronicleId = 357, Archetype = Archetype.Vanescula, Name = "Shadow Stalk", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 317, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Shadow_Stalk.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 317) });
            scores.Add(new CardScore { Id = 893 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 317) });

            containers.Add(new CardContainer { Id = 318, ChronicleId = 358, Archetype = Archetype.Vanescula, Name = "Terror Dog", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 318, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Terror_Dog.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 318) });
            scores.Add(new CardScore { Id = 894 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 318) });

            containers.Add(new CardContainer { Id = 319, ChronicleId = 359, Archetype = Archetype.Ozan, Name = "Dragon Set", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 319, Rewards = new CardRewards { Attack = 0, Armour = 12, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Dragon_Set.png", Version = "X", Cost = 13, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 319) });
            scores.Add(new CardScore { Id = 895 , Archetype = Archetype.Ozan     , Score = 100, Card = cards.Single(c => c.Id == 319) });

            containers.Add(new CardContainer { Id = 320, ChronicleId = 361, Archetype = Archetype.Ozan, Name = "Lady Raven", Rarity = Rarity.Diamond, Type = CardType.Support });
            cards.Add(new Card { Id = 320, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Lady_Raven.png", Version = "X", Cost = 20, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 320) });
            scores.Add(new CardScore { Id = 896 , Archetype = Archetype.Ozan     , Score = 20, Card = cards.Single(c => c.Id == 320) });

            containers.Add(new CardContainer { Id = 321, ChronicleId = 362, Archetype = Archetype.Ariane, Name = "Ravenous Snail", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 321, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 2, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ravenous_Snail.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 321) });
            scores.Add(new CardScore { Id = 897 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 321) });

            containers.Add(new CardContainer { Id = 322, ChronicleId = 363, Archetype = Archetype.Ariane, Name = "Shield Dome", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 322, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 2, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Shield_Dome.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 322) });
            scores.Add(new CardScore { Id = 898 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 322) });

            containers.Add(new CardContainer { Id = 323, ChronicleId = 364, Archetype = Archetype.Ariane, Name = "Wise Old Man", Rarity = Rarity.Diamond, Type = CardType.Support });
            cards.Add(new Card { Id = 323, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Wise_Old_Man.png", Version = "X", Cost = 5, Health = 0, Active = false, Parent = containers.Single(p => p.Id == 323) });
            scores.Add(new CardScore { Id = 899 , Archetype = Archetype.Ariane   , Score = 10, Card = cards.Single(c => c.Id == 323) });

            containers.Add(new CardContainer { Id = 324, ChronicleId = 365, Archetype = Archetype.Ariane, Name = "Entangle", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 324, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Entangle.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 324) });
            scores.Add(new CardScore { Id = 900 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 324) });

            containers.Add(new CardContainer { Id = 325, ChronicleId = 366, Archetype = null, Name = "Dragon Warhammer", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 325, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Dragon_Warhammer.png", Version = "X", Cost = 5, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 325) });
            scores.Add(new CardScore { Id = 901 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 325) });
            scores.Add(new CardScore { Id = 902 , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 325) });
            scores.Add(new CardScore { Id = 903 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 325) });
            scores.Add(new CardScore { Id = 904 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 325) });
            scores.Add(new CardScore { Id = 905 , Archetype = Archetype.Ozan     , Score = 20, Card = cards.Single(c => c.Id == 325) });
            scores.Add(new CardScore { Id = 1216, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 325) });

            containers.Add(new CardContainer { Id = 326, ChronicleId = 367, Archetype = null, Name = "Lava Dragon", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 326, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 0, Coins = 5, Weapon = false }, Image = "/Content/img/cards/Lava_Dragon.png", Version = "X", Cost = 0, Health = 9, Active = true, Parent = containers.Single(p => p.Id == 326) });
            scores.Add(new CardScore { Id = 906 , Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 326) });
            scores.Add(new CardScore { Id = 907 , Archetype = Archetype.Linza    , Score = 40, Card = cards.Single(c => c.Id == 326) });
            scores.Add(new CardScore { Id = 908 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 326) });
            scores.Add(new CardScore { Id = 909 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 326) });
            scores.Add(new CardScore { Id = 910 , Archetype = Archetype.Ozan     , Score = 30, Card = cards.Single(c => c.Id == 326) });
            scores.Add(new CardScore { Id = 1217, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 326) });

            containers.Add(new CardContainer { Id = 327, ChronicleId = 368, Archetype = null, Name = "Dark Crab", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 327, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 6, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Dark_Crab.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 327) });
            scores.Add(new CardScore { Id = 911 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 327) });
            scores.Add(new CardScore { Id = 912 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 327) });
            scores.Add(new CardScore { Id = 913 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 327) });
            scores.Add(new CardScore { Id = 914 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 327) });
            scores.Add(new CardScore { Id = 915 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 327) });
            scores.Add(new CardScore { Id = 1218, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 327) });

            containers.Add(new CardContainer { Id = 328, ChronicleId = 369, Archetype = null, Name = "Stamina Potion", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 328, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 7, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Stamina_Potion.png", Version = "X", Cost = 6, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 328) });
            scores.Add(new CardScore { Id = 916 , Archetype = Archetype.TheRaptor, Score = 90, Card = cards.Single(c => c.Id == 328) });
            scores.Add(new CardScore { Id = 917 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 328) });
            scores.Add(new CardScore { Id = 918 , Archetype = Archetype.Ariane   , Score = 80, Card = cards.Single(c => c.Id == 328) });
            scores.Add(new CardScore { Id = 919 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 328) });
            scores.Add(new CardScore { Id = 920 , Archetype = Archetype.Ozan     , Score = 90, Card = cards.Single(c => c.Id == 328) });
            scores.Add(new CardScore { Id = 1219, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 328) });

            containers.Add(new CardContainer { Id = 329, ChronicleId = 370, Archetype = null, Name = "Zulrah", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 329, Rewards = new CardRewards { Attack = 0, Armour = 4, Health = 0, Coins = 4, Weapon = false }, Image = "/Content/img/cards/Zulrah.png", Version = "X", Cost = 0, Health = 11, Active = false, Parent = containers.Single(p => p.Id == 329) });
            scores.Add(new CardScore { Id = 921 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 329) });
            scores.Add(new CardScore { Id = 922 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 329) });
            scores.Add(new CardScore { Id = 923 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 329) });
            scores.Add(new CardScore { Id = 924 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 329) });
            scores.Add(new CardScore { Id = 925 , Archetype = Archetype.Ozan     , Score = 30, Card = cards.Single(c => c.Id == 329) });
            scores.Add(new CardScore { Id = 1220, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 329) });

            containers.Add(new CardContainer { Id = 330, ChronicleId = 372, Archetype = null, Name = "Undead Cow", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 330, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Undead_Cow.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 330) });
            scores.Add(new CardScore { Id = 926 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 330) });
            scores.Add(new CardScore { Id = 927 , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 330) });
            scores.Add(new CardScore { Id = 928 , Archetype = Archetype.Ariane   , Score = 40, Card = cards.Single(c => c.Id == 330) });
            scores.Add(new CardScore { Id = 929 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 330) });
            scores.Add(new CardScore { Id = 930 , Archetype = Archetype.Ozan     , Score = 40, Card = cards.Single(c => c.Id == 330) });
            scores.Add(new CardScore { Id = 1221, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 330) });

            containers.Add(new CardContainer { Id = 331, ChronicleId = 373, Archetype = null, Name = "Red Chinchompa", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 331, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Red_Chinchompa.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 331) });
            scores.Add(new CardScore { Id = 931 , Archetype = Archetype.TheRaptor, Score = 50, Card = cards.Single(c => c.Id == 331) });
            scores.Add(new CardScore { Id = 932 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 331) });
            scores.Add(new CardScore { Id = 933 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 331) });
            scores.Add(new CardScore { Id = 934 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 331) });
            scores.Add(new CardScore { Id = 935 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 331) });
            scores.Add(new CardScore { Id = 1222, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 331) });

            containers.Add(new CardContainer { Id = 332, ChronicleId = 374, Archetype = null, Name = "Toxic Blowpipe", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 332, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 3, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Toxic_Blowpipe.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 332) });
            scores.Add(new CardScore { Id = 936 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 332) });
            scores.Add(new CardScore { Id = 937 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 332) });
            scores.Add(new CardScore { Id = 938 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 332) });
            scores.Add(new CardScore { Id = 939 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 332) });
            scores.Add(new CardScore { Id = 940 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 332) });
            scores.Add(new CardScore { Id = 1223, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 332) });

            containers.Add(new CardContainer { Id = 333, ChronicleId = 375, Archetype = null, Name = "Cerberus", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 333, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 3, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Cerberus.png", Version = "X", Cost = 0, Health = 9, Active = true, Parent = containers.Single(p => p.Id == 333) });
            scores.Add(new CardScore { Id = 941 , Archetype = Archetype.TheRaptor, Score = 20, Card = cards.Single(c => c.Id == 333) });
            scores.Add(new CardScore { Id = 942 , Archetype = Archetype.Linza    , Score = 10, Card = cards.Single(c => c.Id == 333) });
            scores.Add(new CardScore { Id = 943 , Archetype = Archetype.Ariane   , Score = 10, Card = cards.Single(c => c.Id == 333) });
            scores.Add(new CardScore { Id = 944 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 333) });
            scores.Add(new CardScore { Id = 945 , Archetype = Archetype.Ozan     , Score = 10, Card = cards.Single(c => c.Id == 333) });
            scores.Add(new CardScore { Id = 1224, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 333) });

            containers.Add(new CardContainer { Id = 334, ChronicleId = 376, Archetype = Archetype.Vanescula, Name = "Burgh de Rott Citizen", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 334, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Burgh_de_Rott_Citizen.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 334) });
            scores.Add(new CardScore { Id = 946 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 334) });

            containers.Add(new CardContainer { Id = 335, ChronicleId = 377, Archetype = Archetype.Vanescula, Name = "Feral Vampyre", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 335, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Feral_Vampyre.png", Version = "X", Cost = 0, Health = 8, Active = true, Parent = containers.Single(p => p.Id == 335) });
            scores.Add(new CardScore { Id = 947 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 335) });

            containers.Add(new CardContainer { Id = 336, ChronicleId = 378, Archetype = null, Name = "Sir Tiffy Cashien", Rarity = Rarity.Diamond, Type = CardType.Support });
            cards.Add(new Card { Id = 336, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Sir_Tiffy_Cashien.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 336) });
            scores.Add(new CardScore { Id = 948 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 336) });
            scores.Add(new CardScore { Id = 949 , Archetype = Archetype.Linza    , Score = 80, Card = cards.Single(c => c.Id == 336) });
            scores.Add(new CardScore { Id = 950 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 336) });
            scores.Add(new CardScore { Id = 951 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 336) });
            scores.Add(new CardScore { Id = 952 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 336) });
            scores.Add(new CardScore { Id = 1225, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 336) });

            containers.Add(new CardContainer { Id = 337, ChronicleId = 379, Archetype = null, Name = "Granite Maul", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 337, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Granite_Maul.png", Version = "X", Cost = 5, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 337) });
            scores.Add(new CardScore { Id = 953 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 337) });
            scores.Add(new CardScore { Id = 954 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 337) });
            scores.Add(new CardScore { Id = 955 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 337) });
            scores.Add(new CardScore { Id = 956 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 337) });
            scores.Add(new CardScore { Id = 957 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 337) });
            scores.Add(new CardScore { Id = 1226, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 337) });

            containers.Add(new CardContainer { Id = 338, ChronicleId = 380, Archetype = null, Name = "General Wartface", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 338, Rewards = new CardRewards { Attack = 0, Armour = 3, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/General_Wartface.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 338) });
            scores.Add(new CardScore { Id = 958 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 338) });
            scores.Add(new CardScore { Id = 959 , Archetype = Archetype.Linza    , Score = 30, Card = cards.Single(c => c.Id == 338) });
            scores.Add(new CardScore { Id = 960 , Archetype = Archetype.Ariane   , Score = 30, Card = cards.Single(c => c.Id == 338) });
            scores.Add(new CardScore { Id = 961 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 338) });
            scores.Add(new CardScore { Id = 962 , Archetype = Archetype.Ozan     , Score = 30, Card = cards.Single(c => c.Id == 338) });
            scores.Add(new CardScore { Id = 1227, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 338) });

            containers.Add(new CardContainer { Id = 339, ChronicleId = 381, Archetype = null, Name = "Dragon Scimitar", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 339, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Dragon_Scimitar.png", Version = "X", Cost = 6, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 339) });
            scores.Add(new CardScore { Id = 963 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 339) });
            scores.Add(new CardScore { Id = 964 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 339) });
            scores.Add(new CardScore { Id = 965 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 339) });
            scores.Add(new CardScore { Id = 966 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 339) });
            scores.Add(new CardScore { Id = 967 , Archetype = Archetype.Ozan     , Score = 90, Card = cards.Single(c => c.Id == 339) });
            scores.Add(new CardScore { Id = 1228, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 339) });

            containers.Add(new CardContainer { Id = 340, ChronicleId = 382, Archetype = null, Name = "Lobster", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 340, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 4, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Lobster.png", Version = "X", Cost = 0, Health = 1, Active = true, Parent = containers.Single(p => p.Id == 340) });
            scores.Add(new CardScore { Id = 968 , Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 340) });
            scores.Add(new CardScore { Id = 969 , Archetype = Archetype.Linza    , Score = 60, Card = cards.Single(c => c.Id == 340) });
            scores.Add(new CardScore { Id = 970 , Archetype = Archetype.Ariane   , Score = 60, Card = cards.Single(c => c.Id == 340) });
            scores.Add(new CardScore { Id = 971 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 340) });
            scores.Add(new CardScore { Id = 972 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 340) });
            scores.Add(new CardScore { Id = 1229, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 340) });

            containers.Add(new CardContainer { Id = 341, ChronicleId = 383, Archetype = null, Name = "Rantz", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 341, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Rantz.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 341) });
            scores.Add(new CardScore { Id = 973 , Archetype = Archetype.TheRaptor, Score = 60, Card = cards.Single(c => c.Id == 341) });
            scores.Add(new CardScore { Id = 974 , Archetype = Archetype.Linza    , Score = 70, Card = cards.Single(c => c.Id == 341) });
            scores.Add(new CardScore { Id = 975 , Archetype = Archetype.Ariane   , Score = 50, Card = cards.Single(c => c.Id == 341) });
            scores.Add(new CardScore { Id = 976 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 341) });
            scores.Add(new CardScore { Id = 977 , Archetype = Archetype.Ozan     , Score = 60, Card = cards.Single(c => c.Id == 341) });
            scores.Add(new CardScore { Id = 1230, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 341) });

            containers.Add(new CardContainer { Id = 342, ChronicleId = 384, Archetype = null, Name = "Explosive Potion", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 342, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Explosive_Potion.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 342) });
            scores.Add(new CardScore { Id = 978 , Archetype = Archetype.TheRaptor, Score = 10, Card = cards.Single(c => c.Id == 342) });
            scores.Add(new CardScore { Id = 979 , Archetype = Archetype.Linza    , Score = 10, Card = cards.Single(c => c.Id == 342) });
            scores.Add(new CardScore { Id = 980 , Archetype = Archetype.Ariane   , Score = 10, Card = cards.Single(c => c.Id == 342) });
            scores.Add(new CardScore { Id = 981 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 342) });
            scores.Add(new CardScore { Id = 982 , Archetype = Archetype.Ozan     , Score = 10, Card = cards.Single(c => c.Id == 342) });
            scores.Add(new CardScore { Id = 1231, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 342) });

            containers.Add(new CardContainer { Id = 343, ChronicleId = 385, Archetype = null, Name = "Mithril Dragon", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 343, Rewards = new CardRewards { Attack = 0, Armour = 12, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Mithril_Dragon.png", Version = "X", Cost = 0, Health = 12, Active = true, Parent = containers.Single(p => p.Id == 343) });
            scores.Add(new CardScore { Id = 983 , Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 343) });
            scores.Add(new CardScore { Id = 984 , Archetype = Archetype.Linza    , Score = 20, Card = cards.Single(c => c.Id == 343) });
            scores.Add(new CardScore { Id = 985 , Archetype = Archetype.Ariane   , Score = 20, Card = cards.Single(c => c.Id == 343) });
            scores.Add(new CardScore { Id = 986 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 343) });
            scores.Add(new CardScore { Id = 987 , Archetype = Archetype.Ozan     , Score = 20, Card = cards.Single(c => c.Id == 343) });
            scores.Add(new CardScore { Id = 1232, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 343) });

            containers.Add(new CardContainer { Id = 344, ChronicleId = 386, Archetype = null, Name = "Abyssal Whip", Rarity = Rarity.Diamond, Type = CardType.Support });
            cards.Add(new Card { Id = 344, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Abyssal_Whip.png", Version = "X", Cost = 8, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 344) });
            scores.Add(new CardScore { Id = 988 , Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 344) });
            scores.Add(new CardScore { Id = 989 , Archetype = Archetype.Linza    , Score = 90, Card = cards.Single(c => c.Id == 344) });
            scores.Add(new CardScore { Id = 990 , Archetype = Archetype.Ariane   , Score = 70, Card = cards.Single(c => c.Id == 344) });
            scores.Add(new CardScore { Id = 991 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 344) });
            scores.Add(new CardScore { Id = 992 , Archetype = Archetype.Ozan     , Score = 80, Card = cards.Single(c => c.Id == 344) });
            scores.Add(new CardScore { Id = 1233, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 344) });

            containers.Add(new CardContainer { Id = 345, ChronicleId = 387, Archetype = Archetype.Vanescula, Name = "Jerrod", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 345, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Jerrod.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 345) });
            scores.Add(new CardScore { Id = 993 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 345) });

            containers.Add(new CardContainer { Id = 346, ChronicleId = 388, Archetype = Archetype.Vanescula, Name = "Afflicted", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 346, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 2, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Afflicted.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 346) });
            scores.Add(new CardScore { Id = 994 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 346) });

            containers.Add(new CardContainer { Id = 347, ChronicleId = 389, Archetype = Archetype.Vanescula, Name = "Bloodveld Leecher", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 347, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Bloodveld_Leecher.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 347) });
            scores.Add(new CardScore { Id = 995 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 347) });

            containers.Add(new CardContainer { Id = 348, ChronicleId = 390, Archetype = Archetype.Vanescula, Name = "Culling the Weak", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 348, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Culling_the_Weak.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 348) });
            scores.Add(new CardScore { Id = 996 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 348) });

            containers.Add(new CardContainer { Id = 349, ChronicleId = 391, Archetype = Archetype.Vanescula, Name = "Harold", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 349, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 2, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Harold.png", Version = "X", Cost = 0, Health = 7, Active = true, Parent = containers.Single(p => p.Id == 349) });
            scores.Add(new CardScore { Id = 997 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 349) });

            containers.Add(new CardContainer { Id = 350, ChronicleId = 392, Archetype = Archetype.Vanescula, Name = "Blood Tithe", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 350, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Blood_Tithe.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 350) });
            scores.Add(new CardScore { Id = 998 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 350) });

            containers.Add(new CardContainer { Id = 351, ChronicleId = 393, Archetype = Archetype.Vanescula, Name = "Ripper Demon", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 351, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ripper_Demon.png", Version = "X", Cost = 0, Health = 9, Active = true, Parent = containers.Single(p => p.Id == 351) });
            scores.Add(new CardScore { Id = 999 , Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 351) });

            containers.Add(new CardContainer { Id = 352, ChronicleId = 394, Archetype = Archetype.Vanescula, Name = "Necrovarus", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 352, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Necrovarus.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 352) });
            scores.Add(new CardScore { Id = 1000, Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 352) });

            containers.Add(new CardContainer { Id = 353, ChronicleId = 395, Archetype = Archetype.Morvran, Name = "Traitorous Imp", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 353, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Traitorous_Imp.png", Version = "X", Cost = 0, Health = 1, Active = true, Parent = containers.Single(p => p.Id == 353) });
            scores.Add(new CardScore { Id = 1001, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 353) });

            containers.Add(new CardContainer { Id = 354, ChronicleId = 396, Archetype = Archetype.Morvran, Name = "Strength in Numbers", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 354, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Strength_in_Numbers.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 354) });
            scores.Add(new CardScore { Id = 1002, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 354) });

            containers.Add(new CardContainer { Id = 355, ChronicleId = 397, Archetype = Archetype.Morvran, Name = "Dungeon Spider", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 355, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = true }, Image = "/Content/img/cards/Dungeon_Spider.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 355) });
            scores.Add(new CardScore { Id = 1003, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 355) });

            containers.Add(new CardContainer { Id = 356, ChronicleId = 398, Archetype = Archetype.Morvran, Name = "Guard Dog", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 356, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Guard_Dog.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 356) });
            scores.Add(new CardScore { Id = 1004, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 356) });

            containers.Add(new CardContainer { Id = 357, ChronicleId = 399, Archetype = Archetype.Morvran, Name = "Beastmaster", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 357, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Beastmaster.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 357) });
            scores.Add(new CardScore { Id = 1005, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 357) });

            containers.Add(new CardContainer { Id = 358, ChronicleId = 400, Archetype = Archetype.Morvran, Name = "Hollowtoof", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 358, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Hollowtoof.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 358) });
            scores.Add(new CardScore { Id = 1006, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 358) });

            containers.Add(new CardContainer { Id = 359, ChronicleId = 401, Archetype = Archetype.Morvran, Name = "Level Up", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 359, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Level_Up.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 359) });
            scores.Add(new CardScore { Id = 1007, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 359) });

            containers.Add(new CardContainer { Id = 360, ChronicleId = 402, Archetype = Archetype.Morvran, Name = "Preparing to Hunt", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 360, Rewards = new CardRewards { Attack = 0, Armour = 5, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Preparing_to_Hunt.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 360) });
            scores.Add(new CardScore { Id = 1008, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 360) });

            containers.Add(new CardContainer { Id = 361, ChronicleId = 403, Archetype = Archetype.Morvran, Name = "Dragon Two Hander", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 361, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/Dragon_Two_Hander.png", Version = "X", Cost = 5, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 361) });
            scores.Add(new CardScore { Id = 1009, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 361) });

            containers.Add(new CardContainer { Id = 362, ChronicleId = 404, Archetype = Archetype.Morvran, Name = "Kalphite Egg", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 362, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Kalphite_Egg.png", Version = "X", Cost = 0, Health = 8, Active = true, Parent = containers.Single(p => p.Id == 362) });
            scores.Add(new CardScore { Id = 1010, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 362) });

            containers.Add(new CardContainer { Id = 363, ChronicleId = 405, Archetype = Archetype.Morvran, Name = "Dung Kalphite", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 363, Rewards = new CardRewards { Attack = 0, Armour = 4, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Dung_Kalphite.png", Version = "X", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 363) });
            scores.Add(new CardScore { Id = 1011, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 363) });

            containers.Add(new CardContainer { Id = 364, ChronicleId = 406, Archetype = Archetype.Morvran, Name = "Tame", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 364, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Tame.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 364) });
            scores.Add(new CardScore { Id = 1012, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 364) });

            containers.Add(new CardContainer { Id = 365, ChronicleId = 407, Archetype = Archetype.Morvran, Name = "Mazchna", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 365, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Mazchna.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 365) });
            scores.Add(new CardScore { Id = 1013, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 365) });

            containers.Add(new CardContainer { Id = 366, ChronicleId = 408, Archetype = Archetype.Morvran, Name = "Mutated Jadinko", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 366, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Mutated_Jadinko.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 366) });
            scores.Add(new CardScore { Id = 1014, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 366) });

            containers.Add(new CardContainer { Id = 367, ChronicleId = 409, Archetype = Archetype.Morvran, Name = "Gorad", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 367, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Gorad.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 367) });
            scores.Add(new CardScore { Id = 1015, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 367) });

            containers.Add(new CardContainer { Id = 368, ChronicleId = 410, Archetype = Archetype.Morvran, Name = "Woven Carapace", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 368, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Woven_Carapace.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 368) });
            scores.Add(new CardScore { Id = 1016, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 368) });

            containers.Add(new CardContainer { Id = 369, ChronicleId = 411, Archetype = Archetype.Morvran, Name = "Bunny", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 369, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 1, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Bunny.png", Version = "X", Cost = 0, Health = 1, Active = true, Parent = containers.Single(p => p.Id == 369) });
            scores.Add(new CardScore { Id = 1017, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 369) });

            containers.Add(new CardContainer { Id = 370, ChronicleId = 412, Archetype = Archetype.Morvran, Name = "Dire Wolf", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 370, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Dire_Wolf.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 370) });
            scores.Add(new CardScore { Id = 1018, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 370) });

            containers.Add(new CardContainer { Id = 371, ChronicleId = 413, Archetype = Archetype.Morvran, Name = "Set Trap", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 371, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Set_Trap.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 371) });
            scores.Add(new CardScore { Id = 1019, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 371) });

            containers.Add(new CardContainer { Id = 372, ChronicleId = 414, Archetype = Archetype.Morvran, Name = "Iowerth Hellhound", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 372, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 4, Weapon = false }, Image = "/Content/img/cards/Iowerth_Hellhound.png", Version = "X", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 372) });
            scores.Add(new CardScore { Id = 1020, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 372) });

            containers.Add(new CardContainer { Id = 373, ChronicleId = 415, Archetype = Archetype.Morvran, Name = "Zogre Mauler", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 373, Rewards = new CardRewards { Attack = 0, Armour = 1, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/Zogre_Mauler.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 373) });
            scores.Add(new CardScore { Id = 1021, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 373) });

            containers.Add(new CardContainer { Id = 374, ChronicleId = 416, Archetype = Archetype.Morvran, Name = "Ogress Champion", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 374, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ogress_Champion.png", Version = "X", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 374) });
            scores.Add(new CardScore { Id = 1022, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 374) });

            containers.Add(new CardContainer { Id = 375, ChronicleId = 417, Archetype = Archetype.Morvran, Name = "Ambushed Hive", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 375, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ambushed_Hive.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 375) });
            scores.Add(new CardScore { Id = 1023, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 375) });

            containers.Add(new CardContainer { Id = 376, ChronicleId = 418, Archetype = Archetype.Morvran, Name = "Unicorn", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 376, Rewards = new CardRewards { Attack = 0, Armour = 6, Health = 6, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Unicorn.png", Version = "X", Cost = 0, Health = 7, Active = true, Parent = containers.Single(p => p.Id == 376) });
            scores.Add(new CardScore { Id = 1024, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 376) });

            containers.Add(new CardContainer { Id = 377, ChronicleId = 419, Archetype = Archetype.Morvran, Name = "Bouncer", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 377, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Bouncer.png", Version = "X", Cost = 0, Health = 3, Active = false, Parent = containers.Single(p => p.Id == 377) });
            scores.Add(new CardScore { Id = 1025, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 377) });

            containers.Add(new CardContainer { Id = 378, ChronicleId = 420, Archetype = Archetype.Morvran, Name = "Grunsh", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 378, Rewards = new CardRewards { Attack = 0, Armour = 2, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Grunsh.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 378) });
            scores.Add(new CardScore { Id = 1026, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 378) });

            containers.Add(new CardContainer { Id = 379, ChronicleId = 421, Archetype = Archetype.Morvran, Name = "Rush of Blood", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 379, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Rush_of_Blood.png", Version = "X", Cost = 3, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 379) });
            scores.Add(new CardScore { Id = 1027, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 379) });

            containers.Add(new CardContainer { Id = 380, ChronicleId = 422, Archetype = Archetype.Morvran, Name = "Charging Monsters", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 380, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Charging_Monsters.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 380) });
            scores.Add(new CardScore { Id = 1028, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 380) });

            containers.Add(new CardContainer { Id = 381, ChronicleId = 423, Archetype = Archetype.Morvran, Name = "Kalphite Acid", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 381, Rewards = new CardRewards { Attack = 0, Armour = 5, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Kalphite_Acid.png", Version = "X", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 381) });
            scores.Add(new CardScore { Id = 1029, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 381) });

            containers.Add(new CardContainer { Id = 382, ChronicleId = 424, Archetype = Archetype.Morvran, Name = "Anger of Delrith", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 382, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Anger_of_Delrith.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 382) });
            scores.Add(new CardScore { Id = 1030, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 382) });

            containers.Add(new CardContainer { Id = 383, ChronicleId = 425, Archetype = Archetype.Morvran, Name = "Abyssal Demon", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 383, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Abyssal_Demon.png", Version = "X", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 383) });
            scores.Add(new CardScore { Id = 1031, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 383) });

            containers.Add(new CardContainer { Id = 384, ChronicleId = 426, Archetype = Archetype.Morvran, Name = "Chaos Dwogre", Rarity = Rarity.Emerald, Type = CardType.Combat });
            cards.Add(new Card { Id = 384, Rewards = new CardRewards { Attack = 0, Armour = 4, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/Chaos_Dwogre.png", Version = "X", Cost = 0, Health = 9, Active = true, Parent = containers.Single(p => p.Id == 384) });
            scores.Add(new CardScore { Id = 1032, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 384) });

            containers.Add(new CardContainer { Id = 385, ChronicleId = 428, Archetype = Archetype.Morvran, Name = "Toughened Warrior", Rarity = Rarity.Emerald, Type = CardType.Support });
            cards.Add(new Card { Id = 385, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Toughened_Warrior.png", Version = "X", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 385) });
            scores.Add(new CardScore { Id = 1033, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 385) });

            containers.Add(new CardContainer { Id = 386, ChronicleId = 429, Archetype = Archetype.Morvran, Name = "Kalphite Marauder", Rarity = Rarity.Ruby, Type = CardType.Combat });
            cards.Add(new Card { Id = 386, Rewards = new CardRewards { Attack = 0, Armour = 3, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Kalphite_Marauder.png", Version = "X", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 386) });
            scores.Add(new CardScore { Id = 1034, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 386) });

            containers.Add(new CardContainer { Id = 387, ChronicleId = 430, Archetype = Archetype.Morvran, Name = "Dragon Egg", Rarity = Rarity.Ruby, Type = CardType.Support });
            cards.Add(new Card { Id = 387, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Dragon_Egg.png", Version = "X", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 387) });
            scores.Add(new CardScore { Id = 1035, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 387) });

            containers.Add(new CardContainer { Id = 388, ChronicleId = 431, Archetype = Archetype.Morvran, Name = "Kalphite Queen", Rarity = Rarity.Diamond, Type = CardType.Combat });
            cards.Add(new Card { Id = 388, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Kalphite_Queen.png", Version = "X", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 388) });
            scores.Add(new CardScore { Id = 1036, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 388) });

            containers.Add(new CardContainer { Id = 389, ChronicleId = 433, Archetype = Archetype.Morvran, Name = "Deadly Prey", Rarity = Rarity.Diamond, Type = CardType.Support });
            cards.Add(new Card { Id = 389, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Deadly_Prey.png", Version = "X", Cost = 0, Health = 0, Active = false, Parent = containers.Single(p => p.Id == 389) });
            scores.Add(new CardScore { Id = 1037, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 389) });
            
            cards.Add(new Card { Id = 390, Rewards = new CardRewards { Attack = 0, Armour = 3, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Kayle_v1482056.png", Version = "1482056", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 119) });
            scores.Add(new CardScore { Id = 1038, Archetype = Archetype.TheRaptor, Score = 90, Card = cards.Single(c => c.Id == 390) });
            scores.Add(new CardScore { Id = 1039, Archetype = Archetype.Linza    , Score = 90, Card = cards.Single(c => c.Id == 390) });
            scores.Add(new CardScore { Id = 1040, Archetype = Archetype.Ariane   , Score = 90, Card = cards.Single(c => c.Id == 390) });
            scores.Add(new CardScore { Id = 1041, Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 390) });
            scores.Add(new CardScore { Id = 1042, Archetype = Archetype.Ozan     , Score = 90, Card = cards.Single(c => c.Id == 390) });
            scores.Add(new CardScore { Id = 1234, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 390) });

            cards.Add(new Card { Id = 391, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Haunted_Soul_v1482056.png", Version = "1482056", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 162) });
            scores.Add(new CardScore { Id = 1043, Archetype = Archetype.Ariane, Score = 100, Card = cards.Single(c => c.Id == 391) });

            cards.Add(new Card { Id = 392, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Earth_Blast_v1482056.png", Version = "1482056", Cost = 6, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 165) });
            scores.Add(new CardScore { Id = 1044, Archetype = Archetype.Ariane, Score = 100, Card = cards.Single(c => c.Id == 392) });

            cards.Add(new Card { Id = 393, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Redbeard_Frank_v1482056.png", Version = "1482056", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 177) });
            scores.Add(new CardScore { Id = 1045, Archetype = Archetype.TheRaptor, Score = 70, Card = cards.Single(c => c.Id == 393) });
            scores.Add(new CardScore { Id = 1046, Archetype = Archetype.Linza, Score = 60, Card = cards.Single(c => c.Id == 393) });
            scores.Add(new CardScore { Id = 1047, Archetype = Archetype.Ariane, Score = 60, Card = cards.Single(c => c.Id == 393) });
            scores.Add(new CardScore { Id = 1048, Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 393) });
            scores.Add(new CardScore { Id = 1049, Archetype = Archetype.Ozan, Score = 40, Card = cards.Single(c => c.Id == 393) });
            scores.Add(new CardScore { Id = 1235, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 393) });

            cards.Add(new Card { Id = 394, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/To_Kash_v1482056.png", Version = "1482056", Cost = 0, Health = 12, Active = true, Parent = containers.Single(p => p.Id == 179) });
            scores.Add(new CardScore { Id = 1050, Archetype = Archetype.TheRaptor, Score = 40, Card = cards.Single(c => c.Id == 394) });
            scores.Add(new CardScore { Id = 1051, Archetype = Archetype.Linza, Score = 40, Card = cards.Single(c => c.Id == 394) });
            scores.Add(new CardScore { Id = 1052, Archetype = Archetype.Ariane, Score = 40, Card = cards.Single(c => c.Id == 394) });
            scores.Add(new CardScore { Id = 1053, Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 394) });
            scores.Add(new CardScore { Id = 1054, Archetype = Archetype.Ozan, Score = 50, Card = cards.Single(c => c.Id == 394) });
            scores.Add(new CardScore { Id = 1236, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 394) });

            cards.Add(new Card { Id = 395, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Enfeeble_v1482056.png", Version = "1482056", Cost = 1, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 193) });
            scores.Add(new CardScore { Id = 1055, Archetype = Archetype.Ariane, Score = 90, Card = cards.Single(c => c.Id == 395) });

            cards.Add(new Card { Id = 396, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Lady_Hefin_v1482056.png", Version = "1482056", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 195) });
            scores.Add(new CardScore { Id = 1056, Archetype = Archetype.Ariane, Score = 80, Card = cards.Single(c => c.Id == 396) });

            cards.Add(new Card { Id = 397, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Stagger_v1482056.png", Version = "1482056", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 197) });
            scores.Add(new CardScore { Id = 1057, Archetype = Archetype.Ariane, Score = 100, Card = cards.Single(c => c.Id == 397) });

            cards.Add(new Card { Id = 398, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Skeletal_Peon_v1482056.png", Version = "1482056", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 240) });
            scores.Add(new CardScore { Id = 1058, Archetype = Archetype.Ariane, Score = 70, Card = cards.Single(c => c.Id == 398) });

            cards.Add(new Card { Id = 399, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Char_v1482056.png", Version = "1482056", Cost = 0, Health = 10, Active = true, Parent = containers.Single(p => p.Id == 261) });
            scores.Add(new CardScore { Id = 1059, Archetype = Archetype.Linza, Score = 30, Card = cards.Single(c => c.Id == 399) });

            cards.Add(new Card { Id = 400, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Papa_Mambo_v1482056.png", Version = "1482056", Cost = 2, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 276) });
            scores.Add(new CardScore { Id = 1060, Archetype = Archetype.TheRaptor, Score = 10, Card = cards.Single(c => c.Id == 400) });
            scores.Add(new CardScore { Id = 1061, Archetype = Archetype.Linza, Score = 20, Card = cards.Single(c => c.Id == 400) });
            scores.Add(new CardScore { Id = 1062, Archetype = Archetype.Ariane, Score = 30, Card = cards.Single(c => c.Id == 400) });
            scores.Add(new CardScore { Id = 1063, Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 400) });
            scores.Add(new CardScore { Id = 1064, Archetype = Archetype.Ozan, Score = 20, Card = cards.Single(c => c.Id == 400) });
            scores.Add(new CardScore { Id = 1237, Archetype = Archetype.Morvran  , Score = -1, Card = cards.Single(c => c.Id == 400) });

            cards.Add(new Card { Id = 401, Rewards = new CardRewards { Attack = 1, Armour = 12, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Ranis_Drakan_v1482056.png", Version = "1482056", Cost = 0, Health = 9, Active = true, Parent = containers.Single(p => p.Id == 302) });
            scores.Add(new CardScore { Id = 1065, Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 401) });

            cards.Add(new Card { Id = 402, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Wise_Old_Man_v1482056.png", Version = "1482056", Cost = 5, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 323) });
            scores.Add(new CardScore { Id = 1066, Archetype = Archetype.Ariane, Score = 10, Card = cards.Single(c => c.Id == 402) });

            cards.Add(new Card { Id = 403, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Zulrah_v1482056.png", Version = "1482056", Cost = 0, Health = 8, Active = true, Parent = containers.Single(p => p.Id == 329) });
            scores.Add(new CardScore { Id = 1067, Archetype = Archetype.TheRaptor, Score = 30, Card = cards.Single(c => c.Id == 403) });
            scores.Add(new CardScore { Id = 1068, Archetype = Archetype.Linza, Score = 70, Card = cards.Single(c => c.Id == 403) });
            scores.Add(new CardScore { Id = 1069, Archetype = Archetype.Ariane, Score = 30, Card = cards.Single(c => c.Id == 403) });
            scores.Add(new CardScore { Id = 1070, Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 403) });
            scores.Add(new CardScore { Id = 1071, Archetype = Archetype.Ozan, Score = 30, Card = cards.Single(c => c.Id == 403) });
            scores.Add(new CardScore { Id = 1238, Archetype = Archetype.Morvran, Score = -1, Card = cards.Single(c => c.Id == 403) });

            // Release v1.4.4 (build: 1498451)
            cards.Add(new Card { Id = 404, Rewards = new CardRewards { Attack = 0, Armour = 4, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/v1_4_4/Amascut_Mystic.png", Version = "1498451", Cost = 0, Health = 4, Active = true, Parent = containers.Single(p => p.Id == 226) });
            scores.Add(new CardScore { Id = 1239, Archetype = Archetype.Ozan, Score = -1, Card = cards.Single(c => c.Id == 404) });

            cards.Add(new Card { Id = 405, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/v1_4_4/Amascut_Templeguard.png", Version = "1498451", Cost = 0, Health = 5, Active = true, Parent = containers.Single(p => p.Id == 122) });
            scores.Add(new CardScore { Id = 1240, Archetype = Archetype.Ozan, Score = -1, Card = cards.Single(c => c.Id == 405) });

            containers.Add(new CardContainer { Id = 390, ChronicleId = 438, Archetype = null, Name = "Black Chinchompa", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 406, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/v1_4_4/Black_Chinchompa.png", Version = "1498451", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 390) });
            scores.Add(new CardScore { Id = 1241, Archetype = Archetype.TheRaptor, Score = -1, Card = cards.Single(c => c.Id == 406) });
            scores.Add(new CardScore { Id = 1242, Archetype = Archetype.Linza, Score = -1, Card = cards.Single(c => c.Id == 406) });
            scores.Add(new CardScore { Id = 1243, Archetype = Archetype.Ariane, Score = -1, Card = cards.Single(c => c.Id == 406) });
            scores.Add(new CardScore { Id = 1244, Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 406) });
            scores.Add(new CardScore { Id = 1245, Archetype = Archetype.Ozan, Score = -1, Card = cards.Single(c => c.Id == 406) });
            scores.Add(new CardScore { Id = 1246, Archetype = Archetype.Morvran, Score = -1, Card = cards.Single(c => c.Id == 406) });

            cards.Add(new Card { Id = 407, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/v1_4_4/Bouncer.png", Version = "1498451", Cost = 0, Health = 3, Active = true, Parent = containers.Single(p => p.Id == 377) });
            scores.Add(new CardScore { Id = 1247, Archetype = Archetype.Morvran, Score = -1, Card = cards.Single(c => c.Id == 407) });

            containers.Add(new CardContainer { Id = 391, ChronicleId = 435, Archetype = Archetype.Ariane, Name = "Clairvoyance", Rarity = Rarity.Saphire, Type = CardType.Support });
            cards.Add(new Card { Id = 407, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/v1_4_4/Clairvoyance.png", Version = "1498451", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 391) });
            scores.Add(new CardScore { Id = 1248, Archetype = Archetype.Ariane, Score = -1, Card = cards.Single(c => c.Id == 407) });

            cards.Add(new Card { Id = 408, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 4, Coins = 0, Weapon = false }, Image = "/Content/img/cards/v1_4_4/Culinaromancer.png", Version = "1498451", Cost = 0, Health = 6, Active = true, Parent = containers.Single(p => p.Id == 123) });
            scores.Add(new CardScore { Id = 1249, Archetype = Archetype.TheRaptor, Score = -1, Card = cards.Single(c => c.Id == 408) });
            scores.Add(new CardScore { Id = 1250, Archetype = Archetype.Linza, Score = -1, Card = cards.Single(c => c.Id == 408) });
            scores.Add(new CardScore { Id = 1251, Archetype = Archetype.Ariane, Score = -1, Card = cards.Single(c => c.Id == 408) });
            scores.Add(new CardScore { Id = 1252, Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 408) });
            scores.Add(new CardScore { Id = 1253, Archetype = Archetype.Ozan, Score = -1, Card = cards.Single(c => c.Id == 408) });
            scores.Add(new CardScore { Id = 1254, Archetype = Archetype.Morvran, Score = -1, Card = cards.Single(c => c.Id == 408) });

            cards.Add(new Card { Id = 409, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 1, Coins = 0, Weapon = false }, Image = "/Content/img/cards/v1_4_4/Dagannoth_Fledgling.png", Version = "1498451", Cost = 0, Health = 2, Active = false, Parent = containers.Single(p => p.Id == 128) });
            scores.Add(new CardScore { Id = 1255, Archetype = Archetype.TheRaptor, Score = -1, Card = cards.Single(c => c.Id == 409) });
            scores.Add(new CardScore { Id = 1256, Archetype = Archetype.Linza, Score = -1, Card = cards.Single(c => c.Id == 409) });
            scores.Add(new CardScore { Id = 1257, Archetype = Archetype.Ariane, Score = -1, Card = cards.Single(c => c.Id == 409) });
            scores.Add(new CardScore { Id = 1258, Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 409) });
            scores.Add(new CardScore { Id = 1259, Archetype = Archetype.Ozan, Score = -1, Card = cards.Single(c => c.Id == 409) });
            scores.Add(new CardScore { Id = 1260, Archetype = Archetype.Morvran, Score = -1, Card = cards.Single(c => c.Id == 409) });

            cards.Add(new Card { Id = 410, Rewards = new CardRewards { Attack = 1, Armour = 0, Health = 2, Coins = 0, Weapon = false }, Image = "/Content/img/cards/Dagannoth_Sentinel.png", Version = "1498451", Cost = 0, Health = 9, Active = true, Parent = containers.Single(p => p.Id == 159) });
            scores.Add(new CardScore { Id = 1261, Archetype = Archetype.TheRaptor, Score = 80, Card = cards.Single(c => c.Id == 410) });
            scores.Add(new CardScore { Id = 1262, Archetype = Archetype.Linza, Score = 60, Card = cards.Single(c => c.Id == 410) });
            scores.Add(new CardScore { Id = 1263, Archetype = Archetype.Ariane, Score = 60, Card = cards.Single(c => c.Id == 410) });
            scores.Add(new CardScore { Id = 1264, Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 410) });
            scores.Add(new CardScore { Id = 1265, Archetype = Archetype.Ozan, Score = 60, Card = cards.Single(c => c.Id == 410) });
            scores.Add(new CardScore { Id = 1266, Archetype = Archetype.Morvran, Score = -1, Card = cards.Single(c => c.Id == 410) });

            containers.Add(new CardContainer { Id = 392, ChronicleId = 439, Archetype = Archetype.Linza, Name = "Dark Fanatic", Rarity = Rarity.Saphire, Type = CardType.Combat });
            cards.Add(new Card { Id = 411, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 2, Weapon = false }, Image = "/Content/img/cards/v1_4_4/Dark_Fanatic.png", Version = "1498451", Cost = 0, Health = 2, Active = true, Parent = containers.Single(p => p.Id == 392) });
            scores.Add(new CardScore { Id = 1267, Archetype = Archetype.Linza, Score = -1, Card = cards.Single(c => c.Id == 411) });

            cards.Add(new Card { Id = 412, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = false }, Image = "/Content/img/cards/v1_4_4/Deadly_Prey.png", Version = "1498451", Cost = 0, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 389) });
            scores.Add(new CardScore { Id = 1268, Archetype = Archetype.Morvran, Score = -1, Card = cards.Single(c => c.Id == 412) });

            cards.Add(new Card { Id = 413, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 1, Weapon = false }, Image = "/Content/img/cards/v1_4_4/Dust_Devil.png", Version = "1498451", Cost = 0, Health = 7, Active = true, Parent = containers.Single(p => p.Id == 137) });
            scores.Add(new CardScore { Id = 1269, Archetype = Archetype.Linza, Score = -1, Card = cards.Single(c => c.Id == 137) });

            cards.Add(new Card { Id = 414, Rewards = new CardRewards { Attack = 0, Armour = 5, Health = 5, Coins = 0, Weapon = false }, Image = "/Content/img/cards/v1_4_4/Full_Tetsu.png", Version = "1498451", Cost = 5, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 33) });
            scores.Add(new CardScore { Id = 1270, Archetype = Archetype.TheRaptor, Score = -1, Card = cards.Single(c => c.Id == 414) });
            scores.Add(new CardScore { Id = 1271, Archetype = Archetype.Linza, Score = -1, Card = cards.Single(c => c.Id == 414) });
            scores.Add(new CardScore { Id = 1272, Archetype = Archetype.Ariane, Score = -1, Card = cards.Single(c => c.Id == 414) });
            scores.Add(new CardScore { Id = 1273, Archetype = Archetype.Vanescula, Score = -1, Card = cards.Single(c => c.Id == 414) });
            scores.Add(new CardScore { Id = 1274, Archetype = Archetype.Ozan, Score = -1, Card = cards.Single(c => c.Id == 414) });
            scores.Add(new CardScore { Id = 1275, Archetype = Archetype.Morvran, Score = -1, Card = cards.Single(c => c.Id == 414) });

            //GOblin Village
            /*
            cards.Add(new Card { Id = 412, Rewards = new CardRewards { Attack = 0, Armour = 0, Health = 0, Coins = 0, Weapon = true }, Image = "/Content/img/cards/v1_4_4/Tetsu_Katana.png", Version = "1498451", Cost = 7, Health = 0, Active = true, Parent = containers.Single(p => p.Id == 81) });
            scores.Add(new CardScore { Id = 277, Archetype = Archetype.Linza, Score = 100, Card = cards.Single(c => c.Id == 404) });
            */

        }

        public static void SeedData(ApplicationDbContext db)
        {
            if (!SHOULD_UPDATE)
            {
                return;
            }
            db.CardContainers.AddOrUpdate(c => c.Id, containers.ToArray());
            foreach(var card in cards)
            {
                card.Parent = db.CardContainers.Find(card.Parent.Id);
            }
            db.Cards.AddOrUpdate(c => c.Id, cards.ToArray());
            foreach (var cardScore in scores)
            {
                cardScore.Card = db.Cards.Find(cardScore.Card.Id);
            }
            db.CardScores.AddOrUpdate(c => c.Id, scores.ToArray());
        }
    }
}

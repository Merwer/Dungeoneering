using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Merwer.Chronicle.Dungeoneering.Tracker.Models;

namespace Merwer.Chronicle.Dungeoneering.Tracker.ViewModels.Draft
{
    public class DraftView
    {
        public Models.Draft Draft { get; internal set; }
        public bool IsSelf { get; internal set; }
    }
}
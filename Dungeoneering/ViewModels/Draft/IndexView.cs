using Merwer.Chronicle.Dungeoneering.Tracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Merwer.Chronicle.Dungeoneering.Tracker.ViewModels.Draft
{
    public class IndexView
    {
        public string Username { get; internal set; }
        public IEnumerable<Models.Draft> Drafts { get; internal set; }
        public bool IsSelf { get; internal set; }
        public bool ShowNewDraft { get; internal set; }
    }
}
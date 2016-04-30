using Merwer.Chronicle.Dungeoneering.Tracker.Migrations;
using Merwer.Chronicle.Dungeoneering.Tracker.Models;
using System.Data.Entity;

namespace Merwer.Chronicle.Dungeoneering.Tracker
{
    public partial class Startup
    {
        void UpdateDatabase()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
            new ApplicationDbContext().Database.Initialize(false);
        }
    }
}
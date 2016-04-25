namespace Dungeoneering.Migrations
{
    using Merwer.Chronicle.Dungeoneering.Tracker.Api.Models;
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Model;
    using System.Data.Entity.SqlServer;
    using System.Linq;
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SqlClient", new CustomSqlServerMigrationSqlGenerator());
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Drafts.AddOrUpdate(
                new Draft
                {
                    OwnerName = "wj.belanger@gmail.com",
                    Archetype = Archetype.TheRaptor,
                    Rounds = new List<Round>
                    {
                        new Round
                        {
                            OwnerName = "wj.belanger@gmail.com",
                            RoundId = 1,
                            Options = new List<int> { 1, 2, 3, 4, 5 },
                            Selected = new List<int> { 1, 2 }
                        },
                        new Round
                        {
                            OwnerName = "wj.belanger@gmail.com",
                            RoundId = 2,
                            Options = new List<int> { 1, 2, 3, 4, 5 },
                            Selected = new List<int> { 1, 2 }
                        },
                        new Round
                        {
                            OwnerName = "wj.belanger@gmail.com",
                            RoundId = 3,
                            Options = new List<int> { 1, 2, 3, 4, 5 },
                            Selected = new List<int> { 1, 2 }
                        },
                    }
                });
        }

        // https://andy.mehalick.com/2014/02/06/ef6-adding-a-created-datetime-column-automatically-with-code-first-migrations/
        internal class CustomSqlServerMigrationSqlGenerator : SqlServerMigrationSqlGenerator
        {
            protected override void Generate(AddColumnOperation addColumnOperation)
            {
                SetCreatedUtcColumn(addColumnOperation.Column);

                base.Generate(addColumnOperation);
            }

            protected override void Generate(CreateTableOperation createTableOperation)
            {
                SetCreatedUtcColumn(createTableOperation.Columns);

                base.Generate(createTableOperation);
            }

            private static void SetCreatedUtcColumn(IEnumerable<ColumnModel> columns)
            {
                foreach (var columnModel in columns)
                {
                    SetCreatedUtcColumn(columnModel);
                }
            }

            private static void SetCreatedUtcColumn(PropertyModel column)
            {
                if (column.Name == "CreatedOn")
                {
                    column.DefaultValueSql = "GETUTCDATE()";
                }
            }
        }
    }
}

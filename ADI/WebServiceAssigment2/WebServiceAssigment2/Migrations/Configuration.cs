namespace WebServiceAssigment2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebServiceAssigment2.Models.DataModels.FRDbContext>
    {
        public Configuration()
        {
            //cau hinh tu dong cap nhap database khi thay doi
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "WebServiceAssigment2.Models.DataModels.FRDbContext";
        }

        protected override void Seed(WebServiceAssigment2.Models.DataModels.FRDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

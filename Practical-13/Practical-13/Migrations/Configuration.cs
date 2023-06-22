using System;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Practical_13.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Practical_13.Models.EmployeeDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Practical_13.Models.EmployeeDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Garage2._0.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage2._0.DataAccessLayer.GarageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Garage2._0.DataAccessLayer.GarageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Garage.AddOrUpdate(
                g => new {g.Vehicle, g.RegNr, g.Colour, g.NbrOfWheels},
                new Garage { Vehicle = Vehicles.Car, RegNr = "ABC123", Colour = "Blue", NbrOfWheels = 4, Tid = DateTime.Now },
                new Garage { Vehicle = Vehicles.Airplane, RegNr = "DEF456",Colour = "White", NbrOfWheels = 6, Tid = DateTime.Now },
                new Garage { Vehicle = Vehicles.Boat, RegNr = "GHI789", Colour = "Black", NbrOfWheels = 0, Tid = DateTime.Now },
                new Garage { Vehicle = Vehicles.Motorcycle, RegNr = "JKL101", Colour = "Red", NbrOfWheels = 2, Tid = DateTime.Now }
                );
        }
    }
}

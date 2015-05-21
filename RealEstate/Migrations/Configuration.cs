using RealEstate.Models;

namespace RealEstate.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RealEstate.Models.RealEstateDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RealEstate.Models.RealEstateDbContext context)
        {
            context.Properties.AddOrUpdate(
                p => p.Name,
                new Property { Name = "Old Kent Road", BasePrice = 60 },
                new Property { Name = "Whitechapel Road", BasePrice = 60 },
                new Property { Name = "The Angel Islington", BasePrice = 100 },
                new Property { Name = "Euston Road", BasePrice = 100},
                new Property { Name = "Pentonville Road", BasePrice = 120 },
                new Property { Name = "Pall Mall", BasePrice = 140 },
                new Property { Name = "Whitehall", BasePrice = 140 },
                new Property { Name = "Northumberland Avenue", BasePrice = 160 },
                new Property { Name = "Bow Street", BasePrice = 180 },
                new Property { Name = "Marlborough Street", BasePrice = 180 },
                new Property { Name = "Vine Street", BasePrice = 200 },
                new Property { Name = "The Strand", BasePrice = 220 },
                new Property { Name = "Fleet Street", BasePrice = 220 },
                new Property { Name = "Trafalgar Square", BasePrice = 240 },
                new Property { Name = "Leicester Square", BasePrice = 260 },
                new Property { Name = "Coventry Street", BasePrice = 260 },
                new Property { Name = "Piccadilly", BasePrice = 280 },
                new Property { Name = "Regent Street", BasePrice = 300 },
                new Property { Name = "Oxford Street", BasePrice = 300 },
                new Property { Name = "Bond Street", BasePrice = 320 },
                new Property { Name = "Park Lane", BasePrice = 350 },
                new Property { Name = "Mayfair", BasePrice = 400 },
                new Property { Name = "King's Cross Station", BasePrice = 200 },
                new Property { Name = "Marylebone Station", BasePrice = 200 },
                new Property { Name = "Fenchurch St Station", BasePrice = 200 },
                new Property { Name = "Liverpool Street Station", BasePrice = 200 },
                new Property { Name = "Electric Company", BasePrice = 150 },
                new Property { Name = "Water Works", BasePrice = 150 }
            );
        }
    }
}

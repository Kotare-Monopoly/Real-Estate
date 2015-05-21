using RealEstate.Models;

namespace RealEstate.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<RealEstate.Models.RealEstateDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RealEstate.Models.RealEstateDbContext context)
        {
            context.Properties.AddOrUpdate(
                p => p.Hours,
                new Property { LocationId = 1, Hours = 60 },
                new Property { LocationId = 3, Hours = 60 },
                new Property { LocationId = 5, Hours = 200 },
                new Property { LocationId = 6, Hours = 100},
                new Property { LocationId = 8, Hours = 100 },
                new Property { LocationId = 9, Hours = 120 },
                new Property { LocationId = 11, Hours = 140 },
                new Property { LocationId = 12, Hours = 150 },
                new Property { LocationId = 13, Hours = 140 },
                new Property { LocationId = 14, Hours = 160 },
                new Property { LocationId = 15, Hours = 200 },
                new Property { LocationId = 16, Hours = 180 },
                new Property { LocationId = 18, Hours = 180 },
                new Property { LocationId = 19, Hours = 200 },
                new Property { LocationId = 21, Hours = 220 },
                new Property { LocationId = 23, Hours = 220 },
                new Property { LocationId = 24, Hours = 240 },
                new Property { LocationId = 25, Hours = 200 },
                new Property { LocationId = 26, Hours = 260 },
                new Property { LocationId = 27, Hours = 260 },
                new Property { LocationId = 28, Hours = 150 },
                new Property { LocationId = 29, Hours = 280 },
                new Property { LocationId = 31, Hours = 300 },
                new Property { LocationId = 32, Hours = 300 },
                new Property { LocationId = 34, Hours = 320 },
                new Property { LocationId = 35, Hours = 200 },
                new Property { LocationId = 37, Hours = 350 },
                new Property { LocationId = 39, Hours = 400 }
            );
        }
    }
}

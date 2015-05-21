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
                new Property { Id = 1, Hours = 60 },
                new Property { Id = 3, Hours = 60 },
                new Property { Id = 5, Hours = 200 },
                new Property { Id = 6, Hours = 100},
                new Property { Id = 8, Hours = 100 },
                new Property { Id = 9, Hours = 120 },
                new Property { Id = 11, Hours = 140 },
                new Property { Id = 12, Hours = 150 },
                new Property { Id = 13, Hours = 140 },
                new Property { Id = 14, Hours = 160 },
                new Property { Id = 15, Hours = 200 },
                new Property { Id = 16, Hours = 180 },
                new Property { Id = 18, Hours = 180 },
                new Property { Id = 19, Hours = 200 },
                new Property { Id = 21, Hours = 220 },
                new Property { Id = 23, Hours = 220 },
                new Property { Id = 24, Hours = 240 },
                new Property { Id = 25, Hours = 200 },
                new Property { Id = 26, Hours = 260 },
                new Property { Id = 27, Hours = 260 },
                new Property { Id = 28, Hours = 150 },
                new Property { Id = 29, Hours = 280 },
                new Property { Id = 31, Hours = 300 },
                new Property { Id = 32, Hours = 300 },
                new Property { Id = 34, Hours = 320 },
                new Property { Id = 35, Hours = 200 },
                new Property { Id = 37, Hours = 350 },
                new Property { Id = 39, Hours = 400 }
            );
        }
    }
}

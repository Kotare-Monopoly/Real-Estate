namespace RealEstate.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RealEstateDbContext : DbContext
    {
        // Your context has been configured to use a 'Property' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'RealEstate.Models.Property' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Property' 
        // connection string in the application configuration file.
        public RealEstateDbContext()
            : base("name=Property")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("realestate");
        }
    }

    

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
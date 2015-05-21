namespace RealEstate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "realestate.Properties",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        BasePrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("realestate.Properties");
        }
    }
}

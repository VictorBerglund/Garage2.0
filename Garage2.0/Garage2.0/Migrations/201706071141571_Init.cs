namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Garages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegNr = c.String(maxLength: 6),
                        Vehicle = c.Int(nullable: false),
                        Colour = c.String(),
                        NbrOfWheels = c.Int(nullable: false),
                        Tid = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Garages");
        }
    }
}

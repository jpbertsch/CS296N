namespace WorldsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Moon",
                c => new
                    {
                        MoonID = c.Int(nullable: false, identity: true),
                        PlanetID = c.Int(nullable: false),
                        MoonName = c.String(),
                        WorldType = c.String(),
                        WorldSize = c.Int(nullable: false),
                        WorldGravity = c.Double(nullable: false),
                        DayLength = c.Int(nullable: false),
                        Orbit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MoonID)
                .ForeignKey("dbo.Planet", t => t.PlanetID, cascadeDelete: true)
                .Index(t => t.PlanetID);
            
            CreateTable(
                "dbo.Planet",
                c => new
                    {
                        PlanetID = c.Int(nullable: false, identity: true),
                        StarSystemID = c.Int(nullable: false),
                        PlanetName = c.String(),
                        WorldType = c.String(),
                        WorldSize = c.Int(nullable: false),
                        WorldGravity = c.Double(nullable: false),
                        DayLength = c.Int(nullable: false),
                        Orbit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlanetID)
                .ForeignKey("dbo.StarSystem", t => t.StarSystemID, cascadeDelete: true)
                .Index(t => t.StarSystemID);
            
            CreateTable(
                "dbo.StarSystem",
                c => new
                    {
                        StarSystemID = c.Int(nullable: false, identity: true),
                        Xcoordinate = c.Int(nullable: false),
                        Ycoordinate = c.Int(nullable: false),
                        StarName = c.String(),
                        StarType = c.String(),
                    })
                .PrimaryKey(t => t.StarSystemID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planet", "StarSystemID", "dbo.StarSystem");
            DropForeignKey("dbo.Moon", "PlanetID", "dbo.Planet");
            DropIndex("dbo.Planet", new[] { "StarSystemID" });
            DropIndex("dbo.Moon", new[] { "PlanetID" });
            DropTable("dbo.StarSystem");
            DropTable("dbo.Planet");
            DropTable("dbo.Moon");
        }
    }
}

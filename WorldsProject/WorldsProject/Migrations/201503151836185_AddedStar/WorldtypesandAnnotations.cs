namespace WorldsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStarWorldtypesandAnnotations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StarType",
                c => new
                    {
                        StarTypeID = c.Int(nullable: false, identity: true),
                        StarTypeName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.StarTypeID);
            
            CreateTable(
                "dbo.WorldType",
                c => new
                    {
                        WorldTypeID = c.Int(nullable: false, identity: true),
                        WorldTypeName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.WorldTypeID);
            
            AlterColumn("dbo.StarSystem", "StarName", c => c.String(maxLength: 50));
            AlterColumn("dbo.StarSystem", "StarType", c => c.String(maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StarSystem", "StarType", c => c.String());
            AlterColumn("dbo.StarSystem", "StarName", c => c.String());
            DropTable("dbo.WorldType");
            DropTable("dbo.StarType");
        }
    }
}

namespace WorldsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _03182015update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StarSystem", "StarName", c => c.String());
            AlterColumn("dbo.StarSystem", "StarType", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StarSystem", "StarType", c => c.String(maxLength: 12));
            AlterColumn("dbo.StarSystem", "StarName", c => c.String(maxLength: 50));
        }
    }
}

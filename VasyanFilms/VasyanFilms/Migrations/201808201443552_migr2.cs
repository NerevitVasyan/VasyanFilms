namespace VasyanFilms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Actors", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Actors", "Age", c => c.Int(nullable: false));
        }
    }
}

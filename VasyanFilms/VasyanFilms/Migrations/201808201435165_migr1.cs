namespace VasyanFilms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameActor = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Year = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                        Genre_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Genres", t => t.Genre_ID)
                .Index(t => t.Genre_ID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameGenre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FilmActors",
                c => new
                    {
                        Film_ID = c.Int(nullable: false),
                        Actor_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Film_ID, t.Actor_ID })
                .ForeignKey("dbo.Films", t => t.Film_ID, cascadeDelete: true)
                .ForeignKey("dbo.Actors", t => t.Actor_ID, cascadeDelete: true)
                .Index(t => t.Film_ID)
                .Index(t => t.Actor_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Films", "Genre_ID", "dbo.Genres");
            DropForeignKey("dbo.FilmActors", "Actor_ID", "dbo.Actors");
            DropForeignKey("dbo.FilmActors", "Film_ID", "dbo.Films");
            DropIndex("dbo.FilmActors", new[] { "Actor_ID" });
            DropIndex("dbo.FilmActors", new[] { "Film_ID" });
            DropIndex("dbo.Films", new[] { "Genre_ID" });
            DropTable("dbo.FilmActors");
            DropTable("dbo.Genres");
            DropTable("dbo.Films");
            DropTable("dbo.Actors");
        }
    }
}

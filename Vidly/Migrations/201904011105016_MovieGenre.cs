namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieGenre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MovieGenreId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovieGenres", t => t.MovieGenreId, cascadeDelete: true)
                .Index(t => t.MovieGenreId);
            
            CreateTable(
                "dbo.MovieGenres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);

            Sql("insert into MovieGenres (id, name) values (1, 'Comedy')");
            Sql("insert into MovieGenres (id, name) values (2, 'Action')");
            Sql("insert into MovieGenres (id, name) values (3, 'Family')");
            Sql("insert into MovieGenres (id, name) values (4, 'Romance')");

        }

        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieGenreId", "dbo.MovieGenres");
            DropIndex("dbo.Movies", new[] { "MovieGenreId" });
            DropTable("dbo.MovieGenres");
            DropTable("dbo.Movies");
        }
    }
}

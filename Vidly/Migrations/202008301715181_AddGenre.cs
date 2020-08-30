namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "Genres_Id", newName: "Genre_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_Genres_Id", newName: "IX_Genre_Id");
            AddColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "GenresId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenresId", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "GenreId");
            RenameIndex(table: "dbo.Movies", name: "IX_Genre_Id", newName: "IX_Genres_Id");
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "Genres_Id");
        }
    }
}

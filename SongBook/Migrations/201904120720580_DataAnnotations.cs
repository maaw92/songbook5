namespace SongBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Songs", "Title", c => c.String(maxLength: 60));
            AlterColumn("dbo.Songs", "Genre", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Songs", "Genre", c => c.String());
            AlterColumn("dbo.Songs", "Title", c => c.String());
        }
    }
}

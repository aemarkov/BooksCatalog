namespace BooksCatalog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class make_book_name_field_larger : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false, maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false, maxLength: 60));
        }
    }
}

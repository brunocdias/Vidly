namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTelephoneToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Telephone", c => c.String(nullable: false, maxLength: 55));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Telephone");
        }
    }
}

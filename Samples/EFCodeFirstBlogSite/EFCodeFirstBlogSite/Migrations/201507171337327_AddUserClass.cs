namespace EFCodeFirstBlogSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        DispalyName = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}

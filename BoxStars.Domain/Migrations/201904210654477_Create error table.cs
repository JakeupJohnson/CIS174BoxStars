namespace BoxStars.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Createerrortable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ErrorId = c.Guid(nullable: false),
                        ErrorDate = c.DateTime(),
                        ErrorMessage = c.String(),
                        StackTrace = c.String(),
                        InnerExceptions = c.String(),
                    })
                .PrimaryKey(t => t.ErrorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Errors");
        }
    }
}

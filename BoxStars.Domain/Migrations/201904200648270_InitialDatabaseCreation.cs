namespace BoxStars.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HighScores",
                c => new
                    {
                        HighScoreId = c.Guid(nullable: false),
                        PersonId = c.Guid(nullable: false),
                        Score = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateAttained = c.DateTime(),
                    })
                .PrimaryKey(t => t.HighScoreId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Guid(nullable: false),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Gender = c.String(maxLength: 6),
                        DateCreated = c.DateTime(),
                        Email = c.String(maxLength: 100),
                        PhoneNumber = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.HighScores");
        }
    }
}

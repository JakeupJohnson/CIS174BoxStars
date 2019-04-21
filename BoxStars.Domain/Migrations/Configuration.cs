namespace BoxStars.Domain.Migrations
{
    using BoxStars.Domain.Entities;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<BoxStars.Domain.GameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BoxStars.Domain.GameContext context)
        {
            context.People.AddOrUpdate(new Person
            {
                PersonId = Guid.Parse("847719b0-af62-490f-a68a-5923b754302c"),
                FirstName = "Jacob",
                LastName = "Johnson",
                Gender = "Male",
                DateCreated = DateTime.Now,
                Email = "jejohnson8@dmacc.edu",
                PhoneNumber = "555-555-5555"
            });

            context.HighScores.AddOrUpdate(new HighScore()
            {
                HighScoreId = Guid.Parse("ebeaa736-2a57-4112-92a6-9cab67845010"),
                PersonId = Guid.Parse("72cb4327-9409-44ff-98b6-965a1361605e"),
                Score = 500,
                DateAttained = DateTime.Now
            });

            context.HighScores.AddOrUpdate(new HighScore()
            {
                HighScoreId = Guid.Parse("8260397f-7e89-4a7e-b676-2aa42a3dcc1f"),
                PersonId = Guid.Parse("847719b0-af62-490f-a68a-5923b754302c"),
                Score = 1000,
                DateAttained = DateTime.Now
            });

            context.HighScores.AddOrUpdate(new HighScore()
            {
                HighScoreId = Guid.Parse("32b4e031-5556-44d8-8870-c2bf7bf0a142"),
                PersonId = Guid.Parse("847719b0-af62-490f-a68a-5923b754302c"),
                Score = 1500,
                DateAttained = DateTime.Now
            });

            context.HighScores.AddOrUpdate(new HighScore()
            {
                HighScoreId = Guid.Parse("d0e8d1c9-b82a-4677-908d-d2fe051d971c"),
                PersonId = Guid.Parse("847719b0-af62-490f-a68a-5923b754302c"),
                Score = 2000,
                DateAttained = DateTime.Now
            });

            context.HighScores.AddOrUpdate(new HighScore()
            {
                HighScoreId = Guid.Parse("b2a92bb5-a8c9-4777-9b94-3228da746149"),
                PersonId = Guid.Parse("847719b0-af62-490f-a68a-5923b754302c"),
                Score = 2500,
                DateAttained = DateTime.Now
            });
        }
    }
}

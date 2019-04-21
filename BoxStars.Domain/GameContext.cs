using BoxStars.Domain.Entities;
using System.Data.Entity;

namespace BoxStars.Domain
{
    public class GameContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<HighScore> HighScores { get; set; }
    }
}

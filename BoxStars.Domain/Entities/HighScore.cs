using System;
using System.ComponentModel.DataAnnotations;

namespace BoxStars.Domain.Entities
{
    public class HighScore
    {
        [Key]
        public Guid HighScoreId { get; set; }
        public Guid PersonId { get; set; }
        public decimal Score { get; set; }
        public DateTime? DateAttained { get; set; }
    }
}

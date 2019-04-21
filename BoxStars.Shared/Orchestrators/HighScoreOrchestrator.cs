using BoxStars.Domain;
using BoxStars.Shared.Orchestrators.Interfaces;
using BoxStars.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxStars.Shared.Orchestrators
{
    public class HighScoreOrchestrator : IHighScoreOrchestrator
    {
        private readonly GameContext _gameContext;

        public HighScoreOrchestrator()
        {
            _gameContext = new GameContext();
        }

        public List<HighScoreViewModel> GetAllHighscores()
        {
            var highscores = _gameContext.HighScores.Select(x => new HighScoreViewModel
            {
                PersonId = x.PersonId,
                Score = x.Score,
                DateAttained = x.DateAttained
            }).ToList();

            return highscores;
        }
    }
}

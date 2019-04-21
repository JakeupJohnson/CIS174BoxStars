using BoxStars.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxStars.Shared.Orchestrators.Interfaces
{
    public interface IHighScoreOrchestrator
    {
        List<HighScoreViewModel> GetAllHighscores();
    }
}

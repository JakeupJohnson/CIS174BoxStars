using BoxStars.Domain;
using BoxStars.Domain.Entities;
using BoxStars.Shared.Orchestrators.Interfaces;
using BoxStars.Shared.ViewModels;
using System;
using System.Threading.Tasks;

namespace BoxStars.Shared.Orchestrators
{
    public class ErrorOrchestrator : IErrorOrchestrator
    {
        private readonly GameContext _gameContext;

        public ErrorOrchestrator()
        {
            _gameContext = new GameContext();
        }


        public async Task<int> CreateErrorLog(ErrorViewModel error)
        {
            _gameContext.Errors.Add(new Error
            {
                ErrorId = error.ErrorId,
                ErrorDate = DateTime.Now,
                ErrorMessage = error.ErrorMessage,
                StackTrace = error.StackTrace,
                InnerExceptions = error.InnerExceptions
            });
            return await _gameContext.SaveChangesAsync();
        }
    }
}

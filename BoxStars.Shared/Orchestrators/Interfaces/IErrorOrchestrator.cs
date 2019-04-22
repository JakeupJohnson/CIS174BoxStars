using BoxStars.Shared.ViewModels;
using System.Threading.Tasks;

namespace BoxStars.Shared.Orchestrators.Interfaces
{
    public interface IErrorOrchestrator
    {
        Task<int> CreateErrorLog(ErrorViewModel error);//CreatePerson structure
    }
}

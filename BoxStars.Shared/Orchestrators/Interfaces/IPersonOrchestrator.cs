using BoxStars.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoxStars.Shared.Orchestrators.Interfaces
{
    public interface IPersonOrchestrator
    {
        Task<List<PersonViewModel>> GetAllPeople();
        Task<int> CreatePerson(PersonViewModel person);
        Task<bool> UpdatePerson(PersonViewModel person);
        Task<PersonViewModel> SearchPeople(Guid searchGuid);
    }
}

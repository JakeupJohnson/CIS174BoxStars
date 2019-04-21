using BoxStars.Shared.Orchestrators.Interfaces;
using BoxStars.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace BoxStars.Web.Api
{
    [Route("api/v1/people")]
    public class PersonApiController : ApiController
    {
        private readonly IPersonOrchestrator _personOrchestrator;

        public PersonApiController(IPersonOrchestrator personOrchestrator)
        {
            _personOrchestrator = personOrchestrator;
        }

        [HttpGet]
        [Route("api/v1/people/get")]
        public Task<List<PersonViewModel>> GetAllPeople()
        {
            var people = _personOrchestrator.GetAllPeople();

            return people;
        }
    }
}

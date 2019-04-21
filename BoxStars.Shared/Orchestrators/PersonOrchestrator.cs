using BoxStars.Domain;
using BoxStars.Domain.Entities;
using BoxStars.Shared.Orchestrators.Interfaces;
using BoxStars.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BoxStars.Shared.Orchestrators
{
    public class PersonOrchestrator : IPersonOrchestrator
    {
        private readonly GameContext _gameContext;

        public PersonOrchestrator()
        {
            _gameContext = new GameContext();
        }

        public Task<List<PersonViewModel>> GetAllPeople()
        {
            var people = _gameContext.People.Select(x => new PersonViewModel
            {
                PersonId = x.PersonId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Gender = x.Gender,
                DateCreated = x.DateCreated,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber
            }).ToListAsync();
            return people;
        }

        public async Task<int> CreatePerson(PersonViewModel person)
        {
            _gameContext.People.Add(new Person

            {
                PersonId = person.PersonId,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Gender = person.Gender,
                DateCreated = DateTime.Now,
                Email = person.Email,
                PhoneNumber = person.PhoneNumber
            });

            return await _gameContext.SaveChangesAsync();
        }

        public async Task<PersonViewModel> SearchPeople(Guid searchGuid)
        {
            var person = await _gameContext.People.Where(x => x.PersonId.Equals(searchGuid)).FirstOrDefaultAsync();//takes first one and returns(i.e. not compairing duplicates) - First or DeffaultAsync

            if (person == null || person.PersonId == null)
            {
                return new PersonViewModel();//returns empty model since nothing was found in PersonId search
            }

            var viewModel = new PersonViewModel
            {
                PersonId = person.PersonId,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Gender = person.Gender,
                DateCreated = person.DateCreated,
                Email = person.Email,
                PhoneNumber = person.PhoneNumber
            };
            return viewModel;
        }

        public async Task<bool> UpdatePerson(PersonViewModel person)//week 6 update page and jQuery
        {
            var updateEntity = await _gameContext.People.FindAsync(person.PersonId);

            if (updateEntity == null)
            {
                return false;
            }
            //never update Id
            updateEntity.FirstName = person.FirstName;
            updateEntity.LastName = person.LastName;
            updateEntity.Gender = person.Gender;
            updateEntity.Email = person.Email;
            updateEntity.PhoneNumber = person.PhoneNumber;

            await _gameContext.SaveChangesAsync();

            return true;
        }
    }
}

using MsrtDg.Core.ViewModels;
using MsrtDg.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MsrtDg.Core.Services
{
    public class PersonService : IPersonService
    {
        IPersonRepository _personRepository;

        public PersonService (IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public PersonViewModel GetPersons()
        {
            return new PersonViewModel()
            {
                Persons = _personRepository.GetPersons()

            };
        }
    }
}

using MsrtDg.Domain.Interfaces;
using MsrtDg.Domain.Models;
using MsrtDg.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MsrtDg.Infra.Data.Repository
{
    class PersonRepository : IPersonRepository
    {
        private MsrtDBContext _ctx;


        public PersonRepository(MsrtDBContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Person> GetPersons()
        {
            return _ctx.Persons;
        }
    }
}

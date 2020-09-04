using MsrtDg.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MsrtDg.Domain.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPersons();
    }
}

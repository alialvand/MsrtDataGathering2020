using MsrtDg.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MsrtDg.Core.ViewModels
{
    public class PersonViewModel
    {
       public IEnumerable<Person> Persons { get; set; }
    }
}

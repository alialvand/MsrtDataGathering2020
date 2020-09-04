using MsrtDg.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MsrtDg.Core.Services
{
    public interface IPersonService
    {
        PersonViewModel GetPersons();
    }
}

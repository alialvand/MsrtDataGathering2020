using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MsrtDg.Core.Services;
using MsrtDg.Core.ViewModels;

namespace MsrtDg.Api.Sama.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        [Route("GetPersons")]
        public PersonViewModel GetPersons()
        {
            return _personService.GetPersons();
        }
    }
}

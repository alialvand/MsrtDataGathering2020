using Microsoft.Extensions.DependencyInjection;
using MsrtDg.Core.Services;
using MsrtDg.Domain.Interfaces;
using MsrtDg.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MsrtDg.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Application Layer
            service.AddScoped<IPersonService,PersonService>();


            //Infra
            service.AddScoped<IPersonRepository, PersonRepository>();

        }

    }
}

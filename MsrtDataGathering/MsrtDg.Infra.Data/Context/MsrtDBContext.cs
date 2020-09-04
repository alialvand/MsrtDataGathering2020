using Microsoft.EntityFrameworkCore;
using MsrtDg.Domain.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MsrtDg.Infra.Data.Context
{
    public class MsrtDBContext:DbContext
    {

        public MsrtDBContext(DbContextOptions<MsrtDBContext> options):base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }

    }


}

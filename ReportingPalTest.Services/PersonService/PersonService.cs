using ReportingPalTest.Database.Context;
using ReportingPalTest.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportingPalTest.Services.PersonService
{
    public class PersonService : IPersonService
    {
        public PersonDbContext DbContext { get; set; }

        public async Task<Person> Get(int? id)
        {
            return await DbContext.People.Where(person => person.Id == id).FirstOrDefaultAsync();
        }
    }
}

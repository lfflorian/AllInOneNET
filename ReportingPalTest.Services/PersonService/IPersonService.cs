using ReportingPalTest.Database.Context;
using ReportingPalTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportingPalTest.Services.PersonService
{
    interface IPersonService
    {
        PersonDbContext DbContext { get; set; }
        Task<Person> Get(int? id); 
    }
}

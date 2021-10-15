using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReportingPalTest.Database.Context;
using ReportingPalTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingPalTest.WebApi.Mock
{
    public class DbGenerator
    {
        public static void Initialize(IServiceProvider service)
        {
            using (var context = new PersonDbContext(service.GetRequiredService<DbContextOptions<PersonDbContext>>()))
            {
                if (context.People.Any()) { return;  }

                context.People.AddRange(
                    new Person
                    {
                        Id = 1,
                        Name = "Pablo",
                        Age = 5
                    },
                    new Person
                    {
                        Id = 2,
                        Name = "Amy",
                        Age = 8
                    },
                    new Person
                    {
                        Id = 3,
                        Name = "Stuart",
                        Age = 5
                    },
                    new Person
                    {
                        Id = 4,
                        Name = "Eduardo",
                        Age = 7
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using ReportingPalTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportingPalTest.Database.Context
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
        {}

        public virtual DbSet<Person> People { get; set; }
    }
}

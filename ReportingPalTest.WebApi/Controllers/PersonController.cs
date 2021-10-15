using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportingPalTest.Services.PersonService;
using ReportingPalTest.WebApi.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingPalTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService Service;

        public PersonController(IPersonService service)
        {
            Service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PersonRequest req)
        {
            var person = await Service.Get(req.UniqueId);

            if (person == null)
            {
                return NoContent();
            }

            return Ok(person);
        }
    }
}

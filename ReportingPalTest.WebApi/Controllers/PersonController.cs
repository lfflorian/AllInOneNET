using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportingPalTest.Services.PersonService;
using ReportingPalTest.WebApi.Middleware;
using ReportingPalTest.WebApi.Model.Dto;
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
        private readonly IMapper _mapper;

        public PersonController(IPersonService service, IMapper mapper)
        {
            Service = service;
            _mapper = mapper;
        }

        [HttpPost]
        [ServiceFilter(typeof(ModelValidationAttribute))]
        public async Task<IActionResult> Post([FromBody] PersonRequest req)
        {
            var person = await Service.Get(req.UniqueId);
            
            if (person == null)
            {
                return NoContent();
            }

            var personDto = _mapper.Map<PersonDto>(person);

            return Ok(personDto);
        }
    }
}

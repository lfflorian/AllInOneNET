using AutoMapper;
using ReportingPalTest.Entities;
using ReportingPalTest.WebApi.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingPalTest.WebApi.Middleware
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            this.CreateMap<Person, PersonDto> (MemberList.None)
                .ForMember(identity => identity.Name, dto => dto.MapFrom(model => model.Name))
                .ForMember(identity => identity.Age, dto => dto.MapFrom(model => model.Age));
        }
    }
}

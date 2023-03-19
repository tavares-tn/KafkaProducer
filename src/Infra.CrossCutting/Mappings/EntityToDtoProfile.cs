using AutoMapper;
using Domain.DTOs;
using Domain.DTOs.Request;
using Domain.DTOs.Response;
using Domain.Entities;

namespace Infra.CrossCutting.Mappings
{
    public class EntityToDtoProfile: Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<ExampleDto, ExampleEntity>()
                .ReverseMap();

            CreateMap<RequestExampleDto, ExampleEntity>()
                .ReverseMap();

            CreateMap<ResponseExampleDto, ExampleEntity>()
                .ReverseMap();
        }
    }
}

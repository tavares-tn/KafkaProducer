using AutoMapper;
using Domain.Entities;
using Domain.Models;
using Domain.Models.Request;
using Domain.Models.Response;

namespace Infra.CrossCutting.Mappings
{
    public class ModelToEntity: Profile
    {
        public ModelToEntity()
        {
            CreateMap<ExampleEntity, ExampleModel>()
                .ReverseMap();

            CreateMap<ExampleEntity, RequestExampleModel>()
                .ReverseMap();

            CreateMap<ExampleEntity, ResponseExampleModel>()
                .ReverseMap();
        }
    }
}

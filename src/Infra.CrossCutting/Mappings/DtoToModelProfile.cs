using AutoMapper;
using Domain.DTOs;
using Domain.DTOs.Request;
using Domain.DTOs.Response;
using Domain.Models;
using Domain.Models.Request;
using Domain.Models.Response;

namespace Infra.CrossCutting.Mappings
{
    public class DtoToModelProfile: Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<ExampleModel, ExampleDto>()
                .ReverseMap();

            CreateMap<RequestExampleModel, RequestExampleDto>()
                .ReverseMap();

            CreateMap<ResponseExampleModel, ResponseExampleDto>()
                .ReverseMap();
        }
    }
}

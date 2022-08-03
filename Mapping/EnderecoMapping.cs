using artigotech_integra_brasilapi.Dtos;
using artigotech_integra_brasilapi.Models;
using AutoMapper;

namespace artigotech_integra_brasilapi.Mapping
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();
        }
    }
}
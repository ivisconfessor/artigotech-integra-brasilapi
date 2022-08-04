using artigotech_integra_brasilapi.Dtos;
using artigotech_integra_brasilapi.Models;
using AutoMapper;

namespace artigotech_integra_brasilapi.Mapping
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();
        }
    }
}
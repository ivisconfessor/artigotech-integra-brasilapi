using artigotech_integra_brasilapi.Dtos;

namespace artigotech_integra_brasilapi.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}
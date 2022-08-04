using artigotech_integra_brasilapi.Dtos;
using artigotech_integra_brasilapi.Models;

namespace artigotech_integra_brasilapi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);
    }
}
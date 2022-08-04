using artigotech_integra_brasilapi.Dtos;

namespace artigotech_integra_brasilapi.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos();
        Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);
    }
}
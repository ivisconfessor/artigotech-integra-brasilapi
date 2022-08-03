using System.Text.Json;
using artigotech_integra_brasilapi.Dtos;
using artigotech_integra_brasilapi.Models;
using artigotech_integra_brasilapi.Interfaces;
using System.Dynamic;

namespace artigotech_integra_brasilapi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
            
            var response = new ResponseGenerico<EnderecoModel>();
            using (var client = new HttpClient()) {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResp); 

                if (responseBrasilApi.IsSuccessStatusCode) 
                {    
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.Objeto = objResponse;
                }
                else 
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.Body = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }
    }
}
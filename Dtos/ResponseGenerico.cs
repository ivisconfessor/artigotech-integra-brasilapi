using System.Dynamic;
using System.Net;

namespace artigotech_integra_brasilapi.Dtos
{
    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode CodigoHttp { get; set; }
        public ExpandoObject? Body { get; set; }

        public T? Objeto { get; set; }
    }
}
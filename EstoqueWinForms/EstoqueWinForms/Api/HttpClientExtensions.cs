using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueWinForms.Api
{
    public static class HttpClientExtensions
    {
        public static Task<HttpResponseMessage> PatchAsJsonAsync<T>(
            this HttpClient http, string requestUri, T value)
        {
            var req = new HttpRequestMessage(HttpMethod.Patch, requestUri)
            {
                Content = JsonContent.Create(value)
            };
            return http.SendAsync(req);
        }
    }
}

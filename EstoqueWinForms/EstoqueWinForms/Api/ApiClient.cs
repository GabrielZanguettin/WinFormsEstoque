using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using EstoqueWinForms.Contracts;

namespace EstoqueWinForms.Api
{
    public class ApiClient : IDisposable
    {
        private readonly HttpClient _http;
        private readonly bool _ownsClient;

        public ApiClient(string baseUrl, HttpClient httpClient = null)
        {
            _ownsClient = httpClient is null;
            _http = httpClient ?? new HttpClient();
            _http.BaseAddress = new Uri(baseUrl.TrimEnd('/'));
            _http.Timeout = TimeSpan.FromSeconds(30);
        }

        public Task<HttpResponseMessage> ListProductsAsync(ProductFiltersDto filters)
        {
            var page = filters.Page ?? 1;
            var size = filters.PageSize ?? 20;

            var url = $"/api/products?Page={page}&PageSize={size}";
            return _http.GetAsync(url);
        }

        public Task<HttpResponseMessage> CreateProductAsync(CreateProductDto dto)
            => _http.PostAsJsonAsync("/api/products", dto);

        public Task<HttpResponseMessage> GetProductByIdAsync(int id)
            => _http.GetAsync($"/api/products/{id}");

        public Task<HttpResponseMessage> IncrementStockAsync(int id, UpdateProductDto dto)
            => _http.PatchAsJsonAsync($"/api/products/{id}/increment", dto);


        public Task<HttpResponseMessage> DecrementStockAsync(int id, UpdateProductDto dto)
            => _http.PatchAsJsonAsync($"/api/products/{id}/decrement", dto);


        public void Dispose()
        {
            if (_ownsClient) _http?.Dispose();
        }
    }
}

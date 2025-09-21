using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueWinForms.Contracts
{
    public record ApiResponse<T>(string Message, T Data);
    public record CreateProductDto(string Name, string Description);
    public record UpdateProductDto(int Quantity);

    public record ProductFiltersDto
    {
        public int? Page { get; set; } = 1;
        public int? PageSize { get; set; } = 20;
    }

    public record ProductDto
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public int Stock { get; init; }
    }
}

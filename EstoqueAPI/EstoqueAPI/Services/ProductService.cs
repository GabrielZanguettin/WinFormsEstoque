using EstoqueAPI.Dtos;
using EstoqueAPI.Models;
using EstoqueAPI.Responses;
using NHibernate;
using NHibernate.Linq;

namespace EstoqueAPI.Services
{
    public class ProductService
    {
        private readonly ISessionFactory sessionFactory;

        public ProductService(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        public async Task<ApiResponse<List<Product>>> FindAll(ProductFiltersDto? filters)
        {
            using var session = sessionFactory.OpenSession();
            session.DefaultReadOnly = true;

            var page = filters?.Page ?? 1;
            var pageSize = filters?.PageSize ?? 20;

            var query = session.Query<Product>().OrderBy(p => p.Name);

            var products = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new ApiResponse<List<Product>>
            {
                Message = "Produtos listados com sucesso.",
                Data = products
            };
        }

        public async Task<ApiResponse<Product>> FindOne(int id)
        {
            using var session = sessionFactory.OpenSession();
            session.DefaultReadOnly = true;

            var product = await session.GetAsync<Product>(id);

            if (product is null)
                throw new InvalidOperationException("Produto não encontrado.");

            return new ApiResponse<Product>
            {
                Message = "Produto encontrado com sucesso.",
                Data = product
            };
        }

        public async Task<ApiResponse<Product>> Create(CreateProductDto dto)
        {
            if (dto is null)
                throw new ArgumentNullException(nameof(dto), "Payload não pode ser nulo.");

            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new ArgumentException("Nome é obrigatório.", nameof(dto.Name));

            if (string.IsNullOrWhiteSpace(dto.Description))
                throw new ArgumentException("Descrição é obrigatória.", nameof(dto.Description));

            var name = dto.Name.Trim();
            var description = dto.Description.Trim();

            using var session = sessionFactory.OpenSession();
            using var tx = session.BeginTransaction();

            var product = new Product
            {
                Name = name,
                Description = description,
                Stock = 5
            };

            await session.SaveAsync(product);
            await tx.CommitAsync();

            return new ApiResponse<Product>
            {
                Message = "Produto criado com sucesso.",
                Data = product
            };
        }

        public async Task<ApiResponse<Product>> IncreaseStock(int id, UpdateProductDto dto)
        {
            if (dto is null) throw new ArgumentNullException(nameof(dto));
            if (dto.Quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(dto.Quantity), "A quantidade deve ser maior que zero.");

            using var session = sessionFactory.OpenSession();
            using var tx = session.BeginTransaction();

            var affected = await session.CreateQuery(
                    "update Product p set p.Stock = p.Stock + :q " +
                    "where p.Id = :id")
                .SetParameter("q", dto.Quantity)
                .SetParameter("id", id)
                .ExecuteUpdateAsync();

            if (affected == 0)
            {
                await tx.RollbackAsync();
                throw new InvalidOperationException("Produto não encontrado.");
            }

            var product = await session.GetAsync<Product>(id);

            await tx.CommitAsync();

            return new ApiResponse<Product>
            {
                Message = "Estoque incrementado com sucesso.",
                Data = product
            };
        }

        public async Task<ApiResponse<Product>> DecrementStock(int id, UpdateProductDto dto)
        {
            if (dto is null) throw new ArgumentNullException(nameof(dto));
            if (dto.Quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(dto.Quantity), "A quantidade deve ser maior que zero.");

            using var session = sessionFactory.OpenSession();
            using var tx = session.BeginTransaction();

            var affected = await session.CreateQuery(
                    "update Product p set p.Stock = p.Stock - :q " +
                    "where p.Id = :id and p.Stock >= :q")
                .SetParameter("q", dto.Quantity)
                .SetParameter("id", id)
                .ExecuteUpdateAsync();

            if (affected == 0)
            {
                await tx.RollbackAsync();
                throw new InvalidOperationException("Produto não encontrado ou estoque insuficiente.");
            }

            var product = await session.GetAsync<Product>(id);

            await tx.CommitAsync();

            return new ApiResponse<Product>
            {
                Message = "Estoque decrementado com sucesso.",
                Data = product
            };
        }
    }
}

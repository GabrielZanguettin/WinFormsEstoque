using EstoqueAPI.Dtos;
using EstoqueAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace EstoqueAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService productService;

        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("products")]
        [SwaggerOperation(
            Summary = "List products",
            Description = "Returns a filtered (and optionally paginated) list of products based on the provided query parameters."
        )]
        public async Task<IActionResult> FindAll([FromQuery] ProductFiltersDto? filters)
        {
            var response = await productService.FindAll(filters);
            return Ok(response);
        }

        [HttpGet("products/{id:int}")]
        [SwaggerOperation(
            Summary = "Get product by ID",
            Description = "Fetches a single product that matches the specified identifier."
        )]
        public async Task<IActionResult> FindOne([FromRoute] int id)
        {
            try
            {
                var resp = await productService.FindOne(id);
                return Ok(resp);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        [HttpPost("products")]
        [SwaggerOperation(
            Summary = "Create a new product",
            Description = "Creates a new product with the provided data and returns the created resource."
        )]
        public async Task<IActionResult> Create([FromBody] CreateProductDto dto)
        {
            var resp = await productService.Create(dto);
            return CreatedAtAction(nameof(FindOne), new { id = resp.Data.Id }, resp);
        }

        [HttpPatch("products/{id:int}/increment")]
        [SwaggerOperation(
            Summary = "Increase product stock",
            Description = "Increases the stock quantity of the specified product by the provided amount."
        )]
        public async Task<IActionResult> IncrementStock([FromRoute] int id, [FromBody] UpdateProductDto dto)
        {
            try
            {
                var resp = await productService.IncreaseStock(id, dto);
                return Ok(resp);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        [HttpPatch("products/{id:int}/decrement")]
        [SwaggerOperation(
            Summary = "Decrease product stock",
            Description = "Decreases the stock quantity of the specified product by the provided amount. Fails if there is insufficient stock."
        )]
        public async Task<IActionResult> DecrementStock([FromRoute] int id, [FromBody] UpdateProductDto dto)
        {
            try
            {
                var resp = await productService.DecrementStock(id, dto);
                return Ok(resp);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
    }
}

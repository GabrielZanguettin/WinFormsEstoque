using System.ComponentModel.DataAnnotations;

namespace EstoqueAPI.Dtos
{
    /// <summary>
    /// Data transfer object used to decrement a product's stock.
    /// </summary>
    public class UpdateProductDto
    {
        /// <summary>
        /// Quantity to add/subtract from the current stock (must be greater than zero).
        /// </summary>
        public int Quantity { get; set; }
    }
}
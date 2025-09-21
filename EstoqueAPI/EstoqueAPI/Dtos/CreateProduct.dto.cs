using System.ComponentModel.DataAnnotations;

namespace EstoqueAPI.Dtos
{
    /// <summary>Data transfer object used to create a new product.</summary>
    public class CreateProductDto
    {
        /// <summary>The product name displayed to users.</summary>
        public string Name { get; set; }

        /// <summary>A concise description highlighting the product’s main features.</summary>
        public string Description { get; set; }
    }
}
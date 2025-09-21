using System.ComponentModel.DataAnnotations;

namespace EstoqueAPI.Models
{
    public class Product
    {
        public virtual int Id { get; set; }
        [Required]
        public virtual string Name { get; set; }
        [Required]
        public virtual string Description { get; set; }
        [Required]
        public virtual int Stock { get; set; }
    }
}

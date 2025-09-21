namespace EstoqueAPI.Dtos
{
    /// <summary>
    /// Pagination filters for listing products.
    /// </summary>
    public class ProductFiltersDto
    {
        /// <summary>
        /// Page number (1-based). Defaults to 1.
        /// </summary>
        public int? Page { get; set; } = 1;

        /// <summary>
        /// Page size (items per page). Defaults to 20.
        /// </summary>
        public int? PageSize { get; set; } = 20;
    }
}
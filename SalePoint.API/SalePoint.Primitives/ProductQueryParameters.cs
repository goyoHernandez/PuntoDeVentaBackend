namespace SalePoint.Primitives
{
    public record ProductQueryParameters
    {
        public int? PageNumber { get; set; }
        
        public int? PageSize { get; set; }
        
        public string? KeyWord { get; set; }
    }
}
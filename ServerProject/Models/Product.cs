namespace ServerProject.Models
{
    public class Product

    {

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Authors { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Language { get; set; } = string.Empty;
        public ProductStatus Status { get; set; }
        public string CoverImagePath { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Tags { get; set; } = string.Empty;
        public int StockCount { get; set; }

    }



    public enum ProductStatus
    {
        Active,
        Inactive,
        ComingSoon,
        Archived
    }
}

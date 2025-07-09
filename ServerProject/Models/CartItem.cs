namespace ServerProject.Models
{
    public class CartItem
    {
        public int Id { get; set; }        // Unique ID for THIS cart entry
        public int ProductId { get; set; } // Foreign key to the actual Product
        public Product? Product { get; set; }
    }
}

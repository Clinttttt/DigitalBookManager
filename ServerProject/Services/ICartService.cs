using ServerProject.Models;
namespace ServerProject.Services
{
    public interface ICartService
    {
        Task<List<Product>> CartItems { get; }
        event Action Onchange;
        Task AddToCart(Product product);
        Task RemoveFromCart(Product product);
        Task<List<Product>> GetCart();
    }

}

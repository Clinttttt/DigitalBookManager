using ServerProject.Models;

namespace ServerProject.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProduct();
        Task<Product> GetProduct(int productId);
        Task DeleteBook(Product product);

    }
}

using Microsoft.EntityFrameworkCore;
using ServerProject.Data;
using ServerProject.Models;
namespace ServerProject.Services
{
    public class ProductService : IProductService
    {

        private readonly ApplicationDbContext _db;

        public ProductService(ApplicationDbContext db) => _db = db;
        public event Action? Onchange;
        public async Task<List<Product>> GetAllProduct() =>
            await _db.ProductInfos.ToListAsync();
        public async Task<Product?> GetProduct(int productId)
        {
            // Use FirstOrDefaultAsync to ensure null is returned if not found
            return await _db.ProductInfos.FirstOrDefaultAsync(p => p.Id == productId);
        }
        public async Task DeleteBook(Product product)
        {
            if (product != null)
            {
                _db.ProductInfos.Remove(product);
                await _db.SaveChangesAsync();
            }

        }






    }


}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServerProject.Models;

namespace ServerProject.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
   
    public DbSet<Product> ProductInfos { get; set; }
    public DbSet<CartItem> CartItems { get; set; }

   public  DbSet<AdminInfoModel> AdminDetails { get; set; }
}

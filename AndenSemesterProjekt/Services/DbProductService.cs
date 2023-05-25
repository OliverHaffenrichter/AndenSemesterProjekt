using AndenSemesterProjekt.EFDbContext;
using AndenSemesterProjekt.Models;
using Microsoft.EntityFrameworkCore;

namespace AndenSemesterProjekt.Services
{
    public class DbProductService
    {
        public async Task<List<Product>> GetProductsAsync()
        {
            List<Product> products;

            using (var context = new MwDbContext())
            {
                products = context.Products
                    .Include(p => p.ProductCategories)
                    .AsNoTracking().ToList();
            }
            return products;
        }
        public async Task<List<Product>> GetProductsByCategoryIdAsync(string category)
        {
            List<Product> products;

            using (var context = new MwDbContext())
            {
                products = context.Products
                    .Where(p => p.ProductCategories.Category == category)
                    .Include(p => p.ProductCategories)
                    .AsNoTracking().ToList();
            }
            return products;
        }
    }
}

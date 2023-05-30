using AndenSemesterProjekt.EFDbContext;
using AndenSemesterProjekt.Models;
using Microsoft.EntityFrameworkCore;

namespace AndenSemesterProjekt.Services
{
    public class DbProductService
    {
        /// <summary>
        /// Method used to get all Products from the Database
        /// </summary>
        /// <returns></returns>
        public async Task<List<Product>> GetProductsAsync()
        {
            List<Product> products;

            using (var context = new MwDbContext())
            {
                products = context.Products
                    .Include(p => p.ProductCategoryList)
                    .AsNoTracking().ToList();
            }
            return products;
        }
        /// <summary>
        /// Method used to get all Product categories from the database
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProductCategoryList>> GetProductCategories()
        {
            List<ProductCategoryList> categories;

            using (var context = new MwDbContext())
            {
                categories = context.ProductCategories.AsNoTracking().ToList();
            }
            return categories;
        }
        /// <summary>
        /// method used to add a product to the database
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task AddProduct(Product product)
        {
            using (var context = new MwDbContext())
            {
                product.ProductCategoryList = context.ProductCategories.FirstOrDefault(c => c.Id == product.ProductCategoryList.Id);
                product.ProductCategoryList.Products.Add(product);
                context.Products
                    .AsNoTracking().ToList().Add(product);
                context.SaveChanges();
            }
        }
        /// <summary>
        /// method used to delete a product from the database
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task UpdateProduct(Product product)
        {
            using (var context = new MwDbContext())
            {
                product.ProductCategoryList = context.ProductCategories.FirstOrDefault(c => c.Id == product.ProductCategoryList.Id);
                product.ProductCategoryList.Products.Add(product);
                context.Products.Update(product);
                context.SaveChanges();
            }
        }
    }
}

using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Mock;
using AndenSemesterProjekt.Models;
using Microsoft.Extensions.Hosting;

namespace AndenSemesterProjekt.Services
{
    public class ProductService : IProductService
    {
        private List<Product> products;
        private List<ProductCategoryList> productCategories;
        private DbService<Product> _dbGenericProductService;
        private DbService<ProductCategoryList> _dbGenericProductCategoriesService;
        private DbProductService _dbProductService;

        public ProductService(DbService<Product> dbGenericProductService, 
            DbProductService dbProductService, DbService<ProductCategoryList> dbGenericProductCategoriesService)
        {
            _dbGenericProductService = dbGenericProductService;
            _dbProductService = dbProductService;
            _dbGenericProductCategoriesService = dbGenericProductCategoriesService;
            //products = MockProduct.GetMockProduct();
            //productCategories = MockProductCategories.GetMockProductCategoreis();
            //_dbGenericProductCategoriesService.SaveObjectsAsync(productCategories);
            //_dbGenericProductService.SaveObjectsAsync(products);
            products = _dbProductService.GetProductsAsync().Result.ToList();
        }

        public List<ProductCategoryList> GetProductCategories()
        {
            //foreach (var product in products)
            //{
            //    if (product.ProductCategories.Category != null
            //        && !productCategories.Any(c => c.Category == product.ProductCategories.Category))
            //    {
            //        productCategories.Add(product.ProductCategories);
            //    }
            //}
            return _dbProductService.GetProductCategories().Result;
        }


        public async Task CreateProduct(Product product)
        {
            products.Add(product);
            await _dbProductService.AddProduct(product);
            //await _dbGenericProductService.AddObjectAsync(product);
        }

        public Product DeleteProduct(int id)
        {
            //foreach (Product product in products)
            //{
            //    if (product.Id == id)
            //    {
            //        products.Remove(product);
            //        return product;
            //    }
            //}
            Product product = GetProductById(id);
            products.Remove(product);
            _dbGenericProductService.DeleteObjectAsync(product);
           // _dbService.SaveObjectsAsync();

            return product;
        }

        public List<Product> GetAllProducts()
        {
            return products; 
        }

        public List<Product> GetProductByCategory(int id)
        {
            //List<Product> productCategory = new List<Product>();
            //if (category != null)
            //{
            //   foreach(Product product in products) 
            //    { 
            //        if (category.Equals(product.Category)) { }
            //    }

            //}
            return products.Where(p => p.ProductCategoryList.Id == id).ToList();
        }

        public List<Product> GetProductByCriteria(string criteria)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            return null;
        }

        public void UpdateProduct(int id, Product product)
        {
            foreach (Product p in products)
            {
                if (p.Id == id)
                {
                    p.Title = product.Title;
                    p.Description = product.Description;
                    p.Price = product.Price;
                    p.ProductCategoryList = product.ProductCategoryList;
                    _dbProductService.UpdateProduct(p);
                    return;
                }
            }
        }
    }
}

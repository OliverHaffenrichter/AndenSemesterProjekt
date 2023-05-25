using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Mock;
using AndenSemesterProjekt.Models;
using Microsoft.Extensions.Hosting;

namespace AndenSemesterProjekt.Services
{
    public class ProductService : IProductService
    {
        private List<Product> products = new List<Product>();
        private List<ProductCategories> productCategories = new List<ProductCategories>();
        private DbService<Product> _dbService;
        private DbProductService _dbProductService;

        public ProductService(DbService<Product> dbservice, DbProductService dbProductService)
        {
            _dbService = dbservice;
            _dbProductService = dbProductService;
            //products = MockProduct.GetMockProduct();
            //_dbService.SaveObjectsAsync(products);
            products = _dbProductService.GetProductsAsync().Result.ToList();
        }

        public List<ProductCategories> GetProductCategories()
        {
            foreach (var product in products)
            {
                if (product.ProductCategories.Category != null
                    && !productCategories.Any(c => c.Category == product.ProductCategories.Category))
                {
                    productCategories.Add(product.ProductCategories);
                }
            }
            return productCategories;
        }


        public async Task CreateProduct(string title, string description, double price, string category)
        {
            Product result = new Product(title, description, category, price);
            products.Add(result);
            Console.WriteLine(result);
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
            _dbService.DeleteObjectAsync(product);
           // _dbService.SaveObjectsAsync();

            return product;
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public List<Product> GetProductByCategory(string category)
        {
            //List<Product> productCategory = new List<Product>();
            //if (category != null)
            //{
            //   foreach(Product product in products) 
            //    { 
            //        if (category.Equals(product.Category)) { }
            //    }

            //}
            return _dbProductService.GetProductsByCategoryIdAsync(category).Result.ToList();
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
            products[id] = product;
        }
    }
}

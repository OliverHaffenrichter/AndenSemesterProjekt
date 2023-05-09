using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Mock;
using AndenSemesterProjekt.Models;
using Microsoft.Extensions.Hosting;

namespace AndenSemesterProjekt.Services
{
    public class ProductService : IProductService
    {

        private List<Product> products = new List<Product>();

      
        public ProductService()
        {
            products = MockProduct.GetMockProduct();
        }


        public Product CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product DeleteProduct(int id)
        {
            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    products.Remove(product);
                    return product;
                }
            }
            return null;
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public List<Product> GetProductByCategory(string category)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}

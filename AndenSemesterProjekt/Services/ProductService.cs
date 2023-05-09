using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Mock;
using AndenSemesterProjekt.Models;

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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}

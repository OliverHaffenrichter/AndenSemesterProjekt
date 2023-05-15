using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Interfaces
{
    public interface IProductService
    {

        Product CreateProduct(Product product);
        Product DeleteProduct(int id);
        void UpdateProduct(int id, Product product);
        List<Product> GetAllProducts();
        List<Product> GetProductByCategory(string category);
        List<Product> GetProductByCriteria(string criteria);
        Product GetProductById(int id);

      
    }
}

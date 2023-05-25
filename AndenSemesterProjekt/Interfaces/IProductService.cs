using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Interfaces
{
    public interface IProductService
    {
        Task CreateProduct(string title, string description, double price, ProductCategories category);
        Product DeleteProduct(int id);
        void UpdateProduct(int id, Product product);
        List<Product> GetAllProducts();
        List<Product> GetProductByCategory(string category);
        List<Product> GetProductByCriteria(string criteria);
        Product GetProductById(int id);
        List<ProductCategories> GetProductCategories();

    }
}

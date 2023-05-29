using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Interfaces
{
    public interface IProductService
    {
        Task CreateProduct(Product product);
        Product DeleteProduct(int id);
        void UpdateProduct(int id, Product product);
        List<Product> GetAllProducts();
        List<Product> GetProductByCategory(int id);
        List<Product> GetProductByCriteria(string criteria);
        Product GetProductById(int id);
        List<ProductCategoryList> GetProductCategories();

    }
}

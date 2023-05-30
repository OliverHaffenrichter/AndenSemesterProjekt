using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Interfaces
{
    public interface IProductService
    {
        /// <summary>
        /// method used for creation Products for the product page
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task CreateProduct(Product product);
        /// <summary>
        /// Method used for deleting products from the product page based on an id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Product DeleteProduct(int id);
        /// <summary>
        /// Method used for updating a product from the product page
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        void UpdateProduct(int id, Product product);
        /// <summary>
        /// Method used get all products
        /// </summary>
        /// <returns></returns>
        List<Product> GetAllProducts();
        /// <summary>
        /// Method used to get all products based on a category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Product> GetProductByCategory(int id);
        /// <summary>
        /// Method used to get all products based on a serach Criteria
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        List<Product> GetProductByCriteria(string criteria);
        /// <summary>
        /// method used to get a products based on id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Product GetProductById(int id);
        /// <summary>
        /// method used to get all the products categroies 
        /// </summary>
        /// <returns></returns>
        List<ProductCategoryList> GetProductCategories();

    }
}

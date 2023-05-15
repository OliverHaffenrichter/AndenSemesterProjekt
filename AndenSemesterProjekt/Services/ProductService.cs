using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Mock;
using AndenSemesterProjekt.Models;
using Microsoft.Extensions.Hosting;

namespace AndenSemesterProjekt.Services
{
    public class ProductService : IProductService
    {

        private List<Product> products = new List<Product>();
        private List<string> productCategories = new List<string>()
        { 
            new ("Menditation"),
            new ("Styrke Træning"),
            new ("yaddaddaa"),
            new ("Fingleburm")
        };

      
        public ProductService()
        {
            products = MockProduct.GetMockProduct();
        }


        public List<string> GetProductCategories()
        {
            return productCategories;
        }
        public Product CreateProduct(Product product)
        {
            throw new NotImplementedException();
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
           
            if (category != null)
            {
                return products.Where(c => c.Category.Equals(category.ToLower())).ToList();
            }
            else
            {
                return products;
            }

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

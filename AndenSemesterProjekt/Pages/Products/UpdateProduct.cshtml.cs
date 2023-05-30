using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Products
{
    public class UpdateProductModel : PageModel
    {
        /// <summary>
        /// Property used to hold the product categories
        /// </summary>
        public List<ProductCategoryList> Categories { get; set; }
        /// <summary>
        /// Property used to hold the Product service
        /// </summary>
        private IProductService _productService { get; set; }
        /// <summary>
        /// Property used to hold the product that gets updated 
        /// </summary>
        [BindProperty]
        public Product Product { get; set; }

        /// <summary>
        /// Property used to contain the information from the quil editor
        /// </summary>
        [BindProperty]
        public string Information { get; set; }

        /// <summary>
        /// Dependency injection
        /// </summary>
        /// <param name="productService"></param>
        public UpdateProductModel(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Method used to get the Product that needs to get updated
        /// </summary>
        /// <param name="id"></param>
        public void OnGet(int id)
        {
            Categories = _productService.GetProductCategories();
            Product = _productService.GetProductById(id);
            Information = Product.Description;
        }

        /// <summary>
        /// method used to Update the Product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        public IActionResult OnPost(int id, Product product)
        {
            Categories = _productService.GetProductCategories();
            product.ProductCategoryList.ProductCategory = Categories.FirstOrDefault(c => c.Id == Product.ProductCategoryList.Id).ProductCategory;
            product.Description = Information;
            _productService.UpdateProduct(id, product);
            return RedirectToPage("DisplayProducts");
        }
    }
}

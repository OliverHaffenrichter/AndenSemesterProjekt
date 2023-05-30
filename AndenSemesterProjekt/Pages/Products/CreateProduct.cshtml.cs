using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Products
{
    public class CreateProductModel : PageModel
    {
        /// <summary>
        /// Property used to contain the ProductCategories
        /// </summary>
        public List<ProductCategoryList> Categories { get; set; }

        /// <summary>
        /// Property used for dependency injection and to contain the ProductService
        /// </summary>
        private IProductService _productService { get; set; }
        /// <summary>
        /// Property used to contain the database service for Products
        /// </summary>
        private DbProductService _dbProductService;
        /// <summary>
        /// Property used to contain the Product that gets created
        /// </summary>
        [BindProperty]
        public Product Product { get; set; } = new Product();

        /// <summary>
        /// Property to contain the information from the Quil editor
        /// </summary>
        [BindProperty]
        public string Information { get; set; }

        /// <summary>
        /// Dependency injections
        /// </summary>
        /// <param name="productService"></param>
        /// <param name="dbProductService"></param>
        public CreateProductModel(IProductService productService, DbProductService dbProductService) 
        { 
            _productService = productService;
            _dbProductService = dbProductService;
        }

        /// <summary>
        /// method used to get the productcategories
        /// </summary>
        public void OnGet()
        {
            Categories = _productService.GetProductCategories();
        }

        /// <summary>
        /// Method used to create the new product
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPost()
        {
            Categories = _dbProductService.GetProductCategories().Result;
            Product.ProductCategoryList.ProductCategory = Categories.FirstOrDefault(c => c.Id == Product.ProductCategoryList.Id).ProductCategory;
            Product.Description = Information;
            await _productService.CreateProduct(Product);
            return RedirectToPage("DisplayProducts");
        }
    }
}

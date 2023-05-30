using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;

namespace AndenSemesterProjekt.Pages.Products
{
    public class DisplayProductModel : PageModel
    {
        /// <summary>
        /// Property used to contain the products being dispalyed
        /// </summary>
        public List<Product> products { get; set; } = new List<Product>();
        /// <summary>
        /// _productService is a Property used to for dependency injection and containing the ProductService
        /// </summary>
        public IProductService _productService;

      
        /// <summary>
        /// Property used to hold the Product categories
        /// </summary>
        [BindProperty]
        public ProductCategoryList Categories { get; set; }

        /// <summary>
        /// Dependency injection
        /// </summary>
        /// <param name="productService"></param>
        public DisplayProductModel(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Method used to display all products
        /// </summary>
        /// <returns></returns>
        public IActionResult OnGet() 
        { 
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //if (category != null) 
            //{
            //    products = _productService.GetProductByCategory(category);

            //    return Page();
            //}
            //else

                products = _productService.GetAllProducts();
                return Page();
        }

        /// <summary>
        /// Method used to displayed products depending on selected category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult OnGetProductsByCat(int id)
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            products = _productService.GetProductByCategory(id);

            return Page();
        }
    }
}

using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing.Printing;

namespace AndenSemesterProjekt.Pages.Products
{
    public class DisplayCategoriesModel : PageModel
    {
        /// <summary>
        /// Property used to contain the ProductCategories
        /// </summary>
        public List<ProductCategoryList> Categories { get; set; }
        /// <summary>
        /// Property used to contain the ProductService
        /// </summary>
        public IProductService _productService;

        /// <summary>
        /// Dependency Injection
        /// </summary>
        /// <param name="productService"></param>
        public DisplayCategoriesModel(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// method used to get the categories
        /// </summary>
        /// <returns></returns>
        public IActionResult OnGet()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Categories = _productService.GetProductCategories();

            return Page();
        }


      
        
    }
}

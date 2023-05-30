using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Interfaces;

namespace AndenSemesterProjekt.Pages.Products
{
    public class ViewProductModel : PageModel
    {
        /// <summary>
        /// Property used to hold the Product that gets displayed
        /// </summary>
        [BindProperty]
        public Product _product { get; set; }
        
        /// <summary>
        /// Property used to hold the product service
        /// </summary>
        public IProductService _productService { get; set; }

        /// <summary>
        /// Dependency injection
        /// </summary>
        /// <param name="productService"></param>
        public ViewProductModel(IProductService productService) 
        { 
            _productService = productService;
        }

        /// <summary>
        /// method used to get the Product that needs to be displayed
        /// </summary>
        /// <param name="id"></param>
        public void OnGet(int id)
        {
            _product = _productService.GetProductById(id);
        }
    }
}

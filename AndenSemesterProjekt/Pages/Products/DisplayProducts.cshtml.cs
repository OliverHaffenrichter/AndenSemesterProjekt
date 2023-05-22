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
        /// products returns the amount of blog posts being displayed on the page
        /// </summary>
        public List<Product> products { get; set; } 
        /// <summary>
        /// _productService is a variable used to for dependency injection 
        /// </summary>
        public IProductService _productService;

      

        [BindProperty]
        public string Categories { get; set; }

        public DisplayProductModel(IProductService productService)
        {
            _productService = productService;
        }


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

        public IActionResult OnGetProductsByCat(string category)
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            products = _productService.GetProductByCategory(category);

            return Page();
        }
    }
    
}

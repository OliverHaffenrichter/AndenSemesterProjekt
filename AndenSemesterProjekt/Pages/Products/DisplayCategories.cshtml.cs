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
        public List<ProductCategoryList> Categories { get; set; }
        public IProductService _productService;

        public DisplayCategoriesModel(IProductService productService)
        {
            _productService = productService;
        }

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

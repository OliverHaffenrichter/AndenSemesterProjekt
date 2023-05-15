using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing.Printing;

namespace AndenSemesterProjekt.Pages.Products
{
    public class DisplayCategoriesModel : PageModel
    {

        public List<string> Categories { get; set; }
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

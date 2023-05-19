using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Products
{
    public class CreateProductModel : PageModel
    {

        private IProductService _productService { get; set; }
        [BindProperty]
        public Product Product { get; set; }

        [BindProperty]
        public string Information { get; set; }

        public CreateProductModel(IProductService productService) 
        { 
            _productService = productService;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            _productService.CreateProduct(Product);
            return RedirectToPage("DisplayProducts");
        }
    }
}

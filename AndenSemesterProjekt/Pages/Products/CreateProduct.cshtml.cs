using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Services;
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

        public async Task<IActionResult> OnPost()
        {
            //_productService.CreateProduct(string title, string description, double price, string category);
            await _productService.CreateProduct(Product.Title, Product.Description, Product.Price, Product.ProductCategories.Category);
            return RedirectToPage("DisplayProducts");
        }
    }
}

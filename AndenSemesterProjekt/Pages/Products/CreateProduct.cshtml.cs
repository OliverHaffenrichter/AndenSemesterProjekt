using AndenSemesterProjekt.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Products
{
    public class CreateProductModel : PageModel
    {

        private IProductService _productService { get; set; }
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public string Description { get; set; }
        [BindProperty]
        public double Price { get; set; }
        [BindProperty]
        public string Category { get; set; }

        public CreateProductModel(IProductService productService) 
        { 
            _productService = productService;
        }


        public void OnGet()
        {
        }
    }
}

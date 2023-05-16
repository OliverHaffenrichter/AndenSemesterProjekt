using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Products
{
    public class DeleteProductModel : PageModel
    {
        private IProductService _ProductService;

        public DeleteProductModel(IProductService productService)
        {
            _ProductService = productService;
        }

        [BindProperty]
        public Product product { get; set; }


        public IActionResult OnGet(int id)
        {
            product = _ProductService.GetProductById(id);
            if (product == null)
                return RedirectToPage("/NotFound");

            return Page();
        }

        public IActionResult OnPost()
        {
            Product deletedProduct = _ProductService.DeleteProduct(product.Id);
            if (deletedProduct == null)
                return RedirectToPage("/NotFound");

            return RedirectToPage("DisplayProducts");
        }
    }
}
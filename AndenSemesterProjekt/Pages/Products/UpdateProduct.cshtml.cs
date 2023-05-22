using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Products
{
    public class UpdateProductModel : PageModel
    {
        private IProductService _productService { get; set; }
        [BindProperty]
        public Product Product { get; set; }

        [BindProperty]
        public string Information { get; set; }

        public UpdateProductModel(IProductService productService)
        {
            _productService = productService;
        }
        public void OnGet(int id)
        {
            Product = _productService.GetProductById(id);
        }

        public IActionResult OnPost(int id, Product product)
        {
            _productService.UpdateProduct(id, product);
            return Redirect($"/Products/DisplayProducts?category={product.Category}&handler=ProductsByCat");
        }
    }
}

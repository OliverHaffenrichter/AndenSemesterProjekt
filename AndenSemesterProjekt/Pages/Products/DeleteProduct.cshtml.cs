using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Products
{
    public class DeleteProductModel : PageModel
    {
        /// <summary>
        /// Property used to contain the Product service
        /// </summary>
        private IProductService _ProductService;

        /// <summary>
        /// Dependency injection
        /// </summary>
        /// <param name="productService"></param>
        public DeleteProductModel(IProductService productService)
        {
            _ProductService = productService;
        }

        /// <summary>
        /// Property used to contain the object that gets deleted
        /// </summary>
        [BindProperty]
        public Product product { get; set; }

        /// <summary>
        /// Method that gets the object that needs to be deleted
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult OnGet(int id)
        {
            product = _ProductService.GetProductById(id);
            if (product == null)
                return RedirectToPage("/NotFound");

            return Page();
        }

        /// <summary>
        /// Method that deletes the object 
        /// </summary>
        /// <returns></returns>
        public IActionResult OnPost()
        {
            Product deletedProduct = _ProductService.DeleteProduct(product.Id);
            if (deletedProduct == null)
                return RedirectToPage("/NotFound");

            return RedirectToPage("/Products/DisplayProducts");
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Interfaces;

namespace AndenSemesterProjekt.Pages.Products
{
    public class ViewProductModel : PageModel
    {

        [BindProperty]
        public Product _product { get; set; }
        
        public IProductService _productService { get; set; }


        public ViewProductModel(IProductService productService) 
        { 
            _productService = productService;
        }


        public void OnGet(int id)
        {
            _product = _productService.GetProductById(id);

        }
    }
}

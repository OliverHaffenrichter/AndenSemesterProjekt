using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Products
{
    public class CreateProductModel : PageModel
    {
        public List<ProductCategoryList> Categories { get; set; }

        private IProductService _productService { get; set; }
        private DbProductService _dbProductService;
        [BindProperty]
        public Product Product { get; set; } = new Product();

        [BindProperty]
        public string Information { get; set; }

        public CreateProductModel(IProductService productService, DbProductService dbProductService) 
        { 
            _productService = productService;
            _dbProductService = dbProductService;
        }

        public void OnGet()
        {
            Categories = _productService.GetProductCategories();
        }

        public async Task<IActionResult> OnPost()
        {
            Categories = _dbProductService.GetProductCategories().Result;
            Product.ProductCategoryList.ProductCategory = Categories.FirstOrDefault(c => c.Id == Product.ProductCategoryList.Id).ProductCategory;
            Product.Description = Information;
            await _productService.CreateProduct(Product);
            return RedirectToPage("DisplayProducts");
        }
    }
}

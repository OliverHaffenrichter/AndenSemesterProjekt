using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Products
{
    public class UpdateProductModel : PageModel
    {
        public List<ProductCategoryList> Categories { get; set; }
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
            Categories = _productService.GetProductCategories();
            Product = _productService.GetProductById(id);
            Information = Product.Description;
        }

        public IActionResult OnPost(int id, Product product)
        {
            Categories = _productService.GetProductCategories();
            product.ProductCategoryList.ProductCategory = Categories.FirstOrDefault(c => c.Id == Product.ProductCategoryList.Id).ProductCategory;
            product.Description = Information;
            _productService.UpdateProduct(id, product);
            return RedirectToPage("DisplayProducts");
        }
    }
}

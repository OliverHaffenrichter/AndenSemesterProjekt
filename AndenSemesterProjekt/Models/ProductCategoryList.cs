using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndenSemesterProjekt.Models
{
    public class ProductCategoryList
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string ProductCategory { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();

        public ProductCategoryList(string category)
        {
            ProductCategory = category;
        }
        public ProductCategoryList(int id, string category)
        {
            Id = id;
            ProductCategory = category;
        }
        public ProductCategoryList()
        {

        }
    }
}

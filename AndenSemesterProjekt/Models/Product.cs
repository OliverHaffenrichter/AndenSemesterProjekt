using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace AndenSemesterProjekt.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        public static int NextInt { get; set; } = 0;
        [Required, MaxLength(50)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        public int ProductCategoryListId { get; set; }
        [Required]
        public ProductCategoryList ProductCategoryList { get; set; }

        public Product(string title, string description, ProductCategoryList category, double pris)
        {
            Title = title;
            Description = description;
            ProductCategoryList = category;
            Price = pris;
        }

        public Product()
        {

        }
    }
}

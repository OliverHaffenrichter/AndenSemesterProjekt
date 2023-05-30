using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace AndenSemesterProjekt.Models
{
    /// <summary>
    /// Class to contain the information about the products page.
    /// </summary>
    public class Product
    {
        [Required]
        public int Id { get; set; }
        public static int NextInt { get; set; } = 0;
        /// <summary>
        /// Property that holds the data for the title of each individual product
        /// </summary>
        [Required, MaxLength(50)]
        public string Title { get; set; }
        /// <summary>
        /// Description is a property used to hold the JSON string from the quil editor
        /// </summary>
        [Required]
        public string Description { get; set; }
        /// <summary>
        /// Property to hold the price of a product
        /// </summary>
        [Required]
        public double Price { get; set; }
        /// <summary>
        /// Navigation property for the ProductCategories
        /// </summary>
        public int ProductCategoryListId { get; set; }
        /// <summary>
        /// A property used to contain the ProductCategory object, which contains the category for the Product
        /// </summary>
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

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndenSemesterProjekt.Models
{
    /// <summary>
    /// This class contain the information for the productCategory due to how Entity framework (EF) works each table must be an object
    /// </summary>
    public class ProductCategoryList
    {
        [Required]
        public int Id { get; set; }
        /// <summary>
        /// The property that contains the data for the productCategory
        /// </summary>
        [Required]
        public string ProductCategory { get; set; }
        /// <summary>
        /// Navigation property to use to define the relationship between Product and ProductCategory
        /// </summary>
        public ICollection<Product> Products { get; set; } = new List<Product>();

        public ProductCategoryList(string category)
        {
            ProductCategory = category;
        }
        public ProductCategoryList()
        {

        }
    }
}

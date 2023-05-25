using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace AndenSemesterProjekt.Models
{
    public class Product
    {

        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public static int NextInt { get; set; } = 0;
        [Required, MaxLength(50)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public virtual ProductCategories ProductCategories { get; set; } = new ProductCategories();

        public Product(string title, string description, string category, double pris)
        {
            Title = title;
            Description = description;
            ProductCategories.Category = category;
            Price = pris;
        }

        public Product()
        {

        }
    }
}

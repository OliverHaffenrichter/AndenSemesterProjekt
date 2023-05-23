using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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
        public string Category { get; set; }

        public Product(string title, string description, string category, double pris)
        {
            Id = NextInt++;
            Title = title;
            Description = description;
            Category = category;
            Price = pris;
            
        }

        public Product()
        {

        }
    }
}

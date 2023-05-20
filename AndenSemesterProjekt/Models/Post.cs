using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndenSemesterProjekt.Models
{
    public class Post
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public static int NextInt { get; set; } = 0;
        [Required, StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string Information { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }

        public Post(string title,string information, DateTime creationDate)
        {
            Title = title;
            Information = information;
            CreationDate = creationDate;
        }

        public Post()
        {

        }

        public override string ToString()
        {
            return $"{Id}, {Title}, {Information}, {CreationDate}";
        }
    }
}

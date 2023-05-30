using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndenSemesterProjekt.Models
{
    /// <summary>
    /// This class contains all the information for the post object for the blog page.
    /// </summary>
    public class Post
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Property to hold the title of the post
        /// </summary>
        [Required, MaxLength(50)]
        public string Title { get; set; }
        /// <summary>
        /// Property to contain the JSON string from the quil editor
        /// </summary>
        [Required]
        public string Information { get; set; }
        /// <summary>
        /// Property to hold the creationdate which gets set the current Date and time on object creation
        /// </summary>
        [Required]
        public DateTime CreationDate { get; set; }

        public Post(string title,string information)
        {
            Title = title;
            Information = information;
            CreationDate = DateTime.Now;
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

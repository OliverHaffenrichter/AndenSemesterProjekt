namespace AndenSemesterProjekt.Models
{
    public class Post
    {
        public int Id { get; set; }
        public static int NextInt { get; set; } = 0;
        public string Information { get; set; }
        public string Category { get; set; }
        public DateTime CreationDate { get; set; }

        public Post(string information, string category, DateTime creationDate)
        {
            Id = NextInt++;
            Information = information;
            Category = category;
            CreationDate = creationDate;
        }

        public Post()
        {

        }
    }
}

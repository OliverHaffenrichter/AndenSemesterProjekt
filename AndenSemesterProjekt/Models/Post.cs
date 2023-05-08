namespace AndenSemesterProjekt.Models
{
    public class Post
    {
        public int Id { get; set; }
        public static int NextInt { get; set; } = 0;
        public string Title { get; set; }
        public string Information { get; set; }
        public string Category { get; set; }
        public DateTime CreationDate { get; set; }

        public Post(string title,string information, string category, DateTime creationDate)
        {
            Id = NextInt++;
            Title = title;
            Information = information;
            Category = category;
            CreationDate = creationDate;
        }

        public Post()
        {

        }
    }
}

namespace AndenSemesterProjekt.Models
{
    public class Post
    {
        public int Id { get; set; }
        public static int NextInt { get; set; } = 0;
        public string Title { get; set; }
        public string Information { get; set; }
        public DateTime CreationDate { get; set; }

        public Post(string title,string information, DateTime creationDate)
        {
            Id = NextInt++;
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

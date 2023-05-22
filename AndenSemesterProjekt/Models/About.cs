namespace AndenSemesterProjekt.Models
{
    public class About
    {
        public string Title { get; set; }
        public string Information { get; set; }

        public About(string title, string information)
        {
            Title = title;
            Information = information;
        }

        public About()
        {

        }

        public override string ToString()
        {
            return $"{{{nameof(Title)}={Title}, {nameof(Information)}={Information}}}";
        }
    }
}

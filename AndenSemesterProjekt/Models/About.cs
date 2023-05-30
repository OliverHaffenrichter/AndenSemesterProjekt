namespace AndenSemesterProjekt.Models
{
    /// <summary>
    /// this class is simple used to contain the information about about page
    /// </summary>
    public class About
    {
        /// <summary>
        /// Title contains the title for the about page
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Information contains the JSON string from the quil editor
        /// </summary>
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

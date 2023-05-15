namespace AndenSemesterProjekt.Models
{
    public class Product
    {

        public int Id { get; set; }
        public static int NextInt { get; set; } = 0;
        public string Title { get; set; }
        public string Description { get; set; }
        public double Pris { get; set; }
        public string Category { get; set; }

        public Product(string title, string description, string category, double pris)
        {
            Id = NextInt++;
            Title = title;
            Description = description;
            Category = category;
            Pris = pris;
            
        }

        public Product()
        {

        }
    }
}

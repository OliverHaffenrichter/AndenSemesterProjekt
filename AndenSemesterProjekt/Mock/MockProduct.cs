using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Mock
{
    public class MockProduct
    {

        static string loremIpsum20 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
        private static List<Product> products = new List<Product>()
        {
            new Product("title1",loremIpsum20, "cat1", 22),
            new Product("title2",loremIpsum20, "cat2", 22),
            new Product("title3",loremIpsum20, "cat3", 35),
            new Product("title4",loremIpsum20, "cat4", 55),
            new Product("title5",loremIpsum20, "cat5", 9999),
            new Product("title6",loremIpsum20, "cat6", 10820),
            new Product("title7",loremIpsum20, "cat7", 420),
            new Product("Unga Bunga Chimi Chanka", loremIpsum20, "cat2", 666),
        };

        public static List<Product> GetMockProduct() { return products; }

    }
}

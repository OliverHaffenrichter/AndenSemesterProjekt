using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Mock
{
    public class MockProduct
    {

        static string loremIpsum20 = "{\r\n    \"ops\": [\r\n        {\r\n            \"insert\": \"Nice header\"\r\n        },\r\n        {\r\n            \"attributes\": {\r\n                \"header\": 1\r\n            },\r\n            \"insert\": \"\\n\"\r\n        },\r\n        {\r\n            \"insert\": \"some nice text\\n\\na video\\n\"\r\n        },\r\n        {\r\n            \"insert\": {\r\n                \"video\": \"https://www.youtube.com/embed/LO0zKjr-R6Q?showinfo=0\"\r\n            }\r\n        },\r\n        {\r\n            \"insert\": \"\\nnice image\\n\"\r\n        },\r\n        {\r\n            \"insert\": {\r\n                \"image\": \"/data/Images/logo.png\"\r\n            }\r\n        },\r\n        {\r\n            \"insert\": \"\\n\"\r\n        }\r\n    ]\r\n}";
        private static List<Product> products = new List<Product>()
        {
            new Product("title1",loremIpsum20, new ProductCategories("cat1"), 22),
            new Product("title2",loremIpsum20, new ProductCategories("cat2"), 22),
            new Product("title3",loremIpsum20, new ProductCategories("cat3"), 35),
            new Product("title4",loremIpsum20, new ProductCategories("cat4"), 55),
            new Product("title5",loremIpsum20, new ProductCategories("cat5"), 9999),
            new Product("title6",loremIpsum20, new ProductCategories("cat6"), 10820),
            new Product("title7",loremIpsum20, new ProductCategories("cat7"), 420),
            new Product("Unga Bunga Chimi Chanka", loremIpsum20, new ProductCategories("cat2"), 666),
        };

        public static List<Product> GetMockProduct() { return products; }

    }
}

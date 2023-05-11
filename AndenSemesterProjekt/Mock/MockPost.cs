using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Mock
{
    public class MockPost
    {
        static string loremIpsum20 = "{\r\n    \"ops\": [\r\n        {\r\n            \"insert\": \"Nice header\"\r\n        },\r\n        {\r\n            \"attributes\": {\r\n                \"header\": 1\r\n            },\r\n            \"insert\": \"\\n\"\r\n        },\r\n        {\r\n            \"insert\": \"some nice text\\n\\na video\\n\"\r\n        },\r\n        {\r\n            \"insert\": {\r\n                \"video\": \"https://www.youtube.com/embed/LO0zKjr-R6Q?showinfo=0\"\r\n            }\r\n        },\r\n        {\r\n            \"insert\": \"\\nnice image\\n\"\r\n        },\r\n        {\r\n            \"insert\": {\r\n                \"image\": \"/data/Images/logo.png\"\r\n            }\r\n        },\r\n        {\r\n            \"insert\": \"\\n\"\r\n        }\r\n    ]\r\n}";
        private static List<Post> posts = new List<Post>()
        {
            new Post("title1",loremIpsum20, "cat1", DateTime.Now),
            new Post("title2",loremIpsum20, "cat2", DateTime.Now),
            new Post("title3",loremIpsum20, "cat3", DateTime.Now),
            new Post("title4",loremIpsum20, "cat4", DateTime.Now),
            new Post("title5",loremIpsum20, "cat5", DateTime.Now),
            new Post("title6",loremIpsum20, "cat6", DateTime.Now),
            new Post("title7",loremIpsum20, "cat7", DateTime.Now),
        };

        public static List<Post> GetMockPosts() { return posts; }
    }
}

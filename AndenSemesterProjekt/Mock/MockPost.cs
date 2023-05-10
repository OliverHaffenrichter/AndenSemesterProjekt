using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Mock
{
    public class MockPost
    {
        static string loremIpsum20 = "{\"ops\":[{\"insert\":\"BobsBurger\"},{\"attributes\":{\"header\":1},\"insert\":\"\\n\"},{\"insert\":\"aaaaaaaaah\\n\"}]}";
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

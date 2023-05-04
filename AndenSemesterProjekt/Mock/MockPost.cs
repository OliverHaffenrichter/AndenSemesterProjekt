using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Mock
{
    public class MockPost
    {
        private static List<Post> posts = new List<Post>()
        {
            new Post("info1", "cat1", DateTime.Now),
            new Post("info2", "cat2", DateTime.Now),
            new Post("info3", "cat3", DateTime.Now),
            new Post("info4", "cat4", DateTime.Now),
            new Post("info5", "cat5", DateTime.Now),
            new Post("info6", "cat6", DateTime.Now),
            new Post("info7", "cat7", DateTime.Now),
        };

        public static List<Post> GetMockPosts() { return posts; }
    }
}

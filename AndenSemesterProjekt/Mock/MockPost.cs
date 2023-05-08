using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Mock
{
    public class MockPost
    {
        private static List<Post> posts = new List<Post>()
        {
            new Post("title1","info1", "cat1", DateTime.Now),
            new Post("title2","info2", "cat2", DateTime.Now),
            new Post("title3","info3", "cat3", DateTime.Now),
            new Post("title4","info4", "cat4", DateTime.Now),
            new Post("title5","info5", "cat5", DateTime.Now),
            new Post("title6","info6", "cat6", DateTime.Now),
            new Post("title7","info7", "cat7", DateTime.Now),
        };

        public static List<Post> GetMockPosts() { return posts; }
    }
}

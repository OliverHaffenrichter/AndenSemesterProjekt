
namespace TestOfBlog
{
    [TestClass]
    public class UnitTestBlog
    {
        private List<Post> posts;
        private BlogService blogService;
        private string SearchString;

        [TestInitialize]
        void BeforeTest()
        {
            posts = new List<Post>()
            {
                new Post() { Title = "title1", Information="long text", CreationDate = DateTime.Now, Id=1 },
                new Post() { Title = "title2", Information="long text", CreationDate = DateTime.Now, Id=2 },
                new Post() { Title = "title3", Information="long text", CreationDate = DateTime.Now, Id=3 },
                new Post() { Title = "title4", Information="long text", CreationDate = DateTime.Now, Id=4 },
                new Post() { Title = "title1", Information="long text", CreationDate = DateTime.Now, Id=5 },
                new Post() { Title = "title2", Information="long text", CreationDate = DateTime.Now, Id=6 },
                new Post() { Title = "title3", Information="long text", CreationDate = DateTime.Now, Id=7 },
                new Post() { Title = "title4", Information="long text", CreationDate = DateTime.Now, Id=8 }

            };
        }

        [TestMethod]
        void TestSearchPost()
        {
            SearchString = "jbkncgfxgfcvhjklcxfzxgchjn";
            Assert.IsTrue(posts.Any(p => p.Title == SearchString));
        }
    }
}
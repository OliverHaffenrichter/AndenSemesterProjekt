
namespace MentalWellnessUnitTest
{
    [TestClass]
    public class UnitTestBlog
    {
        private List<Post> posts;
        private BlogService blogService = new BlogService();
        private string SearchString;

        [TestInitialize]
        public void BeforeTest()
        {
            posts = new List<Post>()
            {
                new Post() { Title = "title1", Information="long text", CreationDate = DateTime.Now, Id=1 },
                new Post() { Title = "title2", Information="long text", CreationDate = DateTime.Now, Id=2 },
                new Post() { Title = "title3", Information="long text", CreationDate = DateTime.Now, Id=3 },
                new Post() { Title = "title 4", Information="long text", CreationDate = DateTime.Now, Id=4 },
                new Post() { Title = "Title1", Information="long text", CreationDate = DateTime.Now, Id=5 },
                new Post() { Title = "Title2", Information="long text", CreationDate = DateTime.Now, Id=6 },
                new Post() { Title = "Title3", Information="long text", CreationDate = DateTime.Now, Id=7 },
                new Post() { Title = "Title4", Information="long text", CreationDate = DateTime.Now, Id=8 },
                new Post() { Title = "single", Information="long text", CreationDate = DateTime.Now, Id=9 }


            };
            blogService.posts = posts;
        }

        [TestMethod]
        public void TestSearchPostWrongString()
        {
            SearchString = "titli";
            Assert.IsFalse(blogService.GetAllBlogPostsByCriteria(SearchString).Count == 1);
        }
        
        [TestMethod]
        public void TestSearchPostRightString()
        {
            SearchString = "single";
            Assert.IsTrue(blogService.GetAllBlogPostsByCriteria(SearchString).Count == 1);
        }
        [TestMethod]
        public void TestSearchPostUppercase()
        {
            // make sure it's not uppercase sensetive
            SearchString = "title2";
            Assert.IsTrue(blogService.GetAllBlogPostsByCriteria(SearchString).Count == 2);
        }
        [TestMethod]
        public void TestSearchPostSpacing()
        {
            SearchString = "title 4";
            Assert.IsTrue(blogService.GetAllBlogPostsByCriteria(SearchString).Count == 2);

        }
    }
}
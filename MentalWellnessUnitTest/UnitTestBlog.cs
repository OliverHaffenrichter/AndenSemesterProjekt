
namespace MentalWellnessUnitTest
{
    [TestClass]
    public class UnitTestBlog
    {
        /// <summary>
        /// variable used for containign the posts.
        /// </summary>
        private List<Post> posts;
        /// <summary>
        /// variable used for holding the blogService
        /// </summary>
        private BlogService blogService = new BlogService();
        /// <summary>
        /// variable used to hold the string being searched for
        /// </summary>
        private string SearchString;

        /// <summary>
        /// Method used to declare variables before testing
        /// </summary>
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

        /// <summary>
        /// method used to see if Search method returns true if the string is incorrect
        /// </summary>
        [TestMethod]
        public void TestSearchPostWrongString()
        {
            SearchString = "titli";
            Assert.IsFalse(blogService.GetAllBlogPostsByCriteria(SearchString).Count >= 1);
        }
        
        /// <summary>
        /// Method used to see if the method return true if the string is correct in basic form
        /// </summary>
        [TestMethod]
        public void TestSearchPostRightString()
        {
            SearchString = "single";
            Assert.IsTrue(blogService.GetAllBlogPostsByCriteria(SearchString).Count == 1);
        }
        /// <summary>
        /// method used to test if the string is uppercase sensetive
        /// </summary>
        [TestMethod]
        public void TestSearchPostUppercase()
        {
            // make sure it's not uppercase sensetive
            SearchString = "title2";
            Assert.IsTrue(blogService.GetAllBlogPostsByCriteria(SearchString).Count == 2);
        }

        /// <summary>
        /// method used to test if the string is space sensetive
        /// </summary>
        [TestMethod]
        public void TestSearchPostSpacing()
        {
            SearchString = "title 4";
            Assert.IsTrue(blogService.GetAllBlogPostsByCriteria(SearchString).Count == 2);

        }
    }
}
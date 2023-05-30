using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Interfaces
{
    public interface IBlogService
    {
        /// <summary>
        /// Method used for creation new Posts for the blog
        /// </summary>
        /// <param name="title"></param>
        /// <param name="information"></param>
        /// <returns></returns>
        Task CreateBlogPost(string title, string information);
        /// <summary>
        /// Method used for deleting Posts from the blog
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Post DeleteBlogPost(int id);
        /// <summary>
        /// Method used to Update post from the blog
        /// </summary>
        /// <param name="post"></param>
        void UpdateBlogPost(Post post);
        /// <summary>
        /// Method used to get all Posts in the blog
        /// </summary>
        /// <returns></returns>
        List<Post> GetAllBlogPosts();
        /// <summary>
        /// method used to get All the posts in the blog based on a category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        List<Post> GetAllBlogPostsByCategory(string category);
        /// <summary>
        /// Method used to get all the posts in the blog based a search criteria
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        List<Post> GetAllBlogPostsByCriteria(string criteria);
        /// <summary>
        /// Method used to get all the posts in the blog based on creation year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        List<Post> GetAllBlogPostsByYear(int year);
        /// <summary>
        /// Method used to get the latest Posts from the blog
        /// </summary>
        /// <returns></returns>
        List<Post> GetRecentBlogPosts();
        /// <summary>
        /// Method used to get posts from the blog based on Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Post GetBlogPostById(int id);
    }
}

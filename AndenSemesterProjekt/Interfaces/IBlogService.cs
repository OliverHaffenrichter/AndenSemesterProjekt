using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Interfaces
{
    public interface IBlogService
    {
        Task CreateBlogPost(string title, string information);
        Post DeleteBlogPost(int id);
        void UpdateBlogPost(Post post);
        List<Post> GetAllBlogPosts();
        List<Post> GetAllBlogPostsByCategory(string category);
        List<Post> GetAllBlogPostsByCriteria(string criteria);
        List<Post> GetAllBlogPostsByYear(int year);
        List<Post> GetRecentBlogPosts();
        Post GetBlogPostById(int id);
    }
}

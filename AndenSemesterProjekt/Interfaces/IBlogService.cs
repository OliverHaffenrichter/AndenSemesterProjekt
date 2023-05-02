using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Interfaces
{
    public interface IBlogService
    {
        Post CreateBlogPost(string information);
        void deleteBlogPost(int id);
        void UpdateBlogPost(int id, Post post);
        List<Post> GetAllBlogPosts();
        List<Post> GetAllBlogPostsByCategory(string category);
        List<Post> GetAllBlogPostsByCriteria(string criteria);
        Post GetBlogPostById(int id);
    }
}

using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Services
{
    public class BlogService : IBlogService
    {
        public Post CreateBlogPost(string information)
        {
            throw new NotImplementedException();
        }

        //stor fed pik
        public void deleteBlogPost(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAllBlogPosts()
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAllBlogPostsByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAllBlogPostsByCriteria(string criteria)
        {
            throw new NotImplementedException();
        }

        public Post GetBlogPostById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlogPost(int id, Post post)
        {
            throw new NotImplementedException();
        }
    }
}

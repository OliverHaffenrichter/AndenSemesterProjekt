using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Services
{
    public class BlogService : IBlogService
    {
        private List<Post> posts = new List<Post>();
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 8;
        public Post CreateBlogPost(string information)
        {
            throw new NotImplementedException();
        }

        public void deleteBlogPost(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAllBlogPosts()
        {
            //List<Post> resultPosts = new List<Post>();
            //for (int i = PageSize*CurrentPage; i < (PageSize*CurrentPage) + PageSize; i++)
            //{
            //    resultPosts.Add(posts[i]);
            //}
            //return resultPosts;
            return posts.OrderBy(d => d.Id).Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();
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

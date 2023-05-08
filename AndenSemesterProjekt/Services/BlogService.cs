using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Mock;
using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Services
{
    public class BlogService : IBlogService
    {
        private List<Post> posts = new List<Post>();

        //public int CurrentPage { get; set; } = 1;
        //public int PageSize { get; set; } = 8;
        public BlogService()
        {
            posts = MockPost.GetMockPosts();
        }
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
            //return posts.OrderBy(d => d.Id).Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();
            return posts;
        }

        public List<Post> GetAllBlogPostsByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAllBlogPostsByCriteria(string criteria)
        {
            string searchString = criteria.Replace(" ", ""); ;
            if (criteria != null)
            {
                return posts.Where(c => c.Title.Contains(searchString.ToLower())
                || c.Category.Contains(searchString.ToLower())).ToList();
            }
            else
            {
                return posts;
            }
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

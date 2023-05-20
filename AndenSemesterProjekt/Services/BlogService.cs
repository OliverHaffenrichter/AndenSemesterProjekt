using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Mock;
using AndenSemesterProjekt.Models;
using System.Diagnostics;

namespace AndenSemesterProjekt.Services
{
    public class BlogService : IBlogService
    {
        private List<Post> posts = new List<Post>();

        //public int CurrentPage { get; set; } = 1;
        //public int PageSize { get; set; } = 8;
        private DbService _dbService;
        public BlogService(DbService dbService)
        {
            //posts = MockPost.GetMockPosts();
            _dbService = dbService;
            //_dbService.SavePosts(posts);
            posts = _dbService.GetPosts().Result.ToList();
        }
        public async Task CreateBlogPost(string title, string information)
        {
            Post Result = new Post(title, information, DateTime.Now);
            posts.Add(Result);
            _dbService.AddPost(Result);
        }

        public Post deleteBlogPost(int id)
        {
            foreach (Post post in posts)
            {
                if (post.Id == id)
                {
                    posts.Remove(post);
                    _dbService.DeletePost(post);
                    return post;
                }
            }
            return null;
        }

        public List<Post> GetAllBlogPosts()
        {
            //List<Post> resultPosts = new List<Post>();
            //for (int i = PageSize * CurrentPage; i < (PageSize * CurrentPage) + PageSize; i++)
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
                return posts.Where(c => c.Title.Contains(searchString.ToLower())).ToList();
            }
            else
            {
                return posts;
            }
        }

        public List<Post> GetRecentBlogPosts()
        {
            return posts.OrderBy(p => p.Id).Take(5).ToList();
        }

        public Post GetBlogPostById(int id)
        {
            foreach (Post post in posts)
            {
                if(post.Id == id)
                {
                    return post;
                }
            }
            return null;
            //return posts.Where(p => p.Id == id).First();
        }

        public void UpdateBlogPost(int id, Post post)
        {
            foreach (Post p in posts)
            {
                if (p.Id == id)
                {
                    p.Title = post.Title;
                    p.Information = post.Information;
                    _dbService.UpdatePost(id, post);
                    return;
                }
            }
        }

        public List<Post> GetAllBlogPostsByYear(int year)
        {
            return posts.Where(p => p.CreationDate.Year == year).Take(10).ToList();
        }
    }
}

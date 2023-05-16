using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.ViewModels
{
    public class BlogPostSideMenuModel
    {
        public List<Post> Posts { get; set; }

        /// <summary>
        /// NewestPosts returns the five newest posts from posts
        /// </summary>
        public List<Post> NewestPosts { get; set; }
        /// <summary>
        /// _blogService is a variable used to for dependency injection 
        /// </summary>
        public IBlogService _blogService;

        public int MinYear { get; set; } = 0;
        public int MaxYear { get; set; } = 0;

        public BlogPostSideMenuModel(IBlogService blogService)
        {
            _blogService = blogService;
        }


        private void DisplayYear()
        {
            MinYear = _blogService.GetAllBlogPosts().Min(p => p.CreationDate.Year);
            MaxYear = _blogService.GetAllBlogPosts().Max(p => p.CreationDate.Year);
        }
    }
}

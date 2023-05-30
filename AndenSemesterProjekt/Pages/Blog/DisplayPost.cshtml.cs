using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Blog
{
    public class DisplayPostModel : PageModel
    {
        /// <summary>
        /// Property used to contain the Current Post being displayed
        /// </summary>
        public Post Post { get; set; }

        /// <summary>
        /// NewestPosts returns the five newest posts from posts
        /// </summary>
        public List<Post> NewestPosts { get; set; }
        /// <summary>
        /// _blogService is a variable used to for dependency injection 
        /// </summary>
        public IBlogService _blogService;

        /// <summary>
        /// Property used to hold the oldest creationdate
        /// </summary>
        public int MinYear { get; set; } = 0;
        /// <summary>
        /// Property used to hold the newest creationdate
        /// </summary>
        public int MaxYear { get; set; } = 0;

        /// <summary>
        /// Dependency injection
        /// </summary>
        /// <param name="blogService"></param>
        public DisplayPostModel(IBlogService blogService)
        {
            _blogService = blogService;
        }

        /// <summary>
        /// Method used to display the current Post by id
        /// </summary>
        /// <param name="id"></param>
        public void OnGet(int id)
        {
            NewestPosts = _blogService.GetRecentBlogPosts();
            Post = _blogService.GetBlogPostById(id);
            DisplayYear();
        }

        /// <summary>
        /// Helper method used to set MinYear and MaxYear
        /// </summary>
        private void DisplayYear()
        {
            MinYear = _blogService.GetAllBlogPosts().Min(p => p.CreationDate.Year);
            MaxYear = _blogService.GetAllBlogPosts().Max(p => p.CreationDate.Year);
        }
    }
}

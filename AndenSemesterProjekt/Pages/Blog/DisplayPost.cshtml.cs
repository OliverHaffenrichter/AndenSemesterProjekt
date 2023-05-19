using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Blog
{
    public class DisplayPostModel : PageModel
    {
        public Post Post { get; set; }

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

        public DisplayPostModel(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public void OnGet(int id)
        {
            NewestPosts = _blogService.GetRecentBlogPosts();
            Post = _blogService.GetBlogPostById(id);
            DisplayYear();
        }

        private void DisplayYear()
        {
            MinYear = _blogService.GetAllBlogPosts().Min(p => p.CreationDate.Year);
            MaxYear = _blogService.GetAllBlogPosts().Max(p => p.CreationDate.Year);
        }
    }
}

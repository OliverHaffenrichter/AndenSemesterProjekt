using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Blog
{
    public class UpdatePostModel : PageModel
    {
        public int SelectedPost { get; set; }
        public List<Post> Posts { get; set; }
        /// <summary>
        /// simple variable used to contain a Post Object
        /// </summary>
        [BindProperty]
        public Post Post { get; set; }
        /// <summary>
        /// a variable for containing the information from the quill editor
        /// </summary>
        [BindProperty]
        public string Information { get; set; }

        /// <summary>
        /// variable used for dependency inject for the BlogService
        /// </summary>
        private IBlogService _blogService;

        public UpdatePostModel(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public void OnGet(int id)
        {
            Posts = _blogService.GetAllBlogPosts();
            Post = Posts.Where(p => p.Id == id).First();
            Information = Post.Information;
        }

        public IActionResult OnPost(int id)
        {
            Post.Information = Information;
            _blogService.UpdateBlogPost(id, Post);
            return RedirectToPage("DisplayBlog");
        }
    }
}
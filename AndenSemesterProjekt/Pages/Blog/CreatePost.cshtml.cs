using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Blog
{
    public class CreatePostModel : PageModel
    {
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

        /// <summary>
        /// dependency injection
        /// </summary>
        /// <param name="blogService"></param>
        public CreatePostModel(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public void OnGet()
        {
        }

        /// <summary>
        /// OnPost CreatePost
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPost()
        {
            await _blogService.CreateBlogPost(Post.Title, Information, Post.Category);
            return RedirectToPage("DisplayBlog");
        }
    }
}

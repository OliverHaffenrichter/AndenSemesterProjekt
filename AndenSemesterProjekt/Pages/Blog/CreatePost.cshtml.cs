using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Blog
{
    public class CreatePostModel : PageModel
    {
        /// <summary>
        /// Property used to contain a Post Object
        /// </summary>
        [BindProperty]
        public Post Post { get; set; }
        /// <summary>
        /// Property used for containing the information from the quill editor
        /// </summary>
        [BindProperty]
        public string Information { get; set; }

        /// <summary>
        /// Property used for dependency inject for the BlogService
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
        /// Function that creates the new BlogPost
        /// </summary>
        /// <returns>RedirectToPage("DisplayBlog")</returns>
        public async Task<IActionResult> OnPost()
        {
            await _blogService.CreateBlogPost(Post.Title, Information);
            return RedirectToPage("DisplayBlog");
        }
    }
}

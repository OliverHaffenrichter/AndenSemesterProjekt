using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Blog
{
    public class UpdatePostModel : PageModel
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

        public UpdatePostModel(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public void OnGet(int id)
        {
            Post = _blogService.GetBlogPostById(id);
            Information = Post.Information;
        }

        public IActionResult OnPost(int id)
        {
            ModelState.Remove("Post.Information");
            if (!ModelState.IsValid)
            {
                //var errors = ModelState
                //.Where(x => x.Value.Errors.Count > 0)
                //.Select(x => new { x.Key, x.Value.Errors })
                //.ToArray();
                return Page();
            }
            Post.Id = id;
            Post.Information = Information;
            _blogService.UpdateBlogPost(Post);
            return RedirectToPage("DisplayBlog");
        }
    }
}
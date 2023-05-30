using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Blog
{
    public class UpdatePostModel : PageModel
    {
        /// <summary>
        /// Property used to contain a Post Object being updated to
        /// </summary>
        [BindProperty]
        public Post Post { get; set; }
        /// <summary>
        /// Property for containing the information from the quill editor
        /// </summary>
        [BindProperty]
        public string Information { get; set; }

        /// <summary>
        /// variable used for dependency injection for the BlogService
        /// </summary>
        private IBlogService _blogService;

        public UpdatePostModel(IBlogService blogService)
        {
            _blogService = blogService;
        }
        /// <summary>
        /// Method used to get the Post that needs to be updated
        /// </summary>
        /// <param name="id"></param>
        public void OnGet(int id)
        {
            Post = _blogService.GetBlogPostById(id);
            Information = Post.Information;
        }

        /// <summary>
        /// method used to Update the selected post
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
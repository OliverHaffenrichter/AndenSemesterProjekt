using AndenSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Interfaces;

namespace AndenSemesterProjekt.Pages.Blog
{
    public class DeletePageModel : PageModel
    {
        /// <summary>
        /// Property used for dependency injection and to contain the blogService
        /// </summary>
        private IBlogService _BlogService;

        /// <summary>
        /// Dependency injection
        /// </summary>
        /// <param name="blogService"></param>
        public DeletePageModel(IBlogService blogService)
        {
            _BlogService = blogService;
        }

        /// <summary>
        /// Property used to containt the Post object
        /// </summary>
        [BindProperty]
        public Post post { get; set; }


        /// <summary>
        /// In order to delete an object we to get the object we wish to delete first
        /// This function therefore does that
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult OnGet(int id)
        {
            post = _BlogService.GetBlogPostById(id);
            if (post == null)
                return RedirectToPage("/NotFound");

            return Page();
        }

        /// <summary>
        /// Deletes the selected Post object
        /// </summary>
        /// <returns></returns>
        public IActionResult OnPost()
        {
            Post deletedBlog = _BlogService.DeleteBlogPost(post.Id);
            if (deletedBlog == null)
                return RedirectToPage("/NotFound");

            return RedirectToPage("DisplayBlog");
        }
    }
}
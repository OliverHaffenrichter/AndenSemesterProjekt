using AndenSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Interfaces;

namespace AndenSemesterProjekt.Pages.Blog
{
    public class DeletePageModel : PageModel
    {
        private IBlogService _BlogService;

        public DeletePageModel(IBlogService blogService)
        {
            _BlogService = blogService;
        }

        [BindProperty]
        public Post post { get; set; }


        public IActionResult OnGet(int id)
        {
            post = _BlogService.GetBlogPostById(id);
            if (post == null)
                return RedirectToPage("/NotFound");

            return Page();
        }

        public IActionResult OnPost()
        {
            Post deletedBlog = _BlogService.deleteBlogPost(post.Id);
            if (deletedBlog == null)
                return RedirectToPage("/NotFound");

            return RedirectToPage("DisplayBlog");
        }
    }
}
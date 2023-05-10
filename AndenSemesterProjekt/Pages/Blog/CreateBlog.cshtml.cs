using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Blog
{
    public class CreateBlogModel : PageModel
    {
        [BindProperty]
        public Post Post { get; set; }
        [BindProperty]
        public string Information { get; set; }

        private IBlogService _blogService;

        public CreateBlogModel(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            await _blogService.CreateBlogPost(Post.Title, Information, Post.Category);
            return RedirectToPage("DisplayBlog");
        }
    }
}

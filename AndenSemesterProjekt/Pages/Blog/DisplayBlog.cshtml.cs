using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace AndenSemesterProjekt.Pages.Blog
{
    public class DisplayBlogModel : PageModel
    {
        private int _blogSize = 0;

        public List<Post> Posts { get; set; }
        public IBlogService _blogService;
        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; } = 3;
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(BlogSize, PageSize));
        public int BlogSize { get { return _blogService.GetAllBlogPosts().Count(); } }

        public DisplayBlogModel(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult OnGet(int currentPage)
        {
            CurrentPage = currentPage;
            Posts = _blogService.GetAllBlogPosts()
                .OrderBy(p => p.Id)
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();
            return Page();
        }

        public int GoUpPage()
        {
            if (CurrentPage + 1 < TotalPages)
                return ++CurrentPage;
            else
                return CurrentPage;
        }

        public int GoDownPage()
        {
            if (CurrentPage - 1 > 0)
                return --CurrentPage;
            else
                return CurrentPage;
        }
    }
}

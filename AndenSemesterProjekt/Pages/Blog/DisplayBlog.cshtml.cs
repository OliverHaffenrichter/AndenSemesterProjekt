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
        /// <summary>
        /// Posts returns the amount of blog posts being displayed on the page
        /// </summary>
        public List<Post> Posts { get; set; }
        /// <summary>
        /// _blogService is a variable used to for dependency injection 
        /// </summary>
        public IBlogService _blogService;
        
        /// <summary>
        /// CurrentPage a variable containing the current page the user is on
        /// BindProperty(SupportsGet) is set to true so that we can store the data between page loads
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; }

        /// <summary>
        /// Pagesize is a variable containing the size of the each page for the pagination
        /// </summary>
        public int PageSize { get; } = 3;
        /// <summary>
        /// TotalPages is a variable containing the total amount of pages for the pagination
        /// </summary>
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(BlogSize, PageSize));
        /// <summary>
        /// BlogSize is a variable containing total amount of blog posts
        /// </summary>
        public int BlogSize { get { return _blogService.GetAllBlogPosts().Count(); } }

        /// <summary>
        /// Creates a dependecny injection for _blogService using the interface IBlogService
        /// </summary>
        /// <param name="blogService"></param>
        public DisplayBlogModel(IBlogService blogService)
        {
            _blogService = blogService;
        }

        /// <summary>
        /// OnGet(int currentPage) sets the currenpage = to route-id and gets the page equal to that route-id
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns>returns page()</returns>
        public IActionResult OnGet(int currentPage)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            CurrentPage = currentPage;
            Posts = _blogService.GetAllBlogPosts()
                .OrderBy(p => p.Id)
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();
            return Page();
        }
    }
}

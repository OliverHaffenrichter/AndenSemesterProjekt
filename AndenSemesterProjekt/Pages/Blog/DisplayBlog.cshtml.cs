using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using System.Security.Cryptography;

namespace AndenSemesterProjekt.Pages.Blog
{
    public class DisplayBlogModel : PageModel
    {
        /// <summary>
        /// Posts returns the amount of blog posts being displayed on the page
        /// </summary>
        public List<Post> Posts { get; set; }

        /// <summary>
        /// NewestPosts returns the five newest posts from posts
        /// </summary>
        public List<Post> NewestPosts { get; set; }
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

        public int MinYear { get; set; } = 0;
        public int MaxYear { get; set; } = 0;

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
        public int BlogSize { get; set; }

        /// <summary>
        /// Criteria is a variable used to contain the searchstring
        /// </summary>
        [BindProperty]
        public string Criteria { get; set; }

        [BindProperty]
        public int Year { get; set; }

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
            NewestPosts = _blogService.GetRecentBlogPosts();
            CurrentPage = currentPage;
            BlogSize = _blogService.GetAllBlogPosts().Count;
            Posts = _blogService.GetAllBlogPosts()
                .OrderBy(p => p.Id)
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();
            DisplayYear();
            return Page();
        }

        public IActionResult OnGetBlogByYear(int year, int currentPage)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            CurrentPage = currentPage;
            Year = year;
            NewestPosts = _blogService.GetRecentBlogPosts();
            DisplayYear();
            BlogSize = _blogService.GetAllBlogPostsByYear(Year).Count;
            Posts = _blogService.GetAllBlogPostsByYear(Year)
                .OrderBy(p => p.Id)
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();
            return Page();
        }

        public IActionResult OnGetCriteria(string SearchCriteria, int currentPage)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            CurrentPage = currentPage;
            NewestPosts = _blogService.GetRecentBlogPosts();
            DisplayYear();
            Criteria = SearchCriteria;
            BlogSize = _blogService.GetAllBlogPostsByCriteria(SearchCriteria).Count;
            Posts = _blogService.GetAllBlogPostsByCriteria(SearchCriteria)
                .OrderBy(p => p.Id)
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();
            return Page();
        }


        /// <summary>
        /// OnpostCriteria is the method that gets called on search attempt
        /// </summary>
        /// <param name="Criteria"></param>
        /// <returns></returns>
        public IActionResult OnPostCriteria(string Criteria, int currentPage)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage("DisplayBlog", new { currentPage = 1.ToString() });
            }
            CurrentPage = currentPage;
            NewestPosts = _blogService.GetRecentBlogPosts();
            DisplayYear();
            BlogSize = _blogService.GetAllBlogPostsByCriteria(Criteria).Count;
            Posts = _blogService.GetAllBlogPostsByCriteria(Criteria)
                .OrderBy(p => p.Id)
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();
            return Redirect($"/Blog/DisplayBlog?SearchCriteria={Criteria}&currentPage={currentPage}&handler=Criteria");
        }

        private void DisplayYear()
        {
            MinYear = _blogService.GetAllBlogPosts().Min(p => p.CreationDate.Year);
            MaxYear = _blogService.GetAllBlogPosts().Max(p => p.CreationDate.Year);
        }

    }
}

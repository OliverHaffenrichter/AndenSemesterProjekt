using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;
using System.Reflection;

namespace AndenSemesterProjekt.Pages.About
{
    public class UpdateAboutModel : PageModel
    {
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public string Information { get; set; }


        public void OnGet()
        {
            //Title = About.Title;
            //Information = About.Information;
        }
    }
}

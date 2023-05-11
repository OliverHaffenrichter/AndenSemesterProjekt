using Microsoft.AspNetCore.Mvc;

namespace AndenSemesterProjekt
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

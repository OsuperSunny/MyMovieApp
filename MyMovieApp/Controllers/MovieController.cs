using Microsoft.AspNetCore.Mvc;

namespace MyMovieApp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

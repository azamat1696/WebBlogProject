using Microsoft.AspNetCore.Mvc;

namespace WebBlogProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public IActionResult Index()
        {
            return View();
        }
    }
}

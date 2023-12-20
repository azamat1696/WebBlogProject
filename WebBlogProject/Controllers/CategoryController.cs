using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebBlogProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager( new EfCategoryRepository());

        // GET: CategoryController
        public IActionResult Index()
        {
            var values = cm.GetAllCategories();
            return View(values);
        }
    }
}

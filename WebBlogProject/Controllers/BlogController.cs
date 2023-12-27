using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebBlogProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = _blogManager.GetBlogsWithCategory();
            return View(values);
        }
        public IActionResult BlogDetails(int id)
        {
            var value = _blogManager.GetBlogById(id);
            return View(value);
        }
    }
}

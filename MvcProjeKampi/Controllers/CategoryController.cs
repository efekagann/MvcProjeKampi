using BusinessLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetAllBl();
            return View(categoryvalues);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            cm.CategoryAddBl(p);
            return RedirectToAction("GetCategoryList");
        }
    }
}

using BusinessLayer;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
    }
}

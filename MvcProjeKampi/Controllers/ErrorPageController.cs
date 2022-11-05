using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ErrorPageController : Controller
    {
        public ActionResult Page403()
        {
            Response.StatusCode = 403;
            return View();
        }

        public ActionResult Page404()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}

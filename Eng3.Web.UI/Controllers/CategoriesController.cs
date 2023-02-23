using Microsoft.AspNetCore.Mvc;

namespace Eng3.Web.UI.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

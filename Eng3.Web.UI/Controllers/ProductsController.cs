using Microsoft.AspNetCore.Mvc;

namespace Eng3.Web.UI.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

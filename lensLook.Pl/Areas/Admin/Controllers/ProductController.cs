using Microsoft.AspNetCore.Mvc;

namespace lensLook.Pl.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

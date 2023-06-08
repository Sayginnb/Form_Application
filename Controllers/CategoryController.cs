using Microsoft.AspNetCore.Mvc;

namespace Form_Application.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

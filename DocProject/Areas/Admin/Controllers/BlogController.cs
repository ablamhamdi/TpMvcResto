using Microsoft.AspNetCore.Mvc;

namespace DocProject.Areas.Admin.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Article()
        {
            return View();
        }
    }
}

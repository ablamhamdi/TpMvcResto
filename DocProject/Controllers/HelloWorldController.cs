using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DocProject.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome(int num,string str="str")
        {
            return HtmlEncoder.Default.Encode($"the Num is {num} and The String is {str}");
        }
    }
}

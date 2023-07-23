using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace E.sunbank0721.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

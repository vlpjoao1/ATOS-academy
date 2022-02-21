using Microsoft.AspNetCore.Mvc;

namespace ExDataTypes.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

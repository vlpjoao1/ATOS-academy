using Microsoft.AspNetCore.Mvc;

namespace ExGymManage.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}

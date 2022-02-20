using Microsoft.AspNetCore.Mvc;

namespace ExGymManage.Web.Controllers
{
    public class AttendanceController : Controller
    {
        //GET: /Attendance/MemberIn/
        public IActionResult MemberIn()
        {
            return View();
        }
        //GET: /Attendance/MemberOut/
        public IActionResult MemberOut()
        {
            return View();
        }
    }
}

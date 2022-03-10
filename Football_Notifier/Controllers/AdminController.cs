using Microsoft.AspNetCore.Mvc;

namespace Football_Notifier.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }
    }
}

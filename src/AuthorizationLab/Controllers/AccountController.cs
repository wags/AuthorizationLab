using Microsoft.AspNetCore.Mvc;

namespace AuthorizationLab.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Forbidden()
        {
            return View();
        }
    }
}

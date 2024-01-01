using Microsoft.AspNetCore.Mvc;

namespace GymSpot.Controllers.Login
{
    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [Route("/submit-login")]
        public IActionResult SubmitLogin(string? loginCredentials)
        {
            if (loginCredentials == null)
            {
                return RedirectToAction("Index", "Login");
            }
            if (loginCredentials == "PT")
            {
                return RedirectToAction("Index", "Home", new { area = "PT" });
            }
            if (loginCredentials == "Client")
            {
                return RedirectToAction("Index", "Home", new { area = "Client" });
            }
            return RedirectToAction("Index", "Login");

        }
    }
}

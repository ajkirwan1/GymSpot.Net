using GymSpot.Areas.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymSpot.Areas.Client.Controllers
{
    [Area("Client")]
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AccountDetails()
        {
            UserModel user = new UserModel()
            {
                Name = "Adam Kirwan",
                DateofBirth = DateTime.Now,
                AccountPassword = "Password123",
                Address = "Some Address",
                EmailAddress = "Adam@123",
                Gender = Gender.Male


            };
            return View(user);
        }
    }
}

using GymSpot.Areas.Client.Data;
using GymSpot.Areas.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymSpot.Areas.Client.Controllers
{
    [Area("Client")]
    public class AccountDetailsController : Controller
    {
        public IActionResult Index()
        {
            MockUserData MockClientDetails = new MockUserData();

            UserModel userModel = MockClientDetails.GetUserModel();
            return View(userModel);
        }
    }
}

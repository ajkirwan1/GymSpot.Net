using GymSpot.Areas.Client.Models;
using GymSpot.Areas.Client.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GymSpot.Areas.Client.Controllers
{
    [Area("Client")]
    public class AccountDetailsController : Controller
    {
        private readonly IUserRepository _userRepository;

        public AccountDetailsController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            UserModel user = _userRepository.GetUser();

            return View(user);
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            UserModel user = _userRepository.GetUser();

            if (user == null)
            {
                return NotFound();
            }
            return View(user);


        }

        [HttpPost]
        public IActionResult Edit(UserModel user)
        {

            _userRepository.Update(user);
            return RedirectToAction("Index");


        }

    }
}

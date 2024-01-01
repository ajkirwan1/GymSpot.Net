using GymSpot.Areas.PT.Models;
using GymSpot.Areas.PT.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace GymSpot.Areas.PT.Controllers
{
    [Area("PT")]
    public class HomeController : Controller
    {
        private readonly IDiaryService _diaryService;

        public HomeController(IDiaryService diaryService)
        {
            _diaryService = diaryService;
        }

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
        public IActionResult GetClients()
        {

            UserModel clientObj = new UserModel()
            {
                Name = "Adam Kirwan",
                DateofBirth = DateTime.Now,
                AccountPassword = "Password123",
                Address = "Some Address",
                EmailAddress = "Adam@123",
                Gender = Gender.Male
            };

            return View(clientObj);
        }
        [Route("/client-list")]
        public IActionResult LoadClients()
        {
            UserModel clientObj = new UserModel()
            {
                Name = "Adam Kirwan",
                DateofBirth = DateTime.Now,
                AccountPassword = "Password123",
                Address = "Some Address",
                EmailAddress = "Adam@123",
                Gender = Gender.Male
            };
            return ViewComponent("Clients", new { client = clientObj });
        }
        public IActionResult Diary(string searchBy, string searchString)
        {

            ViewBag.SearchFields = new Dictionary<string, string>()
            {
                { nameof(DiaryModel.Client), "Name" },
                { nameof(DiaryModel.Date), "Date" },
                { nameof(DiaryModel.Details), "Details" }
            };

            List<DiaryModel> diaryData = _diaryService.GetFilteredDiaryModels(searchBy, searchString);

            ViewBag.SearchBy = searchBy;
            ViewBag.SearchString = searchString;

            // ViewBag.Diary = diaryData;
            return View(diaryData);
        }



    }
}

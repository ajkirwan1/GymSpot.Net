using GymSpot.Areas.Client.ServiceContracts;
using GymSpot.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymSpot.Areas.Client.Controllers
{
    [Area("Client")]
    public class ExerciseItemController : Controller
    {
        private readonly IExerciseItemService _exerciseItemService;

        public ExerciseItemController(IExerciseItemService exerciseItemService)
        {
            _exerciseItemService = exerciseItemService;
        }

        public IActionResult Index()
        {

            List<ExerciseItem> exerciseItems = _exerciseItemService.GetAllExerciseItems();

            return View(exerciseItems);
        }

        public IActionResult AllExerciseItems()
        {
            return View();
        }

        public IActionResult CreateExercise()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExercise(ExerciseItem exerciseItem)
        {
            return View();
        }

    }
}

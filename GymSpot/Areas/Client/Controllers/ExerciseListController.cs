using GymSpot.Areas.Client.ServiceContracts;
using GymSpot.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymSpot.Areas.Client.Controllers
{
    [Area("Client")]
    public class ExerciseListController : Controller
    {
        private readonly IExerciseListService _exerciseListService;

        public ExerciseListController(IExerciseListService exerciseListService)
        {
            _exerciseListService = exerciseListService;
        }
        public IActionResult Index()
        {

            List<ExerciseList> exerciseList = _exerciseListService.GetAllExerciseLists();


            return View(exerciseList);
        }

        public IActionResult CreateExerciseList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExerciseList(ExerciseList exerciseList)
        {
            return View();
        }

    }
}

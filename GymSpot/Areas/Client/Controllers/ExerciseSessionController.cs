using GymSpot.Areas.Client.ServiceContracts;
using GymSpot.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymSpot.Areas.Client.Controllers
{
    [Area("Client")]
    public class ExerciseSessionController : Controller
    {
        private readonly IExerciseSessionService _exerciseSessionService;

        public ExerciseSessionController(IExerciseSessionService exerciseSessionService)
        {
            _exerciseSessionService = exerciseSessionService;
        }


        public IActionResult Index()
        {
            List<ExerciseSession> exerciseSessions = _exerciseSessionService.GetAllExerciseSessions();

            return View(exerciseSessions);

        }

        public IActionResult CreateExerciseSession()
        {
            return View();
        }



    }
}

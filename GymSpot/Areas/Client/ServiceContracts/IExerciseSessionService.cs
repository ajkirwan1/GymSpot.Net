using GymSpot.Models;

namespace GymSpot.Areas.Client.ServiceContracts
{
    public interface IExerciseSessionService
    {
        public List<ExerciseSession> GetAllExerciseSessions();

        public ExerciseSession GetExerciseSession(int id);
    }
}

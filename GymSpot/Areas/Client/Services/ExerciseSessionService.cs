using GymSpot.Areas.Client.ServiceContracts;
using GymSpot.Data.MockData;
using GymSpot.Models;

namespace GymSpot.Areas.Client.Services
{
    public class ExerciseSessionService : IExerciseSessionService
    {
        public List<ExerciseSession> GetAllExerciseSessions()
        {
            var _mockExerciseSessionData = new MockExerciseSessionData();

            List<ExerciseSession> exerciseSessionList = _mockExerciseSessionData.GetExerciseSessions();

            return exerciseSessionList;
        }

        public ExerciseSession GetExerciseSession(int id)
        {
            throw new NotImplementedException();
        }
    }
}

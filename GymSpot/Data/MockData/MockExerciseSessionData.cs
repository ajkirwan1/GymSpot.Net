using GymSpot.Models;

namespace GymSpot.Data.MockData
{
    public class MockExerciseSessionData
    {

        private readonly List<ExerciseSession> _exerciseSessionList;
        public MockExerciseSessionData()
        {
            _exerciseSessionList = new List<ExerciseSession>()
            {
                new ExerciseSession()
                {
                    ExerciseSessionId = 1,
                    ExerciselistId = 1,
                    Name = "Test",
                },
                new ExerciseSession() {
                    ExerciseSessionId = 2,
                    ExerciselistId = 3,
                    Name = "Testt",
                },
                new ExerciseSession() {
                    ExerciseSessionId = 3,
                    ExerciselistId = 1000,
                    Name = "REEECCCKKKTTT",
                },
            };

        }

        public List<ExerciseSession> GetExerciseSessions()
        {
            return _exerciseSessionList;
        }

    }
}

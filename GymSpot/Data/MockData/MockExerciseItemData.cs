using GymSpot.Models;

namespace GymSpot.Data.MockData
{
    public class MockExerciseItemData
    {

        private readonly List<ExerciseItem> _exerciseItems;

        public MockExerciseItemData()
        {
            _exerciseItems = new List<ExerciseItem>()
            {
                new ExerciseItem { ExerciseItemId = 1, Name = "Bench Press"},
                new ExerciseItem { ExerciseItemId = 2, Name = "Squat"},
                new ExerciseItem { ExerciseItemId = 3, Name = "Chin-Up"},
                new ExerciseItem { ExerciseItemId = 4, Name = "Dumbbell Curl"}
            };
        }

        public List<ExerciseItem> GetExerciseItems()
        {
            return _exerciseItems;
        }


    }
}

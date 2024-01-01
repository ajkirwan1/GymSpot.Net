using GymSpot.Models;

namespace GymSpot.Data.MockData
{
    public class MockExerciseListData
    {
        private readonly List<ExerciseList> _exerciseListList;

        public MockExerciseListData()
        {
            _exerciseListList = new List<ExerciseList>()
            {
                new ExerciseList()
                {
                    ExerciselistId = 1,
                    Name = "Test1",
                    ListOfExercises = new List<ExerciseItem> { new ExerciseItem() { ExerciseItemId = 1, Name = "Bench Press" }, new ExerciseItem() { ExerciseItemId = 2, Name = "Jack Press" } }
                },
                new ExerciseList()
                {
                    ExerciselistId = 2,
                    Name = "Test2",
                    ListOfExercises = new List<ExerciseItem> { new ExerciseItem() { ExerciseItemId = 4, Name = "Bench head" }, new ExerciseItem() { ExerciseItemId = 52, Name = "Jack head" } }
                }
            };
        }

        public List<ExerciseList> GetExerciseLists()
        {
            return _exerciseListList;
        }

    }
}
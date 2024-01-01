using GymSpot.Areas.Client.ServiceContracts;
using GymSpot.Data.MockData;
using GymSpot.Models;

namespace GymSpot.Areas.Client.Services
{
    public class ExerciseListService : IExerciseListService
    {
        public List<ExerciseList> GetAllExerciseLists()
        {
            var _mockExerciseListData = new MockExerciseListData();

            List<ExerciseList> exerciseItemList = _mockExerciseListData.GetExerciseLists();

            return exerciseItemList;
        }

        public ExerciseList GetExerciseList(int id)
        {
            throw new NotImplementedException();
        }
    }
}

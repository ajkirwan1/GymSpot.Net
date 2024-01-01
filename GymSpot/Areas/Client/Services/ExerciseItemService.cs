using GymSpot.Areas.Client.ServiceContracts;
using GymSpot.Data.MockData;
using GymSpot.Models;

namespace GymSpot.Areas.Client.Services
{
    public class ExerciseItemService : IExerciseItemService
    {
        // private readonly MockExerciseItemData _mockExerciseItemData;

        public ExerciseItemService()
        {
            // _mockExerciseItemData = mockExerciseItemData;
        }
        public List<ExerciseItem> GetAllExerciseItems()
        {
            var _mockExerciseItemData = new MockExerciseItemData();

            List<ExerciseItem> exerciseItemList = _mockExerciseItemData.GetExerciseItems();

            return exerciseItemList;
        }

        public ExerciseItem GetExerciseItem(int id)
        {
            var _mockExerciseItemData = new MockExerciseItemData();

            List<ExerciseItem> exerciseItemList = _mockExerciseItemData.GetExerciseItems();
            var item = exerciseItemList.FirstOrDefault(x => x.ExerciseItemId == id);

            if (item == null)
            {
                return null;
            }
            return item;
        }
    }
}

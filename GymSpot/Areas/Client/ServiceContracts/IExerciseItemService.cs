using GymSpot.Models;

namespace GymSpot.Areas.Client.ServiceContracts
{
    public interface IExerciseItemService
    {

        public List<ExerciseItem> GetAllExerciseItems();

        public ExerciseItem GetExerciseItem(int id);
    }
}

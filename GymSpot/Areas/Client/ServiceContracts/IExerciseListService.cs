using GymSpot.Models;

namespace GymSpot.Areas.Client.ServiceContracts
{
    public interface IExerciseListService
    {
        public List<ExerciseList> GetAllExerciseLists();

        public ExerciseList GetExerciseList(int id);
    }
}

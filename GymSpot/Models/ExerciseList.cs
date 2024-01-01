namespace GymSpot.Models
{
    public class ExerciseList
    {
        public int ExerciselistId { get; set; }
        public string? Name { get; set; }
        public List<ExerciseItem> ListOfExercises { get; set; }
    }
}

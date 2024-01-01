namespace GymSpot.Areas.Client.Models
{
    public class UserGridModel
    {
        public string GridTitle { get; set; } = string.Empty;

        public List<UserModel> Persons { get; set; }

    }
}

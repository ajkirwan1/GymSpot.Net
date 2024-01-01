using GymSpot.Areas.Client.Models;

namespace GymSpot.Areas.Client.Repository
{
    public interface IUserRepository
    {
        public UserModel GetUser();

        public void Update(UserModel user);


    }
}

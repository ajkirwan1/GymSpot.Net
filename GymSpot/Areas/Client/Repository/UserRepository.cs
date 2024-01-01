using GymSpot.Areas.Client.Models;
using GymSpot.Data;

namespace GymSpot.Areas.Client.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public UserModel? GetUser()
        {
            var user = _applicationDbContext.Users.FirstOrDefault(user => user.UserId == 1);

            return user;
        }

        public void Update(UserModel user)
        {
            _applicationDbContext.Users.Update(user);
            _applicationDbContext.SaveChanges();
        }


    }
}

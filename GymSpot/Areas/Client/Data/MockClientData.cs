using GymSpot.Areas.Client.Models;

namespace GymSpot.Areas.Client.Data
{
    public class MockUserData
    {

        private readonly UserModel _mockUserModel;

        public MockUserData()
        {
            _mockUserModel = new UserModel()
            {
                Name = "Adam Kirwan",
                DateofBirth = DateTime.Now,
                AccountPassword = "123",
                Address = "Some Address",
                EmailAddress = "Adam@123",
                Gender = Gender.Male,
            };
        }


        public UserModel GetUserModel()
        {
            return _mockUserModel;
        }

    }
}

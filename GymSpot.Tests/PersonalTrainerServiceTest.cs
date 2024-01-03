namespace GymSpot.Tests
{
    public class PersonalTrainerServiceTest
    {
        private readonly IPersonalTrainerService _personalTrainerService;

        public PersonalTrainerServiceTest()
        {
            _personalTrainerService = new PersonalTrainerService();
        }

        #region AddPersonalTrainer

        [Fact]
        public void AddPersonalTrainer_NullPersonalTrainer()
        {
            // Arrange  
            PersonalTrainerAddRequest? request = null;


            // Assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                // Act
                _personalTrainerService.AddPersonalTrainer(request);
            });

        }
        [Fact]
        public void AddPersonalTrainer_NullPersonalTrainerName()
        {
            PersonalTrainerAddRequest? request = new PersonalTrainerAddRequest()
            {
                PTName = null,
            };
            Assert.Throws<ArgumentException>(() =>
            {
                _personalTrainerService.AddPersonalTrainer(request);
            });

        }

        [Fact]
        public void AddPersonalTrainer_Success()
        {
            // Arrange
            PersonalTrainerAddRequest? request = new PersonalTrainerAddRequest()
            {
                PTName = "John Smith",
            };

            // Act
            PersonalTrainerResponse response = _personalTrainerService.AddPersonalTrainer(request);

            List<PersonalTrainerResponse> pts_from_GellAllPersonalTrainers = _personalTrainerService.GetAllPersonalTrainers();

            // Act
            Assert.True(response.PersonalTrainerId != Guid.Empty);
            Assert.Contains(response, pts_from_GellAllPersonalTrainers);

        }

        #endregion

        #region GetAllPersonalTrainers

        [Fact]
        public void GetAllPersonalTrainers_EmptyList()
        {
            //Arrange
            //Acts

            List<PersonalTrainerResponse> actual_received_response_list = _personalTrainerService.GetAllPersonalTrainers();

            //Assert

            Assert.Empty(actual_received_response_list);

        }

        [Fact]
        public void GetAllPersonalTrainers_Success()
        {
            //Arrange
            List<PersonalTrainerAddRequest> pt_request_list = new List<PersonalTrainerAddRequest>{
                new PersonalTrainerAddRequest() { PTName = "John"},
                new PersonalTrainerAddRequest() { PTName = "Sarah"}
            };

            List<PersonalTrainerResponse> pt_response_list = new List<PersonalTrainerResponse>();

            //Act
            foreach (PersonalTrainerAddRequest personalTrainerAddRequest in pt_request_list)
            {
                pt_response_list.Add(_personalTrainerService.AddPersonalTrainer(personalTrainerAddRequest));
            }

            List<PersonalTrainerResponse> actutalPtResponseList = _personalTrainerService.GetAllPersonalTrainers();

            foreach (PersonalTrainerResponse expected_pt_name in pt_response_list)
            {
                Assert.Contains(expected_pt_name, actutalPtResponseList);
            }

        }

        #endregion

        #region GetPersonalTrainerById
        [Fact]
        public void GetPersonalTrainerById_NullPersonalTrainerId()
        {
            //Arrange
            Guid? personalTrainerId = null;


            //Act
            PersonalTrainerResponse? personalTrainerResponse = _personalTrainerService.GetPersonalTrainerbyId(personalTrainerId);

            //Assert

            Assert.Null(personalTrainerResponse);


        }
        [Fact]
        public void GetPersonalTrainerById_NoId()
        {
            Guid personalTrainerId = Guid.NewGuid();

            PersonalTrainerResponse? personalTrainerResponse = _personalTrainerService.GetPersonalTrainerbyId(personalTrainerId);

            Assert.Null(personalTrainerResponse);

        }

        [Fact]
        public void GetPersonalTrainerById_Success()
        {
            // Arrange
            PersonalTrainerAddRequest? personal_trainer_to_add = new PersonalTrainerAddRequest() { PTName = "Jim" };

            PersonalTrainerResponse personal_trainer_response = _personalTrainerService.AddPersonalTrainer(personal_trainer_to_add);

            // Act

            PersonalTrainerResponse personal_trainer_response_from_get = _personalTrainerService.GetPersonalTrainerbyId(personal_trainer_response.PersonalTrainerId);

            // Assert
            Assert.Equal(personal_trainer_response, personal_trainer_response_from_get);
            #endregion
        }
    }
}

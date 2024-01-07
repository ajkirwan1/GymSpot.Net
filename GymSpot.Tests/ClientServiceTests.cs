using ServiceContracts.DTO.ClientDTO;

namespace GymSpot.Tests
{
    public class ClientServiceTests
    {
        private readonly ClientService _clientService;

        public ClientServiceTests()
        {
            _clientService = new ClientService();
        }

        [Fact]
        public void AddClient_NullArgument()
        {
            //Arrange
            ClientAddRequest? request = null;

            Assert.Throws<ArgumentNullException>(() =>
            {
                _clientService.AddClient(request);
            }
            );


        }

        [Fact]
        public void AddClient_NullClientFirstName()
        {
            //Arrange
            ClientAddRequest request = new ClientAddRequest
            {
                Email = "Test",
                FirstName = null,
                LastName = "Test",
                Password = "Test"
            };

            Assert.Throws<ArgumentException>(() =>
            {
                _clientService.AddClient(request);
            });
        }

        [Fact]
        public void AddClient_Success()
        {

            //Arrange
            ClientAddRequest request = new ClientAddRequest
            {
                Email = "Test",
                FirstName = "Test",
                LastName = "Test",
                Password = "Test"
            };

            ClientResponse clientResponse = _clientService.AddClient(request);

            Assert.True(clientResponse.ClientId != Guid.Empty);


        }


    }
}

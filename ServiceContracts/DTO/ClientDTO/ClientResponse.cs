using Entities;

namespace ServiceContracts.DTO.ClientDTO
{
    public class ClientResponse
    {
        public Guid ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public static class ClientExtensions
    {
        public static ClientResponse ToClientResponse(this Client client)
        {
            return new ClientResponse()
            {

                ClientId = client.ClientId,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email,
                Password = client.Password,
            };

        }
    }

}

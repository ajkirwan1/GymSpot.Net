using Entities;

namespace ServiceContracts.DTO.ClientDTO
{
    public class ClientAddRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public Client ToClient()
        {
            return new Client() { FirstName = FirstName, LastName = LastName, Email = Email };
        }

    }
}

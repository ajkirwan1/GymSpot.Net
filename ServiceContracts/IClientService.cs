using ServiceContracts.DTO.ClientDTO;

namespace ServiceContracts
{
    public interface IClientService
    {
        ClientResponse AddClient(ClientAddRequest? clientAddRequest);

    }
}

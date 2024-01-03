using ServiceContracts.DTO;

namespace ServiceContracts
{
    /// <summary>
    /// Business logic for manipulating PersonalTrainer entity
    /// </summary>
    public interface IPersonalTrainerService
    {
        /// <summary>
        /// Adds a personal trainer object to the list of personal trainers 
        /// </summary>
        /// <param name="addRequest"></param>
        /// <returns>A PersonalTrainerResponse object</returns>
        PersonalTrainerResponse AddPersonalTrainer(PersonalTrainerAddRequest? addRequest);

        /// <summary>
        /// Gets all personal trainers in the db
        /// </summary>
        /// <returns>All personal trainers</returns>
        List<PersonalTrainerResponse> GetAllPersonalTrainers();

        /// <summary>
        /// Returns a PersonalTrainerReponse object based on the given Id. Is nullable
        /// </summary>
        /// <param name="Id">PersonalTrainerId (Guid) to search</param>
        /// <returns>PersonalTrainerReponse object</returns>
        PersonalTrainerResponse? GetPersonalTrainerbyId(Guid? Id);

    }
}

using Entities;

namespace ServiceContracts.DTO
{
    public class PersonalTrainerAddRequest
    {
        /// <summary>
        ///  DTO to add a new PT
        /// </summary>
        public string? PTName { get; set; }
        public PersonalTrainer ToPersonalTrainer()
        {
            return new PersonalTrainer()
            {
                PTName = PTName
            };
        }
    }
}

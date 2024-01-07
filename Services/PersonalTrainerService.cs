using Entities;
using ServiceContracts;
using ServiceContracts.DTO;

namespace Services
{
    public class PersonalTrainerService : IPersonalTrainerService
    {

        private readonly List<PersonalTrainer> _personaalTrainers;

        public PersonalTrainerService()
        {
            _personaalTrainers = new List<PersonalTrainer>();
        }

        public PersonalTrainerResponse AddPersonalTrainer(PersonalTrainerAddRequest? addRequest)
        {
            if (addRequest == null)
            {
                throw new ArgumentNullException();
            }
            PersonalTrainer personalTrainer = addRequest.ToPersonalTrainer();

            if (personalTrainer.PTName == null)
            {
                throw new ArgumentException();
            }

            personalTrainer.PersonalTrainerId = Guid.NewGuid();

            _personaalTrainers.Add(personalTrainer);

            return personalTrainer.ToPersonalTrainerResponse();

        }

        public List<PersonalTrainerResponse> GetAllPersonalTrainers()
        {
            return _personaalTrainers.Select(pt => pt.ToPersonalTrainerResponse()).ToList();
        }

        public PersonalTrainerResponse? GetPersonalTrainerbyId(Guid? Id)
        {

            if (Id == null)
            {
                return null;
            }

            PersonalTrainer? trainer = _personaalTrainers.FirstOrDefault(x => x.PersonalTrainerId == Id);

            if (trainer == null)
            {
                return null;
            }

            return trainer.ToPersonalTrainerResponse();
        }
    }
}

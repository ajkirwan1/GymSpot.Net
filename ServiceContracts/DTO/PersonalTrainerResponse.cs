using Entities;

namespace ServiceContracts.DTO
{
    /// <summary>
    /// DTO for PT response
    /// </summary>
    public class PersonalTrainerResponse
    {
        public Guid PersonalTrainerId { get; set; }
        public string PTName { get; set; }

        public override bool Equals(object? obj)
        {

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != typeof(PersonalTrainerResponse))
            {
                return false;
            }

            PersonalTrainerResponse pt_to_compare = (PersonalTrainerResponse)obj;

            return this.PersonalTrainerId == pt_to_compare.PersonalTrainerId && this.PTName == pt_to_compare.PTName;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public static class PTExtensions
    {
        public static PersonalTrainerResponse ToPersonalTrainerResponse(this PersonalTrainer ToPersonalTrainer)
        {
            return new PersonalTrainerResponse()
            {
                PersonalTrainerId = ToPersonalTrainer.PersonalTrainerId,
                PTName = ToPersonalTrainer.PTName,
            };
        }
    }


}

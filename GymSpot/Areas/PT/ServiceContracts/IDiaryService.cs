using GymSpot.Areas.PT.Models;

namespace GymSpot.Areas.PT.ServiceContracts
{
    public interface IDiaryService
    {
        List<DiaryModel> GetDiaryModels();

        List<DiaryModel> GetFilteredDiaryModels(string searchBy, string searchString);

    }
}

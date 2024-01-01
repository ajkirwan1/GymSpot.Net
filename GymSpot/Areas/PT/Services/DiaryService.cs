using GymSpot.Areas.PT.MockData;
using GymSpot.Areas.PT.Models;
using GymSpot.Areas.PT.Models.ViewModels;
using GymSpot.Areas.PT.ServiceContracts;

namespace GymSpot.Areas.PT.Services
{
    public class DiaryService : IDiaryService
    {
        public List<DiaryModel> GetDiaryModels()
        {
            MockDiaryData diaryData = new MockDiaryData();
            DiaryVM data = diaryData.GetDiaryModels();

            List<DiaryModel> result = new List<DiaryModel>();

            foreach (DiaryModel diaryEntry in data.DiaryEntry)
            {
                result.Add(diaryEntry);
            }
            return result;
        }

        public List<DiaryModel> GetFilteredDiaryModels(string? searchBy, string? searchString)
        {
            List<DiaryModel> allDiaryEntries = GetDiaryModels();
            List<DiaryModel> matchingEntries = allDiaryEntries;

            if (string.IsNullOrEmpty(searchString) || string.IsNullOrEmpty(searchBy))
            {
                return matchingEntries;
            }

            switch (searchBy)
            {
                case nameof(DiaryModel.Client):
                    matchingEntries = allDiaryEntries.Where(x =>
                    (!string.IsNullOrEmpty(x.Client) ?
                    x.Client.Contains(searchString, StringComparison.OrdinalIgnoreCase) : true)).ToList();
                    break;
                case nameof(DiaryModel.Date):
                    matchingEntries = allDiaryEntries.Where(x =>
                    (x.Date != null) ?
                    x.Date.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase) : true).ToList();
                    break;
                case nameof(DiaryModel.Details):
                    matchingEntries = allDiaryEntries.Where(x =>
                    (!string.IsNullOrEmpty(x.Details) ?
                    x.Details.Contains(searchString, StringComparison.OrdinalIgnoreCase) : true)).ToList();
                    break;
                default:
                    matchingEntries = allDiaryEntries;
                    break;
            }

            return matchingEntries;
        }
    }
}

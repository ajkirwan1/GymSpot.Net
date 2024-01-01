using GymSpot.Areas.PT.Models;
using GymSpot.Areas.PT.Models.ViewModels;

namespace GymSpot.Areas.PT.MockData
{
    public class MockDiaryData
    {
        private readonly DiaryVM _diaryList;
        public MockDiaryData()
        {
            _diaryList = new DiaryVM()
            {
                DiaryId = 1,
                DiaryEntry = new List<DiaryModel>()
                {
                    new DiaryModel()
                    {
                        EntryId = Guid.Parse("032BDFC8-3C1F-43C6-B9D0-243021BCED8D"),
                        Client = "Jimmy Ben",
                        Date = DateTime.Now,
                        Details = "Some information"
                    },
                    new DiaryModel()
                    {
                        EntryId = Guid.Parse("2375DA6B-393D-4B08-956F-92E3C4897851"),
                        Client = "Adam Kirwan",
                        Date = DateTime.Now,
                        Details = "Some information"
                    },
                    new DiaryModel()
                    {
                        EntryId = Guid.Parse("CA8AAD48-82E8-45A2-9A69-C8536CB13156"),
                        Client = "Emma Dean",
                        Date = DateTime.Now,
                        Details = "Some information"

                    },
                    new DiaryModel()
                    {
                        EntryId = Guid.Parse("0354680F-5209-4379-81EB-2D1484394D25"),
                        Client = "Scarlet Johanson",
                        Date = DateTime.Now,
                        Details = "Some information"
                    }

                }

            };
        }
        public DiaryVM GetDiaryModels()
        {
            return _diaryList;
        }
    }
}


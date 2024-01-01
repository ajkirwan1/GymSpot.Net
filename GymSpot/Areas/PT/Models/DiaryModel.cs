namespace GymSpot.Areas.PT.Models
{
    public class DiaryModel
    {
        public Guid EntryId { get; set; }
        public DateTime Date { get; set; }
        public string? Client { get; set; }
        public string? Details { get; set; }
    }
}

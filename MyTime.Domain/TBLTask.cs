using MyTime.Domain.Enums;
namespace MyTime.Domain
{
    public class TBLTask
    {
        public int TaskId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal TotalDuration { get; set; }
        public Enums.EnTaskStatus TaskStatus { get; set; }
        public DateTime DtCreation { get; set; }
        public DateTime? DtStarted { get; set; }
        public DateTime? DtFinished { get; set; }
        public int? UserId { get; set; }
    }
}
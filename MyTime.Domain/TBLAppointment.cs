namespace MyTime.Domain
{
    public class TBLAppointment
    {
        public int AppointmentId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTIme? DtEnd { get; set; }
        public int FlgDeleted { get; set; }
        public int TaskId { get; set; }
    }
}
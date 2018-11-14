using System;

namespace MyTime.Domain
{
    public class TBLAppointment
    {
        public TBLAppointment()
        {
           TBLTask = new TBLTask();
           DtStart = DateTime.Now;
           FlgDeleted = 0;  
        } 
        public int IdAppointment { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
        public int FlgDeleted { get; set; }
        public int IdTask { get; set; }

        public virtual TBLTask TBLTask {get; set; }
    }
}
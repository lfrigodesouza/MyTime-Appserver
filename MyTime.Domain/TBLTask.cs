using System;
using System.Collections.Generic;
using static MyTime.Domain.Enums.Enums;

namespace MyTime.Domain
{
    public class TBLTask
    {
        public TBLTask()
        {
            DtCreation = DateTime.Now;
            TaskStatus = EnTaskStatus.Opened;
            TotalDuration = 0;
            TBLAppointments = new List<TBLAppointment>();
            TBLUser = new TBLUser();
        }
        public int IdTask { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal TotalDuration { get; set; }
        public EnTaskStatus TaskStatus { get; set; }
        public DateTime DtCreation { get; set; }
        public DateTime? DtStarted { get; set; }
        public DateTime? DtFinished { get; set; }
        public int? IdUser { get; set; }

        public virtual List<TBLAppointment> TBLAppointments { get; set; }
        public virtual TBLUser TBLUser {get; set; }
    }
}
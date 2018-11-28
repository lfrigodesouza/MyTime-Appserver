using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static MyTime.Domain.Enums.Enums;

namespace MyTime.Domain
{
    public class TBLUser
    {
        public TBLUser()
        {
            FlgEnable = 0;
            UserType = EnUserType.NormalUser;
            TBLTasks = new List<TBLTask>();
        }

        [Key]
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Password { get; set; }
        public int FlgEnable { get; set; }
        public EnUserType UserType { get; set; }

        public virtual IList<TBLTask> TBLTasks {get; set; }
    }
}
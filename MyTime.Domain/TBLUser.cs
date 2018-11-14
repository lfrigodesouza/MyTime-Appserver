using MyTime.Enums;
namespace MyTime.Domain
{
    public class TBLUser
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int FlgEnable { get; set; }
        public Enums.EnUserType UserType { get; set; }
    }
}
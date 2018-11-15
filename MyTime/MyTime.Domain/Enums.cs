namespace MyTime.Domain.Enums
{
    public class Enums
    {
        public enum EnUserType
        {
            Administrator = 0,
            NormalUser = 1
        }

        public enum EnTaskStatus
        {
            Opened = 0,
            Started = 1,
            Paused = 2,
            Finished = 3,
            Canceled = 4
        }

    }
}
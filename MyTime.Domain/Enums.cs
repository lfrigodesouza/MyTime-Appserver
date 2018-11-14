namespace MyTime.Domain.Enums
{
    public class Enums
    {
        public enum EnUserType
        {
            Administrator = 1,
            NormalUser = 2
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
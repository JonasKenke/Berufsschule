namespace DataTime
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DateTime dt = new DateTime();
        
            Console.WriteLine("Date: {0}.{1}.{2} Time: {3}:{4}:{5}", dt.GetDay, dt.GetMonth, dt.GetYear, dt.GetHour, dt.GetMinute, dt.GetSecond);
        }
    }

    interface ITime
    {
        int GetHour { get; }
        int GetMinute { get; }
        int GetSecond { get; }
    }

    interface IDate
    {
        int GetDay { get; }
        int GetMonth { get; }
        int GetYear { get; }
    }

    class DateTime : IDate, ITime
    {
        private System.DateTime dt;

        public DateTime()
        {
            dt = System.DateTime.Now;
        }

        public int GetHour => dt.Hour;
        public int GetMinute => dt.Minute;
        public int GetSecond => dt.Second;
        public int GetDay => dt.Day;
        public int GetMonth => dt.Month;
        public int GetYear => dt.Year;
    }
}
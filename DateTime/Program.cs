namespace DateTime;

class Program
{
    public static void Main(string[] args)
    {
        DateTime dt = new DateTime();
        
        Console.WriteLine("Date: {0}.{1}.{2} Time: {3}:{4}:{5}", dt.GetDay, dt.GetMonth, dt.GetYear, dt.GetHour, dt.GetMinute, dt
            .GetSecond);
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
    private int hour;
    private int minute;
    private int second;

    private int day;
    private int month;
    private int year;

    public DateTime()
    {
        System.DateTime dt = System.DateTime.Now;
        day = dt.Day;
        month = dt.Month;
        year = dt.Year;
        
        hour = dt.Hour;
        minute = dt.Minute;
        second = dt.Second;
    }
    
    public int GetHour => hour;
    public int GetMinute => minute;
    public int GetSecond => second;
    public int GetDay => day;
    public int GetMonth => month;
    public int GetYear => year;
}
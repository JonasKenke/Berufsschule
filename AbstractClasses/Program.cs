namespace AbstractClasses;

public class Program
{
    public static void Main(string[] args)
    {
        var employee1 = new Apprentice("John", "senior dev", "G105", GetApprenticeVisitTimes());
        var employee2 = new FullTimeEmployee("Hans", "junior dev", "G105");

        var employees = new List<Employee> { employee1, employee2 };
        foreach (var employee in employees)
        {
            Console.WriteLine($"ID: {employee.GetId()}\tName: {employee.GetName()}\tOccupation: {employee.GetJobTitle()}\tWorkplace: {employee.GetWorkplace()}");
        }
    }

    private static List<ApprenticeVisitTime> GetApprenticeVisitTimes()
    {
        return
        [
            new ApprenticeVisitTime(new DateTime(2024, 7, 10), new DateTime(2024, 7, 20)),
            new ApprenticeVisitTime(new DateTime(2024, 9, 11), new DateTime(2024, 9, 29))
        ];
    }
}

abstract class Employee
{
    private readonly String id = Guid.NewGuid().ToString();
    private readonly String name;
    private readonly String jobTitle;
    protected readonly String Workplace;

    protected Employee(String name, String jobTitle, String workplace)
    {
        this.name = name;
        this.jobTitle = jobTitle;
        this.Workplace = workplace;
    }
    
    public String GetId()
    {
        return id;
    }
    
    public String GetName()
    {
        return name;
    }
    
    public String GetJobTitle()
    {
        return jobTitle;
    }
    
    public abstract String GetWorkplace();
}

class FullTimeEmployee : Employee
{
    public FullTimeEmployee(String name, String jobTitle, String workplace) : base(name, jobTitle, workplace)
    {
        
    }
    
    public override String GetWorkplace()
    {
        return Workplace;
    }
}



class ApprenticeVisitTime
{
    public ApprenticeVisitTime(DateTime start, DateTime end)
    {
        Start = start;
        End = end;
    }

    private DateTime Start { get; }
    private DateTime End { get; }
     
    public bool Includes(DateTime value)
    {
        return (Start <= value) && (value <= End);
    }
}

class Apprentice : Employee
{
    private readonly List<ApprenticeVisitTime> dateTimes;
    
    public Apprentice(String name, String jobTitle, String workplace, List<ApprenticeVisitTime> dateTimes) : base(name, jobTitle, workplace)
    {
        this.dateTimes = dateTimes;
    }
    
    public override String GetWorkplace()
    {
        DateTime now = DateTime.Now;
        foreach (ApprenticeVisitTime dateTime in dateTimes)
        {
            if (dateTime.Includes(now))
            {
                return "vocational school";
            }
        }
        return Workplace;
    }
}
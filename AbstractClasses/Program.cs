namespace AbstractClasses;

public class Program
{
    public static void Main(string[] args)
    {
        Apprentice apprentice = new Apprentice("apprentice", "developer", "R101",
            new List<ApprenticeVisitTime>
            {
                new ApprenticeVisitTime(new DateTime(2019, 8, 12), new DateTime(2019, 8, 30)),
                new ApprenticeVisitTime(new DateTime(2019, 11, 11), new DateTime(2019, 11, 29))
            });
        
        FulltimeEmployee fulltimeEmployee = new FulltimeEmployee("full-time employee", "developer", "R102");
        
        List<Employee> employees = new List<Employee> { apprentice, fulltimeEmployee };
        foreach (Employee employee in employees)
        {
            Console.WriteLine("ID: " + employee.getId()
                                     + "\tName: " + employee.getName()
                                     + "\tOccupation: " + employee.getJobTitle()
                                     + "\tWorkplace: "
                                     + employee.getWorkplace()
            );
        }
        Console.ReadKey();
    }
}

abstract class Employee
{
    protected String id = Guid.NewGuid().ToString();
    protected String name;
    protected String JobTitle;
    protected String Workplace;
    
    public Employee(String name, String JobTitle, String Workplace)
    {
        this.name = name;
        this.JobTitle = JobTitle;
        this.Workplace = Workplace;
    }
    
    public String getId()
    {
        return id;
    }
    
    public String getName()
    {
        return name;
    }
    
    public String getJobTitle()
    {
        return JobTitle;
    }
    
    public abstract String getWorkplace();
}

class FulltimeEmployee : Employee
{
    public FulltimeEmployee(String name, String JobTitle, String Workplace) : base(name, JobTitle, Workplace)
    {
        
    }
    
    public override String getWorkplace()
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
     
    public DateTime Start { get; private set; }
    public DateTime End { get; private set; }
     
    public bool Includes(DateTime value)
    {
        return (Start <= value) && (value <= End);
    }
}

class Apprentice : Employee
{
    private List<ApprenticeVisitTime> dateTimes;
    
    public Apprentice(String name, String JobTitle, String Workplace, List<ApprenticeVisitTime> dateTimes) : base(name, JobTitle, Workplace)
    {
        this.dateTimes = dateTimes;
    }
    
    public override String getWorkplace()
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
namespace Tag1;

class Program
{
    public static void Main(string[] args)
    {
        Kunde kunde1 = new Kunde("Hans", "Peter");
        Console.WriteLine(kunde1.getName() + kunde1.getVorname());
        kunde1.setName("Peter");
        kunde1.setVorname("Hansi");
        Console.WriteLine(kunde1.getName() + kunde1.getVorname());
    }
}

class Kunde
{
    private string vorname;
    private string name;
    
    public Kunde(string vorname, string nachname)
    {
        this.vorname = vorname;
        this.name = nachname;
    }
    
    public string getName()
    {
        return name;
    }
    
    public string getVorname()
    {
        return vorname;
    }
    
    public void setName(string name)
    {
        this.name = name;
    }
    
    public void setVorname(string vorname)
    {
        this.vorname = vorname;
    }
}


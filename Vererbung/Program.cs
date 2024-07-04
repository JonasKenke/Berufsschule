namespace Vererbung;

class Vererbung
{
    public static void Main(string[] args)
    {
        Kunde kunde1 = new Kunde("Test");
        Kunde kunde2 = new Kunde("Test2");
        
        Konto konto1 = new Konto(1000, kunde1);
        
        Taschengeldkonto konto2 = new Taschengeldkonto(1000, kunde2, kunde1);

        try
        {
            konto2.Buchen(-2000);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Erreur auf der Kontostand");
        }
        
        Console.WriteLine(konto2.GetKtoStand());
    }
}


class Konto
{
    protected double KtoStand;   
    private String ktoNummer;
       
 
    Kunde kunde;
    private Konto()              //Standardkonstruktor
    {
        ktoNummer = Guid.NewGuid().ToString();       
        KtoStand = 0;
    }
 
    public Konto(double w, Kunde k)
        : this()                // allgemeiner Konstruktor (mind. ein Parameter)
    {                           // :this() bewirkt, dass zuerst der Standardkonstr.
        //aufgerufen wird
        KtoStand = w;
        kunde = k;
    }
    public Kunde GetKunde()
    {
        return kunde;
    }
    public String GetKtoNr()
    {
        return ktoNummer;
    }
    public double GetKtoStand() //Methode getKtoStand() liefert ktoStand zurück
    {                           //public, damit von außen aufrufbar
        return KtoStand;
    }
    public void Buchen(double betrag)
    {
        KtoStand += betrag;     //ktoStand = ktoStand + betrag;
    }
}

class Taschengeldkonto : Konto
{
    private Kunde erziehungsbrechtigter;

    public Taschengeldkonto(double w, Kunde k, Kunde e)
    : base(w, k)
    {
        erziehungsbrechtigter = e;
    }

    new public void Buchen(double betrag)
    {
        if ((KtoStand + betrag) >= 0)
        {
            base.Buchen(betrag);
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}
 
class Kunde
{
    private string name;
    private String kundeNr;
    private List<Konto> konten = new List<Konto>();  //Liste mit Konten
 
    public Kunde()      //Standardkonstruktor (keine Parameter)
    {
        kundeNr = Guid.NewGuid().ToString();
        name = "noname";
    }
    public Kunde(string name)
        : this()             // allgemeiner Konstruktor (mind. ein Parameter)
    {                        // :this() bewirkt, dass zuerst der Standardkonstr.
        // aufgerufen wird
        this.name = name;
    }
    public void AddKonto(Konto kto)
    {
        konten.Add(kto);    // Hinzufügen eines Kontos
    }
    public List<Konto> GetKonten()  //Liste mit Konten zurückgeben
    {
        return konten;
    }
    public void SetName(string name)
    {
        this.name = name;  
    }
    public string GetName()
    {
        return name;
    }
    public String GetNr()
    {
        return kundeNr;
    }
}
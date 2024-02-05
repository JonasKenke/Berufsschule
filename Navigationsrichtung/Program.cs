class Navigationsrichtungen
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Kunde k1 = new Kunde("Max", "Mustermann");
            Kunde k2 = new Kunde("Moritz", "Mustermann");
            Konto konto1 = new Konto(1000, 1);
            Konto konto2 = new Konto(2000, 2);

            
            k1.addKonto(konto1);
            k1.addKonto(konto2);
            
            k2.addKonto(konto1);
            
            Console.WriteLine("Kunde 1 hat folgende Konten: ");
            foreach (Konto konto in k1.getKonten())
            {
                Console.WriteLine("Kontonummer: " + konto.getKontonummer());
                Console.WriteLine("Kontostand: " + konto.getKontostand());
            }
            Console.WriteLine("Gesamtguthaben: " + k1.getGesamtguthaben());
            
            Console.WriteLine("Kunde 2 hat folgende Konten: ");
            foreach (Konto konto in k2.getKonten())
            {
                Console.WriteLine("Kontonummer: " + konto.getKontonummer());
                Console.WriteLine("Kontostand: " + konto.getKontostand());
            }
            Console.WriteLine("Gesamtguthaben: " + k2.getGesamtguthaben());
            
            Console.WriteLine("Konto 1 hat folgende Kunden: ");
            foreach (Kunde kunde in konto1.getKunden())
            {
                Console.WriteLine("Name: " + kunde.getName());
            }
            
            Console.WriteLine("Konto 2 hat folgende Kunden: ");
            foreach (Kunde kunde in konto2.getKunden())
            {
                Console.WriteLine("Name: " + kunde.getName());
            }
        }
    }

    class Kunde
    {
        private string vorname;
        private string nachname;
        private List<Konto> konten = new List<Konto>();
        
        public Kunde(string vorname, string nachname)
        {
            this.vorname = vorname;
            this.nachname = nachname;
        }
        
        public void addKonto(Konto konto)
        {
            konten.Add(konto);
            konto.addKunde(this);
        }
        
        public string getName()
        {
            return vorname + " " + nachname;
        }
        
        public List<Konto> getKonten()
        {
            return konten;
        }
        
        public double getGesamtguthaben()
        {
            double gesamtguthaben = 0;
            foreach (Konto konto in konten)
            {
                gesamtguthaben += konto.getKontostand();
            }
            return gesamtguthaben;
        }
    }

    class Konto
    {
        private uint kontonummer;
        private double kontostand;
        private List<Kunde> kunden = new List<Kunde>();
        
        public Konto(double kontostand, uint kontonummer)
        {
            this.kontostand = kontostand;
            this.kontonummer = kontonummer;
        }
        
        public uint getKontonummer()
        {
            return kontonummer;
        }
        
        public double getKontostand()
        {
            return kontostand;
        }
        
        public void addKunde(Kunde kunde)
        {
            kunden.Add(kunde);
        }
        
        public List<Kunde> getKunden()
        {
            return kunden;
        }
    }
}
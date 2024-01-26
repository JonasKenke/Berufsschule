namespace Werk_Produkt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firma f1 = new Firma();

            Werk w1 = new Werk(new Produkt("4 TiB Festplatte", 195.5, 7000));
            Werk w2 = new Werk(new Produkt("250 GiB SSD", 149.9, 6000));
            
            f1.addWerk(w1);
            f1.addWerk(w2);
            Console.WriteLine("Gesamtumsatz " + f1.berechneGesamtumsatz());
        }
    }

    class Firma
    {
        private List<Werk> werke = new List<Werk>();

        public void addWerk(Werk werk)
        {
            werke.Add(werk);
        }
        
        public double berechneGesamtumsatz()
        {
            double gesamtumsatz = 0;
            foreach (Werk werk in werke)
            {
                gesamtumsatz += werk.berechneUmsatz();
            }
            return gesamtumsatz;
        }
    }
    
    class Werk
    {
        private Produkt produkt;
        
        public Werk(Produkt produkt)
        {
            this.produkt = produkt;
        }
        
        public double berechneUmsatz()
        {
            return produkt.getAnzahl() * produkt.getPreis();
        }
    }
    
    class Produkt
    {
        private string name;
        private double preis;
        private int anzahl;
        
        public Produkt(string name, double produktPreis, int produktAnzahl)
        {
            this.name = name;
            this.preis = produktPreis;
            this.anzahl = produktAnzahl;
        }

        public string getName()
        {
            return name;
        }
        
        public double getPreis()
        {
            return preis;
        }
        
        public int getAnzahl()
        {
            return anzahl;
        }
    }
}


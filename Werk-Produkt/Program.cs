using System;
using System.Collections.Generic;
using System.Text;

namespace FirmaProdukt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firma firma = new Firma();

            Werk werk1 = new Werk(new Produkt("4 TiB Festplatte", 195.5, 7000));
            Werk werk2 = new Werk(new Produkt("250 GiB SSD", 149.9, 6000));
            
            firma.addWerk(werk1);
            firma.addWerk(werk2);
            Console.WriteLine(firma.berechneGesamtumsatz());
            Console.ReadKey();
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
        private Produkt _produkt;
        
        public Werk(Produkt produkt)
        {
            this._produkt = produkt;
        }
        
        public double berechneUmsatz()
        {
            return _produkt.Anzahl() * _produkt.Preis();
        }
    }
    
    class Produkt
    {
        private string produktName;
        private double preis;
        private int anzahl;
        
        public Produkt(string produktName, double produktPreis, int produktAnzahl)
        {
            this.produktName = produktName;
            this.preis = produktPreis;
            this.anzahl = produktAnzahl;
        }
        
        public double Preis()
        {
            return preis;
        }
        
        public int Anzahl()
        {
            return anzahl;
        }
    }
}


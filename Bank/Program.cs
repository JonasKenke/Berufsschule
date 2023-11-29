using System;
using System.Collections.Generic;

namespace Bank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Bankautomat ba1 = new Bankautomat(12000);
            Bankautomat ba2 = new Bankautomat(8000);
            Bankautomat ba3 = new Bankautomat(10000);

            Bank bank1 = new Bank(new List<Bankautomat>{ba1, ba2, ba3});
            
            Console.WriteLine("Gesamteinlagen sind: " + bank1.getGesamteinlagen());
        }
    }

    class Bank
    {
        private List<Bankautomat> bankautomaten = new List<Bankautomat>();
        
        public Bank(List<Bankautomat> bankautomaten)
        {
            this.bankautomaten = bankautomaten;
        }
        public double getGesamteinlagen()
        {
            double gesamteinlagen = 0;
            foreach (Bankautomat bankautomat in bankautomaten)
            {
                gesamteinlagen += bankautomat.getEinlagen();
            }
            return gesamteinlagen;
        }

    }

    class Bankautomat
    {
        private double einlagen;

        public Bankautomat()
        {
            einlagen = 0;
        }
        
        public Bankautomat(double einlagen)
        {
            this.einlagen = einlagen;
        }
        
        public double getEinlagen()
        {
            return einlagen;
        }
        
    }
}
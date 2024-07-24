using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        public static void Main(string[] args)
        {
            string filePath = "/home/jonas/RiderProjects/Berufsschule/List/kunde.csv";
            KundeDAO kundeDAO = new KundeDAO(filePath);
            List<Kunde> kunden = kundeDAO.LoadKunden();

            foreach (var kunde in kunden)
            {
                Console.WriteLine($"Vorname: {kunde.getVorname()}, Nachname: {kunde.getName()}");
            }
        }
    }
}
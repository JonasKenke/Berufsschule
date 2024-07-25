using System;
using System.Collections.Generic;
using System.IO;

namespace List
{
    public class KundeDAO : IKundeDAO
    {
        private readonly string filePath;

        public KundeDAO(string filePath)
        {
            this.filePath = filePath;
        }

        public List<Kunde> LoadKunden()
        {
            List<Kunde> kunden = new List<Kunde>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');

                        if (fields.Length >= 2)
                        {
                            string vorname = fields[0];
                            string nachname = fields[1];
                            Kunde kunde = new Kunde(vorname, nachname);
                            kunden.Add(kunde);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"The file could not be read: {e.Message}");
            }

            return kunden;
        }

        public void AddKunde(Kunde kunde)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"{kunde.Vorname},{kunde.Nachname}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"The file could not be written: {e.Message}");
            }
        }
    }
}

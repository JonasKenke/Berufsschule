using System;

namespace List
{
    public class Kunde
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public Kunde(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }
    }
}

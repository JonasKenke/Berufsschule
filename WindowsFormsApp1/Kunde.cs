using System;

namespace List
{
    public class Kunde
    {
        private string vorname;
        private string nachname;

        public Kunde(string vorname, string nachname)
        {
            this.vorname = vorname;
            this.nachname = nachname;
        }

        public string getVorname()
        {
            return vorname;
        }

        public string getName()
        {
            return nachname;
        }
    }
}
using System.Collections.Generic;

namespace List
{
    public abstract class IKundeService
    {
        public abstract List<Kunde> readKunde();
        public abstract void writeKunde(string vorname, string nachname);
    }
}

using System.Collections.Generic;

namespace List
{
    public class KundeService : IKundeService
    {
        private readonly IKundeDAO kundeDAO;

        public KundeService(IKundeDAO kundeDAO)
        {
            this.kundeDAO = kundeDAO;
        }

        public override List<Kunde> readKunde()
        {
            return kundeDAO.LoadKunden();
        }

        public override void writeKunde(string vorname, string nachname)
        {
            Kunde kunde = new Kunde(vorname, nachname);
            kundeDAO.AddKunde(kunde);
        }
    }
}

using System;
using System.Collections.Generic;

namespace List
{
    public class SecDecorator : IKundeService
    {
        private readonly IKundeService _kundeService;

        public SecDecorator(IKundeService kundeService)
        {
            _kundeService = kundeService;
        }

        public override List<Kunde> readKunde()
        {
            return _kundeService.readKunde();
        }

        public override void writeKunde(string vorname, string nachname)
        {
            _kundeService.writeKunde(vorname, nachname);
        }
    }
}

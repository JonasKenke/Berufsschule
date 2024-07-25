using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace List
{
    public class LaufzeitDecorator : IKundeService
    {
        private readonly IKundeService _kundeService;

        public LaufzeitDecorator(IKundeService kundeService)
        {
            _kundeService = kundeService;
        }

        public override List<Kunde> readKunde()
        {
            var stopwatch = Stopwatch.StartNew();
            var result = _kundeService.readKunde();
            stopwatch.Stop();
            Console.WriteLine($"readKunde executed in {stopwatch.ElapsedMilliseconds} ms");
            return result;
        }

        public override void writeKunde(string vorname, string nachname)
        {
            var stopwatch = Stopwatch.StartNew();
            _kundeService.writeKunde(vorname, nachname);
            stopwatch.Stop();
            Console.WriteLine($"writeKunde executed in {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}

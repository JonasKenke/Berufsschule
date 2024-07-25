using System.Collections.Generic;

namespace List
{
    public interface IKundeDAO
    {
        List<Kunde> LoadKunden();
        void AddKunde(Kunde kunde);
    }
}

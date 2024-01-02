using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bewerbunghelper
{
    public interface Ilogik
    {
        bool hinzufugen(Boolean ergebnis, Bewerbung newbewerbung);
        bool ExsistentPrufen(Bewerbung mynew);
        List<Bewerbung> AnzeigenBewerbungen(string status);
        bool AktualiesernDaten(List<Bewerbung> list);
        bool SendenEmail(string empfanger, string ansprechpartner, string pfadanhang);
      //  List<Bewerbung> Zeigen(string pfad);
    }
}

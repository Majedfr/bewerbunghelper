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
        List<Bewerbung> bewerbungAnzeigen(string status);
        bool aktualieseierendaten(List<Bewerbung> list);
        bool emailsenden(string empfanger, string ansprechpartner, string pfadanhang);
      //  List<Bewerbung> Zeigen(string pfad);
    }
}

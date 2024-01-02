using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bewerbunghelper
{
    public interface Idatenhaltung
    {
        bool Speichen(Bewerbung mybewerbung, string pfad);
        List<Bewerbung> Einlesen(string pfad);
        bool Updatedatensatz(List<Bewerbung> list,string pfad);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bewerbunghelper
{
    public interface Idatenhaltung
    {
        bool speichen(Bewerbung mybewerbung,string pfad);
        List<Bewerbung> lesen(string pfad);
        bool update(List<Bewerbung> list,string pfad);

    }
}

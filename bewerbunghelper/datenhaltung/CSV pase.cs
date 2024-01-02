using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bewerbunghelper
{
       public class CSV_pase : Idatenhaltung
    {
        public List<Bewerbung> lesen(string pfad)
        {
            List<Bewerbung> list = new List<Bewerbung>();
            if (File.Exists(pfad))
            {
                using (StreamReader reeader = new StreamReader(pfad))
                {
                    reeader.ReadLine();
                    while (!reeader.EndOfStream)
                    {
                        string datensatz = reeader.ReadLine();
                        string[] arr1 = datensatz.Split(';');
                        // string[] arr2 = arr1[0].Split(',');
                        Bewerbung my = new Bewerbung();
                        my.Firma = arr1[0];
                        my.Adresss = arr1[1];
                        my.Hausnummer = arr1[2];
                        my.PLZ = arr1[3];
                        my.Ort = arr1[4];
                        my.Bezeichnung = arr1[5];
                        my.Email = arr1[6];
                        my.Telefon = arr1[7];
                        my.Anprechpartner = arr1[8];
                        my.Status = arr1[9];
                        my.Vorstellunggesprach = arr1[10];
                        my.referenznummer = arr1[11];

                        list.Add(my);

                    }

                }
            }
            return list;
        }
        public bool speichen(Bewerbung mybewerbung,string pfad)
        {

            try
            {
                bool prufen = File.Exists(pfad);
                using (StreamWriter sw = new StreamWriter(pfad, true))
                {
                    
                    if (prufen)
                    {
                        sw.WriteLine($"{mybewerbung.Firma};{mybewerbung.Adresss};{mybewerbung.Hausnummer};{mybewerbung.PLZ};{mybewerbung.Ort};{mybewerbung.Bezeichnung};{mybewerbung.Email};{mybewerbung.Telefon};{mybewerbung.Anprechpartner};{mybewerbung.Status};{mybewerbung.Vorstellunggesprach};{mybewerbung.referenznummer}");
                    } else
                    { sw.WriteLine("Firma;Adresse;Hausnummer;PLZ;ORT;Bezeichnung;Email;Telefon;Anpprechpartner;;vorstellungsgechpräch;Referenznummer");

                        sw.WriteLine($"{mybewerbung.Firma};{mybewerbung.Adresss};{mybewerbung.Hausnummer};{mybewerbung.PLZ};{mybewerbung.Ort};{mybewerbung.Bezeichnung};{mybewerbung.Email};{mybewerbung.Telefon};{mybewerbung.Anprechpartner};{mybewerbung.Status};{mybewerbung.Vorstellunggesprach};{mybewerbung.referenznummer}");
                    } 
                  
                }
                return true;

           }
            catch (Exception)
            {

                throw;
            }
        }

        public bool update(List<Bewerbung> list, string p)
        {
            using (StreamWriter sw = new StreamWriter(p))
            {
                sw.WriteLine("Firma;Adresse;Hausnummer;PLZ;ORT;Bezeichnung;Email;Telefon;Anpprechpartner;;vorstellungsgechpräch;Referenznummer");
                foreach(Bewerbung mybewerbung in list)
                {
                    sw.WriteLine($"{mybewerbung.Firma};{mybewerbung.Adresss};{mybewerbung.Hausnummer};{mybewerbung.PLZ};{mybewerbung.Ort};{mybewerbung.Bezeichnung};{mybewerbung.Email};{mybewerbung.Telefon};{mybewerbung.Anprechpartner};{mybewerbung.Status};{mybewerbung.Vorstellunggesprach};{mybewerbung.referenznummer}");
                }
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace bewerbunghelper
{
    internal class Controller : Ilogik
    {
        private readonly Idatenhaltung Pase;
        public static string pfad = @"C:\Users\majed\Desktop\bewerbung3.csv";

        public Controller(Idatenhaltung Pase)
        {
            this.Pase = Pase;
        }
        public bool hinzufugen(bool ergebnis, Bewerbung newbewerbung)
        {
            if (ergebnis==false)
            {
                Pase.Speichen(newbewerbung, pfad);
                return true;
            }
            return false;
        }

        public bool ExsistentPrufen(Bewerbung mynew)
        {
            List<Bewerbung> p = Pase.Einlesen(pfad);
            if (p.Count > 0)
            {
                var count = (from bewerbung in p where (bewerbung.Firma == mynew.Firma) select bewerbung).Count();
                if (count > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
            /*public List<Bewerbung> Zeigen(string pfad)
            {
                throw new NotImplementedException();
            }*/
        }

        public List<Bewerbung> AnzeigenBewerbungen(string status)
        {
            List<Bewerbung> ergebnis= Pase.Einlesen(pfad);

            if (status == "Alle")
            {
                return ergebnis;
                
            }
            else if (status == "Abgesagt")
            {
                var abgesagte = (from Bewerbung in ergebnis where Bewerbung.Status == status select Bewerbung).ToList();
                return abgesagte;
            }
            else {
                var bewerbte = (from Bewerbung in ergebnis where Bewerbung.Status == status select Bewerbung).ToList();
                return bewerbte;
            }
        }

        public bool AktualiesernDaten(List<Bewerbung> list)
        {
            bool ergebnis= Pase.Updatedatensatz(list,pfad); 
            if(ergebnis==true)return true;
            else return false;
        }

        public bool SendenEmail(string empfanger, string ansprechpartner, string pfadanhang)
        {
           
           
                try
                {
                    // Absender-E-Mail-Adresse und Anmeldeinformationen
                    string senderEmail = "Hier kommt deine Email adresse";
                    string password = "Hier kommt deine passwort";

                    // Erstellen der E-Mail-Nachricht
                    MailMessage mail = new MailMessage(senderEmail, empfanger);
                    mail.Subject = "Betreff der E-Mail";
                    mail.Body = $"Hallo {ansprechpartner},\n\nHier ist die E-Mail-Nachricht für dich.";

                    // Anlage hinzufügen
                    Attachment attachment = new Attachment(pfadanhang);
                    mail.Attachments.Add(attachment);

                    // Konfigurieren des SMTP-Clients
                    SmtpClient smtpClient = new SmtpClient("email Provider");
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential(senderEmail, password);
                    smtpClient.EnableSsl = true;

                    // Senden der E-Mail
                    smtpClient.Send(mail);
                
                    // Aufräumen
                    mail.Dispose();
                    attachment.Dispose();
                return true;
                }
                catch (Exception ex)
                {
                MessageBox.Show(ex.ToString());
                    return false;
                }
            }
        }
    }


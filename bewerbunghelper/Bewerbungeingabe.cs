using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bewerbunghelper
{
    public partial class Bewerbungeingabe : Form
    {
        private readonly Ilogik My;
        public Bewerbungeingabe(Ilogik Controller)
        {
            InitializeComponent();
            My = Controller;
        }

        private void bt_einelgen_Click(object sender, EventArgs e)
        {
            Bewerbung temp = new Bewerbung();
            temp.Firma = tb_firmaName.Text;
            temp.Adresss = tb_Adresse.Text;
            temp.Hausnummer = tb_hausnummer.Text;
            temp.Bezeichnung = tb_bezeichnung.Text;
            temp.Email = tb_email.Text;
            temp.Anprechpartner = tb_anchprechpar.Text;
            temp.Telefon = tb_telefon.Text;
            temp.PLZ = tb_plz.Text;
            temp.Referenznummer = tb_referenz.Text;
            temp.Ort = tb_ort.Text;
            if (temp.Firma == "")
            {
                MessageBox.Show("Sie haben keine firma name eingegeben bitte geben" +
                    "sie firma Name ein");
            }
            else
            {


                if (My.hinzufugen(My.ExsistentPrufen(temp), temp))
                {



                    MessageBox.Show(" erfolgreich gespeichert");
                    zurucksetzen();

                }
                else
                {
                    MessageBox.Show("diese kontakt daten schon da");
                }


            }
        }
            private void zurucksetzen()
            {
                tb_Adresse.Text = "";
                tb_anchprechpar.Text = "";
                tb_bezeichnung.Text = "";
                tb_email.Text = "";
                tb_firmaName.Text = "";
                tb_hausnummer.Text = "";
                tb_ort.Text = "";
                tb_plz.Text = "";
                tb_referenz.Text = "";
                tb_telefon.Text = "";

            }

            private void btn_anzeigen_Click(object sender, EventArgs e)
            {
                Anzeigen myview = new Anzeigen(My);
                myview.ShowDialog();
            }
        }
    }


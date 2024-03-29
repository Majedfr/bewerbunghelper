﻿using System;
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
    public partial class Anzeigen : Form
    {
        private readonly Ilogik controll;
        List<Bewerbung> Listergebniss = new List<Bewerbung>();
        public Anzeigen(Ilogik Controller)
        {
            InitializeComponent();
            controll = Controller;

        }

        private void btn_suche_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (rbn_alles.Checked)
            {
                string status = "Alle";
                Listergebniss = controll.AnzeigenBewerbungen(status);
                dataGridView1.DataSource = Listergebniss;

            }
            else if (rbn_absage.Checked)
            {
                string status = "Abgesagt";
                Listergebniss = controll.AnzeigenBewerbungen(status);
                dataGridView1.DataSource = Listergebniss;
            }
            else
            {
                string status = "bewerbt";
                Listergebniss = controll.AnzeigenBewerbungen(status);
                dataGridView1.DataSource = Listergebniss;
            }
        }





        private void btn_speichen_Click(object sender, EventArgs e)
        {
            if (Listergebniss != null)
            {
                bool bewertung = controll.AktualiesernDaten(Listergebniss);
                if (bewertung)
                {
                    MessageBox.Show("erfolgreich gespeichert");
                }
                else MessageBox.Show("sie haben nicht geändert");
            }
            else MessageBox.Show("sie haben nicht ausgewählt");
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex; int colindex = e.ColumnIndex;
            Listergebniss[rowindex].Status = dataGridView1.Rows[rowindex].Cells[colindex].ToString();
        }

        private void btn_schicken_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                string anprechpartner = selectedRow.Cells[6].Value.ToString();
                string email = selectedRow.Cells[7].Value.ToString();
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = @"C:\"; // Startverzeichnis festlegen

                // Nur PDF-Dateien anzeigen
                openFileDialog.Filter = "PDF Dateien (*.pdf)|*.pdf|Alle Dateien (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string anhang = openFileDialog.FileName;
                    bool ergebnis = controll.SendenEmail(email, anprechpartner, anhang);
                    if (ergebnis)
                    {
                        MessageBox.Show("erfolgreich gesendet");

                    }
                    else MessageBox.Show("leider nicht geschickt");

                }
                
            }
            else
            {
                // Keine Zeile ist markiert
                MessageBox.Show("Es wurde keine Zeile markiert.");
            }
        }
    }
}


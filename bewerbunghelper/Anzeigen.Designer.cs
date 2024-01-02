namespace bewerbunghelper
{
    partial class Anzeigen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            rbn_absage = new RadioButton();
            rbn_bewerbte = new RadioButton();
            rbn_alles = new RadioButton();
            btn_suche = new Button();
            btn_speichen = new Button();
            btn_schicken = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, -1);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1534, 352);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbn_absage);
            groupBox1.Controls.Add(rbn_bewerbte);
            groupBox1.Controls.Add(rbn_alles);
            groupBox1.Location = new Point(579, 400);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(312, 196);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rbn_absage
            // 
            rbn_absage.AutoSize = true;
            rbn_absage.Location = new Point(49, 159);
            rbn_absage.Margin = new Padding(4, 4, 4, 4);
            rbn_absage.Name = "rbn_absage";
            rbn_absage.Size = new Size(220, 29);
            rbn_absage.TabIndex = 2;
            rbn_absage.TabStop = true;
            rbn_absage.Text = "abgesagte Berwerbung";
            rbn_absage.UseVisualStyleBackColor = true;
            // 
            // rbn_bewerbte
            // 
            rbn_bewerbte.AutoSize = true;
            rbn_bewerbte.Location = new Point(49, 102);
            rbn_bewerbte.Margin = new Padding(4, 4, 4, 4);
            rbn_bewerbte.Name = "rbn_bewerbte";
            rbn_bewerbte.Size = new Size(162, 29);
            rbn_bewerbte.TabIndex = 1;
            rbn_bewerbte.TabStop = true;
            rbn_bewerbte.Text = "Bewerbte plätze";
            rbn_bewerbte.UseVisualStyleBackColor = true;
            // 
            // rbn_alles
            // 
            rbn_alles.AutoSize = true;
            rbn_alles.Location = new Point(49, 52);
            rbn_alles.Margin = new Padding(4, 4, 4, 4);
            rbn_alles.Name = "rbn_alles";
            rbn_alles.Size = new Size(140, 29);
            rbn_alles.TabIndex = 0;
            rbn_alles.TabStop = true;
            rbn_alles.Text = "Alle kontakte";
            rbn_alles.UseVisualStyleBackColor = true;
            // 
            // btn_suche
            // 
            btn_suche.Location = new Point(706, 645);
            btn_suche.Margin = new Padding(4, 4, 4, 4);
            btn_suche.Name = "btn_suche";
            btn_suche.Size = new Size(220, 48);
            btn_suche.TabIndex = 2;
            btn_suche.Text = "Suche";
            btn_suche.UseVisualStyleBackColor = true;
            btn_suche.Click += btn_suche_Click;
            // 
            // btn_speichen
            // 
            btn_speichen.BackColor = Color.Lime;
            btn_speichen.Location = new Point(159, 645);
            btn_speichen.Margin = new Padding(4, 4, 4, 4);
            btn_speichen.Name = "btn_speichen";
            btn_speichen.Size = new Size(220, 48);
            btn_speichen.TabIndex = 3;
            btn_speichen.Text = "speichern";
            btn_speichen.UseVisualStyleBackColor = false;
            btn_speichen.Click += btn_speichen_Click;
            // 
            // btn_schicken
            // 
            btn_schicken.BackColor = Color.Lime;
            btn_schicken.Location = new Point(1135, 645);
            btn_schicken.Margin = new Padding(4, 4, 4, 4);
            btn_schicken.Name = "btn_schicken";
            btn_schicken.Size = new Size(220, 48);
            btn_schicken.TabIndex = 4;
            btn_schicken.Text = "Bewerbung schicken";
            btn_schicken.UseVisualStyleBackColor = false;
            btn_schicken.Click += btn_schicken_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1081, 528);
            label1.Name = "label1";
            label1.Size = new Size(343, 50);
            label1.TabIndex = 5;
            label1.Text = "Bitte markieren sie oben die datensatz um\r\n die bewerbung bei Email zu schicken";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 493);
            label2.Name = "label2";
            label2.Size = new Size(540, 50);
            label2.TabIndex = 6;
            label2.Text = "Bitte wenn sie die informationen einen Datensatz änderen möchten\r\n änderen die die gewünschte feld und drücken sie auf speichern";
            // 
            // Anzeigen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1558, 750);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_schicken);
            Controls.Add(btn_speichen);
            Controls.Add(btn_suche);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Anzeigen";
            Text = "Anzeigen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private RadioButton rbn_absage;
        private RadioButton rbn_bewerbte;
        private RadioButton rbn_alles;
        private Button btn_suche;
        private Button btn_speichen;
        private Button btn_schicken;
        private Label label1;
        private Label label2;
    }
}
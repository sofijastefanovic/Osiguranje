namespace Osiguranje.Forme
{
    partial class KlijentiForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewKlijenti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewKlijenti = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // groupBox1
            this.groupBox1.Controls.Add(this.listViewKlijenti);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista klijenata";

            // listViewKlijenti
            this.listViewKlijenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.columnHeader1,
                this.columnHeader2,
                this.columnHeader3,
                this.columnHeader4,
                this.columnHeader5,
                this.columnHeader6,
                this.columnHeader7,
                this.columnHeader8});
            this.listViewKlijenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewKlijenti.FullRowSelect = true;
            this.listViewKlijenti.GridLines = true;
            this.listViewKlijenti.HideSelection = false;
            this.listViewKlijenti.Location = new System.Drawing.Point(3, 16);
            this.listViewKlijenti.Name = "listViewKlijenti";
            this.listViewKlijenti.Size = new System.Drawing.Size(814, 231);
            this.listViewKlijenti.TabIndex = 0;
            this.listViewKlijenti.UseCompatibleStateImageBehavior = false;
            this.listViewKlijenti.View = System.Windows.Forms.View.Details;

            // columnHeader1
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;

            // columnHeader2
            this.columnHeader2.Text = "Ime/Prezime/Naziv";
            this.columnHeader2.Width = 180;

            // columnHeader3
            this.columnHeader3.Text = "Datum registracije";
            this.columnHeader3.Width = 120;

            // columnHeader4
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 100;

            // columnHeader5
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 150;

            // columnHeader6
            this.columnHeader6.Text = "Telefon";
            this.columnHeader6.Width = 100;

            // columnHeader7
            this.columnHeader7.Text = "Ulica";
            this.columnHeader7.Width = 150;

            // columnHeader8
            this.columnHeader8.Text = "Broj";
            this.columnHeader8.Width = 60;

            // btnDodaj
            this.btnDodaj.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.Location = new System.Drawing.Point(120, 280);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(200, 50);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "DODAJ KLIJENTA";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);

            // btnObrisi
            this.btnObrisi.BackColor = System.Drawing.Color.CadetBlue;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnObrisi.Location = new System.Drawing.Point(440, 280);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(200, 50);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "OBRISI KLIJENTA";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);

            // KlijentiForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(844, 361);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox1);
            this.Name = "KlijentiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klijenti";
            this.Load += new System.EventHandler(this.KlijentiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
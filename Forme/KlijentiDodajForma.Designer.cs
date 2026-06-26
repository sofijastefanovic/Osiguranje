namespace Osiguranje.Forme
{
    partial class KlijentiDodajForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtImePrezimeNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.groupBoxTip = new System.Windows.Forms.GroupBox();
            this.rbFizicko = new System.Windows.Forms.RadioButton();
            this.rbPravno = new System.Windows.Forms.RadioButton();
            this.rbJavnaInstitucija = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumRegistracije = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnDodatniPodaci = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupBoxTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime/Prezime/Naziv";
            // 
            // txtImePrezimeNaziv
            // 
            this.txtImePrezimeNaziv.Location = new System.Drawing.Point(229, 33);
            this.txtImePrezimeNaziv.Name = "txtImePrezimeNaziv";
            this.txtImePrezimeNaziv.Size = new System.Drawing.Size(251, 22);
            this.txtImePrezimeNaziv.TabIndex = 1;
            this.txtImePrezimeNaziv.TextChanged += new System.EventHandler(this.txtImePrezimeNaziv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Aktivan",
            "Neaktivan"});
            this.cmbStatus.Location = new System.Drawing.Point(229, 70);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(251, 24);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ulica";
            // 
            // txtUlica
            // 
            this.txtUlica.Location = new System.Drawing.Point(229, 113);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(251, 22);
            this.txtUlica.TabIndex = 5;
            this.txtUlica.TextChanged += new System.EventHandler(this.txtUlica_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Broj";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(360, 153);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(120, 22);
            this.txtBroj.TabIndex = 7;
            this.txtBroj.TextChanged += new System.EventHandler(this.txtBroj_TextChanged);
            // 
            // groupBoxTip
            // 
            this.groupBoxTip.Controls.Add(this.rbJavnaInstitucija);
            this.groupBoxTip.Controls.Add(this.rbPravno);
            this.groupBoxTip.Controls.Add(this.rbFizicko);
            this.groupBoxTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTip.Location = new System.Drawing.Point(35, 311);
            this.groupBoxTip.Name = "groupBoxTip";
            this.groupBoxTip.Size = new System.Drawing.Size(445, 139);
            this.groupBoxTip.TabIndex = 8;
            this.groupBoxTip.TabStop = false;
            this.groupBoxTip.Text = "Tip klijenta";
            // 
            // rbFizicko
            // 
            this.rbFizicko.AutoSize = true;
            this.rbFizicko.Checked = true;
            this.rbFizicko.Location = new System.Drawing.Point(20, 30);
            this.rbFizicko.Name = "rbFizicko";
            this.rbFizicko.Size = new System.Drawing.Size(140, 29);
            this.rbFizicko.TabIndex = 0;
            this.rbFizicko.TabStop = true;
            this.rbFizicko.Text = "Fizičko lice";
            this.rbFizicko.UseVisualStyleBackColor = true;
            this.rbFizicko.CheckedChanged += new System.EventHandler(this.rbFizicko_CheckedChanged);
            // 
            // rbPravno
            // 
            this.rbPravno.AutoSize = true;
            this.rbPravno.Location = new System.Drawing.Point(20, 60);
            this.rbPravno.Name = "rbPravno";
            this.rbPravno.Size = new System.Drawing.Size(140, 29);
            this.rbPravno.TabIndex = 1;
            this.rbPravno.TabStop = true;
            this.rbPravno.Text = "Pravno lice";
            this.rbPravno.UseVisualStyleBackColor = true;
            this.rbPravno.CheckedChanged += new System.EventHandler(this.rbPravno_CheckedChanged);
            // 
            // rbJavnaInstitucija
            // 
            this.rbJavnaInstitucija.AutoSize = true;
            this.rbJavnaInstitucija.Location = new System.Drawing.Point(20, 90);
            this.rbJavnaInstitucija.Name = "rbJavnaInstitucija";
            this.rbJavnaInstitucija.Size = new System.Drawing.Size(188, 29);
            this.rbJavnaInstitucija.TabIndex = 2;
            this.rbJavnaInstitucija.TabStop = true;
            this.rbJavnaInstitucija.Text = "Javna institucija";
            this.rbJavnaInstitucija.UseVisualStyleBackColor = true;
            this.rbJavnaInstitucija.CheckedChanged += new System.EventHandler(this.rbJavnaInstitucija_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum registracije";
            // 
            // dtpDatumRegistracije
            // 
            this.dtpDatumRegistracije.Location = new System.Drawing.Point(229, 193);
            this.dtpDatumRegistracije.Name = "dtpDatumRegistracije";
            this.dtpDatumRegistracije.Size = new System.Drawing.Size(251, 22);
            this.dtpDatumRegistracije.TabIndex = 10;
            this.dtpDatumRegistracije.Value = new System.DateTime(2026, 6, 26, 13, 48, 43, 0);
            this.dtpDatumRegistracije.ValueChanged += new System.EventHandler(this.dtpDatumRegistracije_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(229, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 22);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(229, 272);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(250, 22);
            this.txtTelefon.TabIndex = 14;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // btnDodatniPodaci
            // 
            this.btnDodatniPodaci.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDodatniPodaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodatniPodaci.Location = new System.Drawing.Point(105, 484);
            this.btnDodatniPodaci.Name = "btnDodatniPodaci";
            this.btnDodatniPodaci.Size = new System.Drawing.Size(321, 49);
            this.btnDodatniPodaci.TabIndex = 15;
            this.btnDodatniPodaci.Text = "DODATNI PODACI";
            this.btnDodatniPodaci.UseVisualStyleBackColor = false;
            this.btnDodatniPodaci.Click += new System.EventHandler(this.btnDodatniPodaci_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(35, 564);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(180, 56);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.Text = "SAČUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(306, 564);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(174, 56);
            this.btnOdustani.TabIndex = 17;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // KlijentiDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(582, 653);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnDodatniPodaci);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDatumRegistracije);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBoxTip);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImePrezimeNaziv);
            this.Controls.Add(this.label1);
            this.Name = "KlijentiDodajForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje klijenta";
            this.groupBoxTip.ResumeLayout(false);
            this.groupBoxTip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImePrezimeNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.GroupBox groupBoxTip;
        private System.Windows.Forms.RadioButton rbJavnaInstitucija;
        private System.Windows.Forms.RadioButton rbPravno;
        private System.Windows.Forms.RadioButton rbFizicko;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatumRegistracije;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnDodatniPodaci;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOdustani;
    }
}
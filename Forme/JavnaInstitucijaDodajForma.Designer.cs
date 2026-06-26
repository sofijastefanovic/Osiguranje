namespace Osiguranje.Forme
{
    partial class JavnaInstitucijaDodajForma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPib = new System.Windows.Forms.TextBox();
            this.txtMaticniBroj = new System.Windows.Forms.TextBox();
            this.txtDelatnost = new System.Windows.Forms.TextBox();
            this.txtKontaktOsobe = new System.Windows.Forms.TextBox();
            this.cmbVrstaInstitucije = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delatnost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kontakt osobe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vrsta institucije";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Matični broj";
            // 
            // txtPib
            // 
            this.txtPib.Location = new System.Drawing.Point(295, 44);
            this.txtPib.Name = "txtPib";
            this.txtPib.Size = new System.Drawing.Size(253, 22);
            this.txtPib.TabIndex = 5;
            this.txtPib.TextChanged += new System.EventHandler(this.txtPib_TextChanged);
            // 
            // txtMaticniBroj
            // 
            this.txtMaticniBroj.Location = new System.Drawing.Point(295, 84);
            this.txtMaticniBroj.Name = "txtMaticniBroj";
            this.txtMaticniBroj.Size = new System.Drawing.Size(253, 22);
            this.txtMaticniBroj.TabIndex = 6;
            this.txtMaticniBroj.TextChanged += new System.EventHandler(this.txtMaticniBroj_TextChanged);
            // 
            // txtDelatnost
            // 
            this.txtDelatnost.Location = new System.Drawing.Point(295, 124);
            this.txtDelatnost.Name = "txtDelatnost";
            this.txtDelatnost.Size = new System.Drawing.Size(253, 22);
            this.txtDelatnost.TabIndex = 7;
            this.txtDelatnost.TextChanged += new System.EventHandler(this.txtDelatnost_TextChanged);
            // 
            // txtKontaktOsobe
            // 
            this.txtKontaktOsobe.Location = new System.Drawing.Point(295, 164);
            this.txtKontaktOsobe.Name = "txtKontaktOsobe";
            this.txtKontaktOsobe.Size = new System.Drawing.Size(253, 22);
            this.txtKontaktOsobe.TabIndex = 8;
            this.txtKontaktOsobe.TextChanged += new System.EventHandler(this.txtKontaktOsobe_TextChanged);
            // 
            // cmbVrstaInstitucije
            // 
            this.cmbVrstaInstitucije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrstaInstitucije.FormattingEnabled = true;
            this.cmbVrstaInstitucije.Items.AddRange(new object[] {
            "republička",
            "pokrajinska",
            "gradska",
            "opštinska"});
            this.cmbVrstaInstitucije.Location = new System.Drawing.Point(295, 201);
            this.cmbVrstaInstitucije.Name = "cmbVrstaInstitucije";
            this.cmbVrstaInstitucije.Size = new System.Drawing.Size(251, 24);
            this.cmbVrstaInstitucije.TabIndex = 9;
            this.cmbVrstaInstitucije.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaInstitucije_SelectedIndexChanged);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(35, 261);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(187, 47);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "SAČUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(359, 261);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(187, 47);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // JavnaInstitucijaDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cmbVrstaInstitucije);
            this.Controls.Add(this.txtKontaktOsobe);
            this.Controls.Add(this.txtDelatnost);
            this.Controls.Add(this.txtMaticniBroj);
            this.Controls.Add(this.txtPib);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JavnaInstitucijaDodajForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Javna institucija - dodatna forma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPib;
        private System.Windows.Forms.TextBox txtMaticniBroj;
        private System.Windows.Forms.TextBox txtDelatnost;
        private System.Windows.Forms.TextBox txtKontaktOsobe;
        private System.Windows.Forms.ComboBox cmbVrstaInstitucije;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOdustani;
    }
}
namespace Osiguranje.Forme
{
    partial class ProcenaDodajForma
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMetodProcene = new System.Windows.Forms.TextBox();
            this.txtNalaz = new System.Windows.Forms.TextBox();
            this.txtPreporuka = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSteta = new System.Windows.Forms.ComboBox();
            this.cmbAngazovanaOsoba = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProcenjeniIznos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSacuvaj.Location = new System.Drawing.Point(138, 330);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(159, 60);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "SACUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum procene:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metod procene:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nalaz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preporuka:";
            // 
            // txtMetodProcene
            // 
            this.txtMetodProcene.Location = new System.Drawing.Point(228, 155);
            this.txtMetodProcene.Name = "txtMetodProcene";
            this.txtMetodProcene.Size = new System.Drawing.Size(171, 30);
            this.txtMetodProcene.TabIndex = 5;
            this.txtMetodProcene.TextChanged += new System.EventHandler(this.txtMetodProcene_TextChanged);
            // 
            // txtNalaz
            // 
            this.txtNalaz.Location = new System.Drawing.Point(228, 194);
            this.txtNalaz.Name = "txtNalaz";
            this.txtNalaz.Size = new System.Drawing.Size(171, 30);
            this.txtNalaz.TabIndex = 7;
            this.txtNalaz.TextChanged += new System.EventHandler(this.txtNalaz_TextChanged);
            // 
            // txtPreporuka
            // 
            this.txtPreporuka.Location = new System.Drawing.Point(228, 236);
            this.txtPreporuka.Name = "txtPreporuka";
            this.txtPreporuka.Size = new System.Drawing.Size(171, 30);
            this.txtPreporuka.TabIndex = 8;
            this.txtPreporuka.TextChanged += new System.EventHandler(this.txtPreporuka_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 30);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Angažovana osoba:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Šteta:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbSteta
            // 
            this.cmbSteta.FormattingEnabled = true;
            this.cmbSteta.Location = new System.Drawing.Point(228, 19);
            this.cmbSteta.Name = "cmbSteta";
            this.cmbSteta.Size = new System.Drawing.Size(171, 33);
            this.cmbSteta.TabIndex = 12;
            this.cmbSteta.SelectedIndexChanged += new System.EventHandler(this.cmbSteta_SelectedIndexChanged);
            // 
            // cmbAngazovanaOsoba
            // 
            this.cmbAngazovanaOsoba.FormattingEnabled = true;
            this.cmbAngazovanaOsoba.Location = new System.Drawing.Point(228, 58);
            this.cmbAngazovanaOsoba.Name = "cmbAngazovanaOsoba";
            this.cmbAngazovanaOsoba.Size = new System.Drawing.Size(171, 33);
            this.cmbAngazovanaOsoba.TabIndex = 13;
            this.cmbAngazovanaOsoba.SelectedIndexChanged += new System.EventHandler(this.cmbAngazovanaOsoba_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Procenjeni iznos:";
            // 
            // txtProcenjeniIznos
            // 
            this.txtProcenjeniIznos.Location = new System.Drawing.Point(228, 272);
            this.txtProcenjeniIznos.Name = "txtProcenjeniIznos";
            this.txtProcenjeniIznos.Size = new System.Drawing.Size(171, 30);
            this.txtProcenjeniIznos.TabIndex = 15;
            this.txtProcenjeniIznos.TextChanged += new System.EventHandler(this.txtProcenjeniIznos_TextChanged);
            // 
            // ProcenaDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(462, 402);
            this.Controls.Add(this.txtProcenjeniIznos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbAngazovanaOsoba);
            this.Controls.Add(this.cmbSteta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPreporuka);
            this.Controls.Add(this.txtNalaz);
            this.Controls.Add(this.txtMetodProcene);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSacuvaj);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProcenaDodajForma";
            this.Text = "ProcenaDodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMetodProcene;
        private System.Windows.Forms.TextBox txtNalaz;
        private System.Windows.Forms.TextBox txtPreporuka;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSteta;
        private System.Windows.Forms.ComboBox cmbAngazovanaOsoba;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProcenjeniIznos;
    }
}
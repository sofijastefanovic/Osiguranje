namespace Osiguranje.Forme
{
    partial class PredmetOsiguranjaDodajForma
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
            this.cmbTipPredmeta = new System.Windows.Forms.ComboBox();
            this.btnDodatniPodaci = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip predmeta";
            // 
            // cmbTipPredmeta
            // 
            this.cmbTipPredmeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipPredmeta.FormattingEnabled = true;
            this.cmbTipPredmeta.Items.AddRange(new object[] {
            "Vozilo",
            "Lice",
            "Putovanje",
            "Odgovornost",
            "Životinja",
            "Usev",
            "Pokretna imovina",
            "Nekretnina"});
            this.cmbTipPredmeta.Location = new System.Drawing.Point(226, 44);
            this.cmbTipPredmeta.Name = "cmbTipPredmeta";
            this.cmbTipPredmeta.Size = new System.Drawing.Size(231, 24);
            this.cmbTipPredmeta.TabIndex = 1;
            this.cmbTipPredmeta.SelectedIndexChanged += new System.EventHandler(this.cmbTipPredmeta_SelectedIndexChanged);
            // 
            // btnDodatniPodaci
            // 
            this.btnDodatniPodaci.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDodatniPodaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodatniPodaci.Location = new System.Drawing.Point(136, 102);
            this.btnDodatniPodaci.Name = "btnDodatniPodaci";
            this.btnDodatniPodaci.Size = new System.Drawing.Size(224, 48);
            this.btnDodatniPodaci.TabIndex = 2;
            this.btnDodatniPodaci.Text = "DODATNI PODACI";
            this.btnDodatniPodaci.UseVisualStyleBackColor = false;
            this.btnDodatniPodaci.Click += new System.EventHandler(this.btnDodatniPodaci_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(35, 172);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(178, 48);
            this.btnSacuvaj.TabIndex = 3;
            this.btnSacuvaj.Text = "SAČUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(279, 172);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(178, 48);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // PredmetOsiguranjaDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnDodatniPodaci);
            this.Controls.Add(this.cmbTipPredmeta);
            this.Controls.Add(this.label1);
            this.Name = "PredmetOsiguranjaDodajForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje predmeta osiguranja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipPredmeta;
        private System.Windows.Forms.Button btnDodatniPodaci;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOdustani;
    }
}
namespace Osiguranje.Forme
{
    partial class ProceniteljDodajForma
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
            this.txtLicenca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipProcenitelja = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Licenca";
            // 
            // txtLicenca
            // 
            this.txtLicenca.Location = new System.Drawing.Point(258, 41);
            this.txtLicenca.Name = "txtLicenca";
            this.txtLicenca.Size = new System.Drawing.Size(201, 22);
            this.txtLicenca.TabIndex = 1;
            this.txtLicenca.TextChanged += new System.EventHandler(this.txtLicenca_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip procenitelja";
            // 
            // cmbTipProcenitelja
            // 
            this.cmbTipProcenitelja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipProcenitelja.FormattingEnabled = true;
            this.cmbTipProcenitelja.Items.AddRange(new object[] {
            "Za vozila",
            "Za imovinu",
            "Za zdravstvo",
            "Za specijalne štete"});
            this.cmbTipProcenitelja.Location = new System.Drawing.Point(256, 82);
            this.cmbTipProcenitelja.Name = "cmbTipProcenitelja";
            this.cmbTipProcenitelja.Size = new System.Drawing.Size(202, 24);
            this.cmbTipProcenitelja.TabIndex = 3;
            this.cmbTipProcenitelja.SelectedIndexChanged += new System.EventHandler(this.cmbTipProcenitelja_SelectedIndexChanged);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(290, 149);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(168, 49);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(35, 149);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(168, 49);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "SAČUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // ProceniteljDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(482, 233);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cmbTipProcenitelja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLicenca);
            this.Controls.Add(this.label1);
            this.Name = "ProceniteljDodajForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodatni podaci - procenitelj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLicenca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipProcenitelja;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}
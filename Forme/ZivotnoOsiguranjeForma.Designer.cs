namespace Osiguranje.Forme
{
    partial class ZivotnoOsiguranjeForma
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
            this.txtSumaOsiguranja = new System.Windows.Forms.TextBox();
            this.txtKorisniciIsplate = new System.Windows.Forms.TextBox();
            this.txtTipIsplate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSacuvaj.Location = new System.Drawing.Point(120, 196);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(179, 59);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "SACUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suma osiguranja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Korisnici isplate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tip isplate:";
            // 
            // txtSumaOsiguranja
            // 
            this.txtSumaOsiguranja.Location = new System.Drawing.Point(199, 25);
            this.txtSumaOsiguranja.Name = "txtSumaOsiguranja";
            this.txtSumaOsiguranja.Size = new System.Drawing.Size(172, 30);
            this.txtSumaOsiguranja.TabIndex = 4;
            this.txtSumaOsiguranja.TextChanged += new System.EventHandler(this.txtSumaOsiguranja_TextChanged);
            // 
            // txtKorisniciIsplate
            // 
            this.txtKorisniciIsplate.Location = new System.Drawing.Point(199, 77);
            this.txtKorisniciIsplate.Name = "txtKorisniciIsplate";
            this.txtKorisniciIsplate.Size = new System.Drawing.Size(172, 30);
            this.txtKorisniciIsplate.TabIndex = 5;
            this.txtKorisniciIsplate.TextChanged += new System.EventHandler(this.txtKorisniciIsplate_TextChanged);
            // 
            // txtTipIsplate
            // 
            this.txtTipIsplate.Location = new System.Drawing.Point(199, 128);
            this.txtTipIsplate.Name = "txtTipIsplate";
            this.txtTipIsplate.Size = new System.Drawing.Size(172, 30);
            this.txtTipIsplate.TabIndex = 6;
            this.txtTipIsplate.TextChanged += new System.EventHandler(this.txtTipIsplate_TextChanged);
            // 
            // ZivotnoOsiguranjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(405, 292);
            this.Controls.Add(this.txtTipIsplate);
            this.Controls.Add(this.txtKorisniciIsplate);
            this.Controls.Add(this.txtSumaOsiguranja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSacuvaj);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ZivotnoOsiguranjeForma";
            this.Text = "ZivotnoOsiguranje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSumaOsiguranja;
        private System.Windows.Forms.TextBox txtKorisniciIsplate;
        private System.Windows.Forms.TextBox txtTipIsplate;
    }
}
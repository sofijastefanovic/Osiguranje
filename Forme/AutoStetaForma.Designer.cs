namespace Osiguranje.Forme
{
    partial class AutoStetaForma
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtZapisnik = new System.Windows.Forms.TextBox();
            this.txtServis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zapisnik policije:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servis:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSacuvaj.Location = new System.Drawing.Point(110, 152);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(177, 57);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "SACUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtZapisnik
            // 
            this.txtZapisnik.Location = new System.Drawing.Point(236, 28);
            this.txtZapisnik.Name = "txtZapisnik";
            this.txtZapisnik.Size = new System.Drawing.Size(158, 30);
            this.txtZapisnik.TabIndex = 5;
            this.txtZapisnik.TextChanged += new System.EventHandler(this.txtZapisnik_TextChanged);
            // 
            // txtServis
            // 
            this.txtServis.Location = new System.Drawing.Point(236, 82);
            this.txtServis.Name = "txtServis";
            this.txtServis.Size = new System.Drawing.Size(158, 30);
            this.txtServis.TabIndex = 6;
            this.txtServis.TextChanged += new System.EventHandler(this.txtServis_TextChanged);
            // 
            // AutoStetaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(439, 248);
            this.Controls.Add(this.txtServis);
            this.Controls.Add(this.txtZapisnik);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AutoStetaForma";
            this.Text = "AutoSteta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtZapisnik;
        private System.Windows.Forms.TextBox txtServis;
    }
}
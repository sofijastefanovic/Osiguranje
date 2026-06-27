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
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSacuvaj.Location = new System.Drawing.Point(144, 293);
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
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum procene:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metod procene:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nalaz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preporuka:";
            // 
            // txtMetodProcene
            // 
            this.txtMetodProcene.Location = new System.Drawing.Point(230, 89);
            this.txtMetodProcene.Name = "txtMetodProcene";
            this.txtMetodProcene.Size = new System.Drawing.Size(171, 30);
            this.txtMetodProcene.TabIndex = 5;
            this.txtMetodProcene.TextChanged += new System.EventHandler(this.txtMetodProcene_TextChanged);
            // 
            // txtNalaz
            // 
            this.txtNalaz.Location = new System.Drawing.Point(230, 147);
            this.txtNalaz.Name = "txtNalaz";
            this.txtNalaz.Size = new System.Drawing.Size(171, 30);
            this.txtNalaz.TabIndex = 7;
            this.txtNalaz.TextChanged += new System.EventHandler(this.txtNalaz_TextChanged);
            // 
            // txtPreporuka
            // 
            this.txtPreporuka.Location = new System.Drawing.Point(230, 208);
            this.txtPreporuka.Name = "txtPreporuka";
            this.txtPreporuka.Size = new System.Drawing.Size(171, 30);
            this.txtPreporuka.TabIndex = 8;
            this.txtPreporuka.TextChanged += new System.EventHandler(this.txtPreporuka_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 30);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ProcenaDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(462, 402);
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
    }
}
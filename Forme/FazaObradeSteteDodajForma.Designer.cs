namespace Osiguranje.Forme
{
    partial class FazaObradeSteteDodajForma
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOdgovornoLice = new System.Windows.Forms.TextBox();
            this.txtOdluka = new System.Windows.Forms.TextBox();
            this.txtDokumentacija = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSteta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Location = new System.Drawing.Point(239, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "SACUVAJ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum pocetka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum zavrsetka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Odgovorno lice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Odluka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Potrebna dokumentacija:";
            // 
            // txtOdgovornoLice
            // 
            this.txtOdgovornoLice.Location = new System.Drawing.Point(267, 177);
            this.txtOdgovornoLice.Name = "txtOdgovornoLice";
            this.txtOdgovornoLice.Size = new System.Drawing.Size(170, 30);
            this.txtOdgovornoLice.TabIndex = 8;
            this.txtOdgovornoLice.TextChanged += new System.EventHandler(this.txtOdgovornoLice_TextChanged);
            // 
            // txtOdluka
            // 
            this.txtOdluka.Location = new System.Drawing.Point(267, 227);
            this.txtOdluka.Name = "txtOdluka";
            this.txtOdluka.Size = new System.Drawing.Size(170, 30);
            this.txtOdluka.TabIndex = 9;
            this.txtOdluka.TextChanged += new System.EventHandler(this.txtOdluka_TextChanged);
            // 
            // txtDokumentacija
            // 
            this.txtDokumentacija.Location = new System.Drawing.Point(267, 278);
            this.txtDokumentacija.Name = "txtDokumentacija";
            this.txtDokumentacija.Size = new System.Drawing.Size(170, 30);
            this.txtDokumentacija.TabIndex = 10;
            this.txtDokumentacija.TextChanged += new System.EventHandler(this.txtDokumentacija_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 30);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(267, 129);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(170, 30);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Šteta:";
            // 
            // cmbSteta
            // 
            this.cmbSteta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSteta.FormattingEnabled = true;
            this.cmbSteta.Location = new System.Drawing.Point(267, 32);
            this.cmbSteta.Name = "cmbSteta";
            this.cmbSteta.Size = new System.Drawing.Size(172, 33);
            this.cmbSteta.TabIndex = 14;
            this.cmbSteta.SelectedIndexChanged += new System.EventHandler(this.cmbSteta_SelectedIndexChanged);
            // 
            // FazaObradeSteteDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(642, 432);
            this.Controls.Add(this.cmbSteta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtDokumentacija);
            this.Controls.Add(this.txtOdluka);
            this.Controls.Add(this.txtOdgovornoLice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FazaObradeSteteDodajForma";
            this.Text = "FazaObradeSteteDodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOdgovornoLice;
        private System.Windows.Forms.TextBox txtOdluka;
        private System.Windows.Forms.TextBox txtDokumentacija;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSteta;
    }
}
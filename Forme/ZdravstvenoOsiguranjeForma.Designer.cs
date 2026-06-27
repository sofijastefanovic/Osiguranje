namespace Osiguranje.Forme
{
    partial class ZdravstvenoOsiguranjeForma
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
            this.txtMreza = new System.Windows.Forms.TextBox();
            this.txtObuhvacena = new System.Windows.Forms.TextBox();
            this.txtGodisnji = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSacuvaj.Location = new System.Drawing.Point(175, 224);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(164, 55);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "SACUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mreza ustanova:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Obuhvacena pokrica:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Godisnji limit:";
            // 
            // txtMreza
            // 
            this.txtMreza.Location = new System.Drawing.Point(261, 38);
            this.txtMreza.Name = "txtMreza";
            this.txtMreza.Size = new System.Drawing.Size(162, 30);
            this.txtMreza.TabIndex = 4;
            this.txtMreza.TextChanged += new System.EventHandler(this.txtMreza_TextChanged);
            // 
            // txtObuhvacena
            // 
            this.txtObuhvacena.Location = new System.Drawing.Point(261, 93);
            this.txtObuhvacena.Name = "txtObuhvacena";
            this.txtObuhvacena.Size = new System.Drawing.Size(162, 30);
            this.txtObuhvacena.TabIndex = 5;
            this.txtObuhvacena.TextChanged += new System.EventHandler(this.txtObuhvacena_TextChanged);
            // 
            // txtGodisnji
            // 
            this.txtGodisnji.Location = new System.Drawing.Point(261, 142);
            this.txtGodisnji.Name = "txtGodisnji";
            this.txtGodisnji.Size = new System.Drawing.Size(162, 30);
            this.txtGodisnji.TabIndex = 6;
            this.txtGodisnji.TextChanged += new System.EventHandler(this.txtGodisnji_TextChanged);
            // 
            // ZdravstvenoOsiguranjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(476, 318);
            this.Controls.Add(this.txtGodisnji);
            this.Controls.Add(this.txtObuhvacena);
            this.Controls.Add(this.txtMreza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSacuvaj);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ZdravstvenoOsiguranjeForma";
            this.Text = "ZdravstvenoOsiguranje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMreza;
        private System.Windows.Forms.TextBox txtObuhvacena;
        private System.Windows.Forms.TextBox txtGodisnji;
    }
}